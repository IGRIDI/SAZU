using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEIS.Forms
{
    public partial class ExtraFunctionsForm : Form
    {
        public decimal K { get; private set; }
        public decimal E0 { get; private set; }
        public DateTime UsageEndDate { get; private set; }
        public ExtraFunctionsForm()
        {
            InitializeComponent();
        }

        public void SetMinDate(DateTime date) {
            dateTimePicker.MinDate = date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            K = numericUpDownK.Value;
            E0 = numericUpDownE.Value;
            UsageEndDate = dateTimePicker.Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
