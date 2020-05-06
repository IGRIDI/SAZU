using System;
using System.Linq;
using System.Windows.Forms;

namespace AEIS.Forms
{
    public partial class MainForm : Form
    {
        private int[] defaultTrackBarPositions = new int[] { 1000, 500, 0 };
        private string[] modeDescriptions = new string[] {
            "Режим A используется при критических последствиях отказа",
            "Режим B используется, если отказ существенно не повлияет на функционирование системы",
            "Режим C используется, если отказ оказывает минимальное влияние на функционирование системы"
        };
        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackBarFailureCost.Value = defaultTrackBarPositions[comboBoxMode.SelectedIndex];
            labelModeDescription.Text = modeDescriptions[comboBoxMode.SelectedIndex];
        }

        private void trackBarFailureCost_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownFailureCost.Value = trackBarFailureCost.Value / 1000m;
        }

        private void numericUpDownFailureCost_ValueChanged(object sender, EventArgs e)
        {
            trackBarFailureCost.Value = (int)(numericUpDownFailureCost.Value * 1000);
        }

        private void buttonAddFailureCost_Click(object sender, EventArgs e)
        {
            textBoxFailureCostVector.Text += (textBoxFailureCostVector.Text.Length > 0 ? ";" : "") + numericUpDownFailureCost.Value;
        }

        private void buttonCalcSystemRisk_Click(object sender, EventArgs e)
        {
            var numbers = textBoxFailureCostVector.Text.Split(';').Select(str => ParseDouble(str));
            var avg = numbers.Aggregate(0d, (acc, n) => acc + n) / numbers.Count();
            textBoxSystemRisk.Text = avg.ToString();
        }
    }
}
