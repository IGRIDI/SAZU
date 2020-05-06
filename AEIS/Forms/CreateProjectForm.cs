using System;
using System.Windows.Forms;

namespace AEIS.Forms
{
    public partial class CreateProjectForm : Form
    {
        public CreateProjectForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            MyDatabase.Instance.CreateProject(textBoxName.Text, dateTimePickerStart.Value);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
