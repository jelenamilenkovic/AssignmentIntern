using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentIntern.View;

namespace AssignmentIntern.Controllers
{
    public partial class ReadUpdateDeleteDepartment : Form
    {
        DepartmentBasic dep;
        public ReadUpdateDeleteDepartment()
        {
            InitializeComponent();
            dep = new DepartmentBasic();
            WriteData();
        }
        public void WriteData()
        {
            this.dataGridView1.Rows.Clear();
            groupBox2.Visible = false;
            List<DepartmentView> podaci = DTOManager.readDepartments();

            foreach (DepartmentView p in podaci)
            {
                this.dataGridView1.Rows.Add(new string[] { p.Id.ToString(),p.DepartmentName, p.Country, p.City });

            }
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
            {
                MessageBox.Show("Choose department");
                return;
            }

            int idDep = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string poruka = "Do you want to delete the department?";
            string title = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.deleteDepartment(idDep);
                MessageBox.Show("Successfully");
                this.WriteData();
            }
            else
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            groupBox2.Visible = true;
            label5.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            dep.Id = Int32.Parse(label5.Text);
            dep.City = textBox2.Text;
            dep.DepartmentName = textBox1.Text;
            dep.Country = textBox3.Text;

            DTOManager.updateDepartment(dep);
        }
    }
}
