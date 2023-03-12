using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using AssignmentIntern.Controllers;
using AssignmentIntern.Models;
using AssignmentIntern.View;


namespace AssignmentIntern
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        List<Panel> listPanel = new List<Panel>();
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            panelTask.Visible = false;
            panelEmployee.Visible = false;
            panelDepartment.Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void Task_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTask);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmployee);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDepartment);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CreateEmployee());

            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CreateTask());

            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ReadUpdateDeleteTask());

            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ReadUpdateDeleteEmployee());

            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CreateDepartment());

            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ReadUpdateDeleteDepartment());

            hideSubMenu();
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AdditionalFunctionality());

            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Statistic());

            hideSubMenu();
        }
    }
}
