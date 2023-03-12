
namespace AssignmentIntern
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDepartment = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Department = new System.Windows.Forms.Button();
            this.panelTask = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelDepartment.SuspendLayout();
            this.panelTask.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.Controls.Add(this.button4);
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.panelDepartment);
            this.panelSideMenu.Controls.Add(this.Department);
            this.panelSideMenu.Controls.Add(this.panelTask);
            this.panelSideMenu.Controls.Add(this.btnTask);
            this.panelSideMenu.Controls.Add(this.panelEmployee);
            this.panelSideMenu.Controls.Add(this.btnEmployee);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(236, 450);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(0, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Additional Functionality";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelDepartment
            // 
            this.panelDepartment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDepartment.Controls.Add(this.button10);
            this.panelDepartment.Controls.Add(this.button11);
            this.panelDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDepartment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelDepartment.Location = new System.Drawing.Point(0, 238);
            this.panelDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.panelDepartment.Name = "panelDepartment";
            this.panelDepartment.Size = new System.Drawing.Size(236, 44);
            this.panelDepartment.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.Location = new System.Drawing.Point(0, 22);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(236, 22);
            this.button10.TabIndex = 11;
            this.button10.Text = "Update Department";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(236, 22);
            this.button11.TabIndex = 10;
            this.button11.Text = "Create Department";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Department
            // 
            this.Department.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Department.Dock = System.Windows.Forms.DockStyle.Top;
            this.Department.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Department.Location = new System.Drawing.Point(0, 188);
            this.Department.Margin = new System.Windows.Forms.Padding(0);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(236, 50);
            this.Department.TabIndex = 9;
            this.Department.Text = "Department";
            this.Department.UseVisualStyleBackColor = false;
            this.Department.Click += new System.EventHandler(this.button12_Click);
            // 
            // panelTask
            // 
            this.panelTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTask.Controls.Add(this.button6);
            this.panelTask.Controls.Add(this.button7);
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTask.Location = new System.Drawing.Point(0, 144);
            this.panelTask.Margin = new System.Windows.Forms.Padding(0);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(236, 44);
            this.panelTask.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(0, 22);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(236, 22);
            this.button6.TabIndex = 7;
            this.button6.Text = "Update Task";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(236, 22);
            this.button7.TabIndex = 6;
            this.button7.Text = "Create Task";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTask.Location = new System.Drawing.Point(0, 94);
            this.btnTask.Margin = new System.Windows.Forms.Padding(0);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(236, 50);
            this.btnTask.TabIndex = 5;
            this.btnTask.Text = "Task";
            this.btnTask.UseVisualStyleBackColor = false;
            this.btnTask.Click += new System.EventHandler(this.Task_Click);
            // 
            // panelEmployee
            // 
            this.panelEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelEmployee.Controls.Add(this.button3);
            this.panelEmployee.Controls.Add(this.button2);
            this.panelEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelEmployee.Location = new System.Drawing.Point(0, 50);
            this.panelEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(236, 44);
            this.panelEmployee.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 22);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 22);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update Employee";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(236, 50);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChildForm.Location = new System.Drawing.Point(236, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(564, 409);
            this.panelChildForm.TabIndex = 1;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(0, 332);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 50);
            this.button4.TabIndex = 11;
            this.button4.Text = "Statistic";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelDepartment.ResumeLayout(false);
            this.panelTask.ResumeLayout(false);
            this.panelEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button Department;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelDepartment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}

