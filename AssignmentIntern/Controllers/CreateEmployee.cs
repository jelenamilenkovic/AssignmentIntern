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
using System.Net.Mail;

namespace AssignmentIntern.Controllers
{
    public partial class CreateEmployee : Form
    {

        public CreateEmployee()
        {
            InitializeComponent();
            WriteData();
        }
        public bool IsValid(string emailaddress)
        {
            try
            {
                //in database is also added UNIQUE constraint for email
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeBasic empl = new EmployeeBasic();
            empl.Department = DTOManager.readDepartment(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            empl.FullName = textBox1.Text;
            empl.Email = textBox2.Text;
            empl.MonthlySalary = (int)numericUpDown1.Value;
            empl.PhoneNumber = textBox4.Text;
            empl.DateOfBirth = dateTimePicker1.Value;
            if (IsValid(empl.Email)) DTOManager.createEmployee(empl);
        }
        public void WriteData()
        {
            this.dataGridView1.Rows.Clear();
            List<DepartmentView> podaci = DTOManager.readDepartments();

            foreach (DepartmentView p in podaci)
            {
                this.dataGridView1.Rows.Add(new string[] { p.Id.ToString(), p.DepartmentName, p.Country, p.City });

            }
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();

        }
    }
}
