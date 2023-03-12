using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AssignmentIntern.View;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentIntern.Controllers
{
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
            WriteData();
        }
        public void WriteData()
        {
            List<string> departments = DTOManager.NamesOfDepartments();
            foreach (string k in departments)
            {
                comboBox1.Items.Add(k);
            }
            comboBox1.SelectedIndex = 1;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            IList<object[]> podaci = DTOManager.statistic("QA");

            foreach (object[] p in podaci)
            {
                this.dataGridView1.Rows.Add(new string[] { (string)p[0], (string)p[1], (string)p[2], (string)p[3], (string)p[4] });

            }
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();
        }
    }
}
