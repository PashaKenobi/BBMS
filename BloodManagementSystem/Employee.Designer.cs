namespace BloodManagementSystem
{
    partial class Employee
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
            EmpList = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label9 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            Title = new Label();
            panel1 = new Panel();
            label1 = new Label();
            EmpUName = new TextBox();
            label10 = new Label();
            EmpPass = new TextBox();
            label11 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // EmpList
            // 
            EmpList.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader1, columnHeader2 });
            EmpList.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            EmpList.Location = new Point(357, 122);
            EmpList.Name = "EmpList";
            EmpList.Size = new Size(641, 221);
            EmpList.TabIndex = 64;
            EmpList.UseCompatibleStateImageBehavior = false;
            EmpList.View = View.Details;
            EmpList.SelectedIndexChanged += EmpList_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Employee ID";
            columnHeader3.Width = 140;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Employee Username";
            columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Employee Password";
            columnHeader2.Width = 200;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(600, 60);
            label9.Name = "label9";
            label9.Size = new Size(143, 37);
            label9.TabIndex = 63;
            label9.Text = "Employee";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(Title);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(183, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1051, 48);
            panel2.TabIndex = 62;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(922, 9);
            label8.Name = "label8";
            label8.Size = new Size(95, 32);
            label8.TabIndex = 10;
            label8.Text = "Logout";
            label8.Click += label8_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.Firebrick;
            Title.Location = new Point(307, 9);
            Title.Name = "Title";
            Title.Size = new Size(389, 32);
            Title.TabIndex = 2;
            Title.Text = "Blood Bank Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 600);
            panel1.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 3;
            label1.Text = "Employees";
            // 
            // EmpUName
            // 
            EmpUName.Location = new Point(430, 409);
            EmpUName.Name = "EmpUName";
            EmpUName.Size = new Size(183, 23);
            EmpUName.TabIndex = 66;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Firebrick;
            label10.Location = new Point(289, 400);
            label10.Name = "label10";
            label10.Size = new Size(135, 32);
            label10.TabIndex = 65;
            label10.Text = "Username:";
            // 
            // EmpPass
            // 
            EmpPass.Location = new Point(852, 409);
            EmpPass.Name = "EmpPass";
            EmpPass.Size = new Size(183, 23);
            EmpPass.TabIndex = 68;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Cursor = Cursors.Hand;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Firebrick;
            label11.Location = new Point(717, 400);
            label11.Name = "label11";
            label11.Size = new Size(129, 32);
            label11.TabIndex = 67;
            label11.Text = "Password:";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(603, 490);
            button2.Name = "button2";
            button2.Size = new Size(140, 42);
            button2.TabIndex = 70;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(840, 490);
            button1.Name = "button1";
            button1.Size = new Size(140, 42);
            button1.TabIndex = 69;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(357, 490);
            button3.Name = "button3";
            button3.Size = new Size(140, 42);
            button3.TabIndex = 71;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 600);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(EmpPass);
            Controls.Add(label11);
            Controls.Add(EmpUName);
            Controls.Add(label10);
            Controls.Add(EmpList);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "v";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView EmpList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label9;
        private Panel panel2;
        private Label label8;
        private Label Title;
        private Panel panel1;
        private Label label1;
        private TextBox EmpUName;
        private Label label10;
        private TextBox EmpPass;
        private Label label11;
        private Button button2;
        private Button button1;
        private Button button3;
        private ColumnHeader columnHeader3;
    }
}