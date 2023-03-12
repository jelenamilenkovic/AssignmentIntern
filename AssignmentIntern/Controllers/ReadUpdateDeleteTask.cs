using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentIntern.Controllers;
using AssignmentIntern.View;

namespace AssignmentIntern.Controllers
{
    public partial class ReadUpdateDeleteTask : Form
    {
        TaskBasic task;
        public ReadUpdateDeleteTask()
        {
            InitializeComponent();
            task = new TaskBasic();
            WriteData();
        }
        public void WriteData()
        {
            this.dataGridView1.Rows.Clear();
            groupBox2.Visible = false;
            List<TaskView> podaci = DTOManager.readTasks();

            foreach (TaskView p in podaci)
            {
                this.dataGridView1.Rows.Add(new string[] { p.Id.ToString(), p.Title, p.Description, p.Due_Date.ToString(), p.Assignee.ToString() });

            }
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0)
            {
                MessageBox.Show("Choose task");
                return;
            }

            int idTask = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string poruka = "Do you want to delete the task?";
            string title = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.deleteTask(idTask);
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
            label5.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Value=Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task.Id = Int32.Parse(label5.Text);
            task.Title = textBox1.Text;
            task.Description = textBox2.Text;
            task.Due_Date = dateTimePicker1.Value;

            DTOManager.updateTask(task);
        }   
    }
}
