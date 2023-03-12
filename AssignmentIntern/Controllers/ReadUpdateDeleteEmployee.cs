using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AssignmentIntern.Controllers;
using AssignmentIntern.View;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentIntern.Controllers
{
    
    public partial class ReadUpdateDeleteEmployee : Form
    {
        EmployeeBasic empl;
        public ReadUpdateDeleteEmployee()
        {
            InitializeComponent();
            empl = new EmployeeBasic();
            WriteData();
        }

        public void WriteData()
        {
            this.dataGridView1.Rows.Clear();
            groupBox2.Visible = false;
            List<EmployeeView> podaci = DTOManager.readEmployees();

            foreach (EmployeeView p in podaci)
            {
                this.dataGridView1.Rows.Add(new string[] { p.Id.ToString(), p.Department.ToString(),p.FullName,p.Email,p.PhoneNumber,p.DateOfBirth.ToString(),p.MonthlySalary.ToString() });

            }
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
            {
                MessageBox.Show("Choose employee");
                return;
            }

            int idEmployee = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string poruka = "Do you want to delete the employee?";
            string title = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.deleteEmployee(idEmployee);
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
            label6.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            numericUpDown1.Value = Int32.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empl.Id = Int32.Parse(label6.Text);
            empl.FullName = textBox2.Text;
            empl.Email = textBox2.Text;
            empl.PhoneNumber = textBox3.Text;
            empl.MonthlySalary = (int)numericUpDown1.Value;
            DTOManager.updateEmployee(empl);
        }
    }
}
