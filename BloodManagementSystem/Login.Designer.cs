namespace BloodManagementSystem
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            LoginUName = new TextBox();
            LoginPassword = new TextBox();
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
            Title.Location = new Point(49, 35);
            Title.Name = "Title";
            Title.Size = new Size(389, 32);
            Title.TabIndex = 1;
            Title.Text = "Blood Bank Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(71, 159);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(71, 217);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // LoginUName
            // 
            LoginUName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginUName.Location = new Point(178, 159);
            LoginUName.Name = "LoginUName";
            LoginUName.Size = new Size(180, 29);
            LoginUName.TabIndex = 4;
            LoginUName.TextChanged += textBox1_TextChanged;
            // 
            // LoginPassword
            // 
            LoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginPassword.Location = new Point(178, 217);
            LoginPassword.Name = "LoginPassword";
            LoginPassword.PasswordChar = '*';
            LoginPassword.Size = new Size(180, 29);
            LoginPassword.TabIndex = 5;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(178, 298);
            button1.Name = "button1";
            button1.Size = new Size(140, 42);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(137, 396);
            label3.Name = "label3";
            label3.Size = new Size(236, 32);
            label3.TabIndex = 7;
            label3.Text = "Continue As Admin";
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
            label8.TabIndex = 11;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 447);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(LoginPassword);
            Controls.Add(LoginUName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private Label label2;
        private TextBox LoginUName;
        private TextBox LoginPassword;
        private Button button1;
        private Label label3;
        private Label label8;
    }
}