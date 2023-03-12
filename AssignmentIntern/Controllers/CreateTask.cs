using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentIntern.Models;
using AssignmentIntern.View;

namespace AssignmentIntern.Controllers
{
    public partial class CreateTask : Form
    {
        public CreateTask()
        {
            InitializeComponent();

            WriteData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskBasic t= new TaskBasic();
            t.Assignee = DTOManager.readEmployee(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            t.Title = textBox1.Text;
            t.Description = textBox2.Text;
            t.Due_Date = dateTimePicker1.Value;
            DTOManager.createTask(t); ;
        }
        public void WriteData()
        {
            this.dataGridView1.Rows.Clear();
            
            List<EmployeeView> podaci = DTOManager.readEmployees();

            foreach (EmployeeView p in podaci)
            {
                this.dataGridView1.Rows.Add(new string[] { p.Id.ToString(), p.Department.ToString(), p.FullName, p.Email, p.PhoneNumber, p.DateOfBirth.ToString(), p.MonthlySalary.ToString() });

            }
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();

        }
    }
}
