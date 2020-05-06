using AEIS.Models;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace AEIS.Forms
{
    public partial class PointListForm : Form
    {
        public PointListForm()
        {
            InitializeComponent();

            dataGridView.DataSource = MyDatabase.Instance.GetPoints();
            dataGridView.Columns["Id"].ReadOnly = true;
            dataGridView.Columns["Id"].HeaderText = "ID";
            dataGridView.Columns["Project"].Visible = false;
            dataGridView.Columns["DateTime"].HeaderText = "Дата и время";
            dataGridView.Columns["DateTime"].FillWeight = 200;
            dataGridView.Columns["DateTime"].ReadOnly = false;
            dataGridView.Columns["DateTime"].DefaultCellStyle.Format = "yyyy.MM.dd HH:mm:ss";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var projects = MyDatabase.Instance.GetProjects();
            comboBoxProjects.ValueMember = "Id";
            comboBoxProjects.DisplayMember = "Name";
            comboBoxProjects.DataSource = projects;
        }

        public void SelectProject(Project project)
        {
            comboBoxProjects.SelectedItem = project;
        }

        private void comboBoxProjects_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var projectId = ((Project)comboBoxProjects.SelectedItem).Id;
            dataGridView.DataSource = MyDatabase.Instance.GetPoints().Where(point => point.Project.Id == projectId).ToList();
        }

        private void buttonAddPoint_Click(object sender, System.EventArgs e)
        {
            var form = new CreatePointForm();
            form.SelectProject((Project)comboBoxProjects.SelectedItem);
            form.ShowDialog();
        }

        private void buttonRemovePoint_Click(object sender, System.EventArgs e)
        {
            if (dataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Не выбрана точка", "Ошибка");
                return;
            }
            var list = (BindingSource)dataGridView.DataSource;
            var point = (Point)list[dataGridView.SelectedRows[0].Index];
            var result = MessageBox.Show("Вы действительно хотите удалить точку с ID " + point.Id + "?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            MyDatabase.Instance.RemovePoint(point);
        }

        private void dataGridView_SelectionChanged(object sender, System.EventArgs e)
        {
            var enabled = dataGridView.SelectedRows.Count > 0;
            buttonRemovePoint.Enabled = enabled;
        }
    }
}
