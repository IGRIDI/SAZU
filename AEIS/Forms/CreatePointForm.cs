using AEIS.Models;
using System.Windows.Forms;

namespace AEIS.Forms
{
    public partial class CreatePointForm : Form
    {
        public CreatePointForm()
        {
            InitializeComponent();
            comboBoxProjects.ValueMember = "Id";
            comboBoxProjects.DisplayMember = "Name";
            comboBoxProjects.DataSource = MyDatabase.Instance.GetProjects();
            comboBoxProjects.SelectedIndex = 0;
        }

        public void SelectProject(Project project)
        {
            comboBoxProjects.SelectedItem = project;
        }

        private void buttonCreate_Click(object sender, System.EventArgs e)
        {
            var projectId = ((Project)comboBoxProjects.SelectedItem).Id;
            MyDatabase.Instance.CreatePoint(projectId, dateTimePicker.Value);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
