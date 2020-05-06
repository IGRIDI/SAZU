using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AEIS.Models;
using System.Drawing;
using ObsolescenceLaw = System.Func<double, double, double, double, double>;

namespace AEIS.Forms
{
    public partial class MainForm : Form
    {
        private readonly double chartResolution = 0.1; // 1/10 of day
        private readonly ObsolescenceLaw predictionFunction = (double e0, double k, double t, double tm) => e0 * Math.Pow(Math.E, k * (t - tm));
        private readonly Func<double, double, double> advancedFunction = (double pointTime, double t) => Math.Exp(pointTime - t);
        private void buttonCreateProject_Click(object sender, EventArgs e)
        {
            new CreateProjectForm().ShowDialog();
            if (comboBoxProjects.Items.Count > 0) comboBoxProjects.SelectedIndex = comboBoxProjects.Items.Count - 1;
        }

        private void buttonRemoveProject_Click(object sender, EventArgs e)
        {
            var item = (Project)comboBoxProjects.SelectedItem;
            var result = MessageBox.Show("Вы действительно хотите удалить проект " + item.Name + "?", "Подтвердите удаление проекта", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            MyDatabase.Instance.RemoveProject(item);
        }

        private void buttonViewPoints_Click(object sender, EventArgs e)
        {
            var form = new PointListForm();
            form.SelectProject((Project)comboBoxProjects.SelectedItem);
            form.ShowDialog();
        }

        private void comboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var enabled = comboBoxProjects.SelectedItem != null;
            buttonRemoveProject.Enabled = enabled;
            buttonViewPoints.Enabled = enabled;
            buttonPlotAdvanced.Enabled = enabled;
            buttonExtraFunctions.Enabled = false;
            chartAdvanced.Series.Clear();
        }

        private void buttonPlotAdvanced_Click(object sender, EventArgs e)
        {
            var project = (Project)comboBoxProjects.SelectedItem;
            var points = project.Points;
            if (points == null || points.Count <= 0) {
                MessageBox.Show("Необходимо добавить хотя бы одну точку отказа!", "Ошибка");
                return;
            }
            var maxTime = (int)((points.Max(point => point.DateTime) - project.UsageStart).TotalDays * 1.1 + 1);
            chartAdvanced.Series.Clear();
            var avgSeries = new Series
            {
                Name = "Average",
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
                BorderDashStyle = ChartDashStyle.Solid
            };
            var labelSeries = new Series
            {
                Name = "Labels",
                ChartType = SeriesChartType.Point,
                Color = Color.Black,
                XValueType = ChartValueType.DateTime
            };
            foreach (var point in points)
            {
                var series = new Series
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.Green,
                    BorderDashStyle = ChartDashStyle.Dash,
                    XValueType = ChartValueType.DateTime
                };
                var pointTime = (point.DateTime - project.UsageStart).TotalDays;
                var marker = false;
                int j = 0;
                var x = project.UsageStart;
                for (double t = 0; t < maxTime; t += chartResolution, ++j)
                {
                    var y = advancedFunction(pointTime, t);
                    // average
                    if (avgSeries.Points.Count <= j) avgSeries.Points.AddXY(x, 0);
                    avgSeries.Points[j].YValues[0] += y;
                    // point
                    var pointIdx = series.Points.AddXY(x, y);
                    if (!marker && t >= pointTime)
                    {
                        marker = true;
                        // chart point
                        var dp = series.Points[pointIdx];
                        dp.AxisLabel = point.DateTime.ToString();
                        dp.MarkerStyle = MarkerStyle.Circle;
                        dp.MarkerSize = 8;
                        dp.MarkerColor = Color.Red;

                        // axis point for label
                        pointIdx = labelSeries.Points.AddXY(x, 0);
                        dp = labelSeries.Points[pointIdx];
                        dp.Label = point.DateTime.ToString();
                        dp.MarkerStyle = MarkerStyle.Cross;
                        dp.MarkerSize = 8;
                        dp.MarkerColor = Color.Black;
                    }
                    x = x.AddDays(chartResolution);
                }
                chartAdvanced.Series.Add(series);
            }
            // average series
            var totalPoints = points.Count;
            int i = 0;
            for (double t = 0; t < maxTime; t += chartResolution, ++i)
            {
                avgSeries.Points[i].YValues[0] /= totalPoints;
            }
            chartAdvanced.Series.Add(avgSeries);
            chartAdvanced.Series.Add(labelSeries);
            buttonExtraFunctions.Enabled = true;
        }

        private void buttonExtraFunctions_Click(object sender, EventArgs e)
        {
            var project = (Project)comboBoxProjects.SelectedItem;
            var lastPoint = project.Points.Aggregate((a, b) => a.DateTime > b.DateTime ? a : b);
            var form = new ExtraFunctionsForm();
            form.SetMinDate(lastPoint.DateTime);
            var result = form.ShowDialog();
            if (result != DialogResult.OK) return;

            var k = (double)form.K;
            var E0 = (double)form.E0;
            var usageEnd = form.UsageEndDate;

            // remove points' series
            Series avgSeries = null;
            for (var i = chartAdvanced.Series.Count - 1; i >= 0; --i)
            {
                var series = chartAdvanced.Series[i];
                if (series.Name != "Labels" && series.Name != "Average") chartAdvanced.Series.RemoveAt(i);
                else if (series.Name == "Average") avgSeries = series;
            }

            var predictionSeries = new Series
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Green,
                XValueType = ChartValueType.DateTime
            };
            var maxTime = usageEnd.Subtract(project.UsageStart).TotalDays;
            var x = new DateTime((long) (Math.Ceiling((lastPoint.DateTime.Ticks - project.UsageStart.Ticks) / chartResolution / 10000000d / 86400d) * chartResolution * 10000000 * 86400 + project.UsageStart.Ticks));
            var lastPointTime = x.ToOADate();
            var startTime = x.Subtract(project.UsageStart).TotalDays;

            // remove average line after last point
            if (avgSeries == null) return;
            for (var i = avgSeries.Points.Count - 1; i >= 0; --i)
            {
                var point = avgSeries.Points[i];
                if (point.XValue > lastPointTime) avgSeries.Points.RemoveAt(i);
            }

            // start on avg end
            predictionSeries.Points.AddXY(x, avgSeries.Points[avgSeries.Points.Count - 1].YValues[0]);
            for (double t = startTime; t < maxTime; t += chartResolution)
            {
                var y = predictionFunction(E0, k, t, maxTime);
                var pointIdx = predictionSeries.Points.AddXY(x, y);
                x = x.AddDays(chartResolution);
            }
            x = x.AddDays(-chartResolution);
            chartAdvanced.Series.Add(predictionSeries);
            chartAdvanced.Series.Add(GetE0Series(E0, avgSeries.Points[0].XValue, x.ToOADate()));
        }
    }
}
