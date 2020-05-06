using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.ComponentModel;
using ObsolescenceLaw = System.Func<double, double, double, double, double>;
using System.Drawing;
using System.Collections.Generic;

namespace AEIS.Forms
{
    public partial class MainForm : Form
    {
        private Tuple<string, ObsolescenceLaw>[] functions = new Tuple<string, ObsolescenceLaw>[] {
            new Tuple<string, ObsolescenceLaw>("y=ae^(bx)", (double e0, double k, double t, double tm) => e0*Math.Pow(Math.E, k*(t-tm))),
            new Tuple<string, ObsolescenceLaw>("y=a*ln(x+b)", (double e0, double k, double t, double tm) => -e0*Math.Log(k*(t-tm))),
            new Tuple<string, ObsolescenceLaw>("y=ax^2", (double e0, double k, double t, double tm) => -e0*Math.Pow(k*(t-tm), 2)),
            new Tuple<string, ObsolescenceLaw>("y=ax^3", (double e0, double k, double t, double tm) => -e0*Math.Pow(k*(t-tm), 3)),
            new Tuple<string, ObsolescenceLaw>("y=ax^(1/2)", (double e0, double k, double t, double tm) => -e0*Math.Sqrt(k*(t-tm))),
        };
        private BindingList<string> timeSource = new BindingList<string>() { "день", "месяц", "год" };
        private Tuple<int, int>[] minMaxK = new Tuple<int, int>[] {
            new Tuple<int, int>(-100, 100),
            new Tuple<int, int>(0, 100),
            new Tuple<int, int>(-100, 100),
            new Tuple<int, int>(-100, 100),
            new Tuple<int, int>(0, 100),
        };
        private double[] timeMultipliers = new double[] {1, 30, 365};
        private Tuple<string, string>[] kNotes = new Tuple<string, string>[] {
            new Tuple<string, string>("80-100", "Остаточных ресурсов достаточно для выполнения 3-х и более рабочих циклов системы"),
        };

        public MainForm()
        {
            InitializeComponent();
            comboBoxTime.SelectedIndex = 0;
            comboBoxFunctions.Items.AddRange(functions.Select(tuple => tuple.Item1).ToArray());
            comboBoxFunctions.SelectedIndex = 0;
            comboBoxProjects.ValueMember = "Id";
            comboBoxProjects.DisplayMember = "Name";
            var projects = MyDatabase.Instance.GetProjects();
            comboBoxProjects.DataSource = projects;
            if (projects.Count > 0) comboBoxProjects.SelectedIndex = 0;
            comboBoxTime.DataSource = timeSource;

            chartMain.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartMain.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartMain.ChartAreas[0].AxisX.Title = "t";
            chartMain.ChartAreas[0].AxisY.Title = "E";

            chartAdvanced.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartAdvanced.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartAdvanced.ChartAreas[0].AxisX.Title = "t";
            chartAdvanced.ChartAreas[0].AxisY.Title = "E";

            comboBoxMode.SelectedIndex = 0;

            dataGridViewKNotes.DataSource = kNotes;
            dataGridViewKNotes.Columns[0].HeaderText = "Параметр k";
            dataGridViewKNotes.Columns[1].HeaderText = "Пояснение";
            dataGridViewKNotes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewKNotes.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void buttonPlotMain_Click(object sender, EventArgs e)
        {
            chartMain.Series.Clear();
            var series = new Series
            {
                Name = "E",
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
            };
            var k = ParseDouble(numericUpDownK.Text);
            var e0 = ParseDouble(numericUpDownE.Text);
            double tm = (double)numericUpDownTime.Value;
            tm *= timeMultipliers[comboBoxTime.SelectedIndex];
            var func = functions[comboBoxFunctions.SelectedIndex].Item2;
            double t = 0;
            double max = tm;
            if (comboBoxFunctions.SelectedIndex == 1 || comboBoxFunctions.SelectedIndex == 4) {
                t = tm + 1;
                max += 11;
            }
            for (; t < max; ++t)
            {
                var point = new DataPoint(t, func(e0, k, t, tm));
                series.Points.Add(point);
            }
            chartMain.Series.Add(series);
            chartMain.Series.Add(GetE0Series(e0, 0, max));
        }

        private double ParseDouble(string str)
        {
            double.TryParse(str.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double value);
            return value;
        }

        private void numericUpDownTime_ValueChanged(object sender, EventArgs e)
        {
            var val = numericUpDownTime.Value;
            var mod10 = val % 10;
            if (val % 100 != 10)
            {
                if (mod10 == 1)
                {
                    timeSource[0] = "день";
                    timeSource[1] = "месяц";
                    timeSource[2] = "год";
                    return;
                }
                else if (mod10 >= 2 && mod10 <= 4)
                {
                    timeSource[0] = "дня";
                    timeSource[1] = "месяца";
                    timeSource[2] = "года";
                    return;
                }
            }
            timeSource[0] = "дней";
            timeSource[1] = "месяцев";
            timeSource[2] = "лет";
        }

        private void chart_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }

        private void comboBoxFunctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var minMax = minMaxK[comboBoxFunctions.SelectedIndex];
            numericUpDownK.Minimum = minMax.Item1;
            numericUpDownK.Maximum = minMax.Item2;
        }

        private Series GetE0Series(double e0, double t, double tm) {
            var series = new Series
            {
                Name = "E0",
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
            };
            var point = new DataPoint(t, e0);
            series.Points.Add(point);
            point = new DataPoint(tm, e0);
            series.Points.Add(point);
            return series;
        }

        private void dataGridViewKNotes_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewKNotes.ClearSelection();
        }
    }
}
