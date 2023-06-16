﻿namespace BloodManagementSystem
{
    partial class AdminLogin
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
            Title = new Label();
            AdLoginPassword = new TextBox();
            AdLoginUName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.Firebrick;
            Title.Location = new Point(52, 34);
            Title.Name = "Title";
            Title.Size = new Size(389, 32);
            Title.TabIndex = 2;
            Title.Text = "Blood Bank Management System";
            // 
            // AdLoginPassword
            // 
            AdLoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AdLoginPassword.Location = new Point(191, 216);
            AdLoginPassword.Name = "AdLoginPassword";
            AdLoginPassword.PasswordChar = '*';
            AdLoginPassword.Size = new Size(180, 29);
            AdLoginPassword.TabIndex = 9;
            // 
            // AdLoginUName
            // 
            AdLoginUName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AdLoginUName.Location = new Point(191, 158);
            AdLoginUName.Name = "AdLoginUName";
            AdLoginUName.Size = new Size(180, 29);
            AdLoginUName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(84, 216);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(84, 158);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 6;
            label1.Text = "Username:";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(174, 309);
            button1.Name = "button1";
            button1.Size = new Size(140, 42);
            button1.TabIndex = 10;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(174, 386);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 11;
            label3.Text = "Return Back";
            label3.Click += label3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(452, 9);
            label8.Name = "label8";
            label8.Size = new Size(30, 32);
            label8.TabIndex = 12;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 447);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(AdLoginPassword);
            Controls.Add(AdLoginUName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox AdLoginPassword;
        private TextBox AdLoginUName;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
        private Label label8;
    }
}