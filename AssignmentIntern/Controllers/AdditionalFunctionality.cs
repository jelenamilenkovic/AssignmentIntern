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
    public partial class AdditionalFunctionality : Form
    {
        public AdditionalFunctionality()
        {
            InitializeComponent();
            WriteData();
        }
        public void WriteData()
        {
            List<string> departments = DTOManager.NamesOfDepartments();
            foreach( string k in departments)
            {
                comboBox1.Items.Add(k);
            }
            comboBox1.SelectedIndex = 1;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await DTOManager.SendMail(comboBox1.Text, textBox1.Text, textBox2.Text);
        }
    }
}
