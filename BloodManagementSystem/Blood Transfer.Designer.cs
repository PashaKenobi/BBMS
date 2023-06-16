namespace BloodManagementSystem
{
    partial class Blood_Transfer
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
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            Title = new Label();
            label9 = new Label();
            PatId = new ComboBox();
            label12 = new Label();
            PatName = new TextBox();
            label10 = new Label();
            PatBGroup = new ComboBox();
            label16 = new Label();
            AvA = new Label();
            Transfer = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 600);
            panel1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(3, 458);
            label7.Name = "label7";
            label7.Size = new Size(181, 32);
            label7.TabIndex = 9;
            label7.Text = "Blood Transfer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(3, 534);
            label6.Name = "label6";
            label6.Size = new Size(123, 32);
            label6.TabIndex = 8;
            label6.Text = "Summary";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(3, 374);
            label5.Name = "label5";
            label5.Size = new Size(149, 32);
            label5.TabIndex = 7;
            label5.Text = "Blood Stock";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(3, 297);
            label3.Name = "label3";
            label3.Size = new Size(158, 32);
            label3.TabIndex = 6;
            label3.Text = "View Patiens";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(3, 220);
            label4.Name = "label4";
            label4.Size = new Size(105, 32);
            label4.TabIndex = 5;
            label4.Text = "Patients";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(3, 138);
            label2.Name = "label2";
            label2.Size = new Size(160, 32);
            label2.TabIndex = 4;
            label2.Text = "View Donors";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(3, 60);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 3;
            label1.Text = "Donor";
            label1.Click += label1_Click;
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
            panel2.TabIndex = 7;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(580, 83);
            label9.Name = "label9";
            label9.Size = new Size(204, 37);
            label9.TabIndex = 61;
            label9.Text = "Blood Transfer";
            // 
            // PatId
            // 
            PatId.FormattingEnabled = true;
            PatId.Location = new Point(336, 167);
            PatId.Name = "PatId";
            PatId.Size = new Size(153, 23);
            PatId.TabIndex = 64;
            PatId.SelectionChangeCommitted += PatId_SelectionChangeCommitted;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Firebrick;
            label12.Location = new Point(209, 158);
            label12.Name = "label12";
            label12.Size = new Size(131, 32);
            label12.TabIndex = 63;
            label12.Text = "Patient Id:";
            // 
            // PatName
            // 
            PatName.Location = new Point(702, 167);
            PatName.Name = "PatName";
            PatName.Size = new Size(183, 23);
            PatName.TabIndex = 66;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Firebrick;
            label10.Location = new Point(521, 158);
            label10.Name = "label10";
            label10.Size = new Size(175, 32);
            label10.TabIndex = 65;
            label10.Text = "Patient Name:";
            // 
            // PatBGroup
            // 
            PatBGroup.FormattingEnabled = true;
            PatBGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            PatBGroup.Location = new Point(1064, 167);
            PatBGroup.Name = "PatBGroup";
            PatBGroup.Size = new Size(153, 23);
            PatBGroup.TabIndex = 68;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Cursor = Cursors.Hand;
            label16.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Firebrick;
            label16.Location = new Point(891, 158);
            label16.Name = "label16";
            label16.Size = new Size(167, 32);
            label16.TabIndex = 67;
            label16.Text = "Blood Group:";
            // 
            // AvA
            // 
            AvA.AutoSize = true;
            AvA.Cursor = Cursors.Hand;
            AvA.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            AvA.ForeColor = Color.Firebrick;
            AvA.Location = new Point(604, 262);
            AvA.Name = "AvA";
            AvA.Size = new Size(121, 32);
            AvA.TabIndex = 69;
            AvA.Text = "Available";
            AvA.Visible = false;
            // 
            // Transfer
            // 
            Transfer.AutoSize = true;
            Transfer.BackColor = Color.White;
            Transfer.Cursor = Cursors.Hand;
            Transfer.FlatStyle = FlatStyle.Flat;
            Transfer.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Transfer.ForeColor = SystemColors.ControlText;
            Transfer.Location = new Point(595, 364);
            Transfer.Name = "Transfer";
            Transfer.Size = new Size(140, 42);
            Transfer.TabIndex = 70;
            Transfer.Text = "Transfer";
            Transfer.UseVisualStyleBackColor = false;
            Transfer.Visible = false;
            Transfer.Click += Transfer_Click;
            // 
            // Blood_Transfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 600);
            Controls.Add(Transfer);
            Controls.Add(AvA);
            Controls.Add(PatBGroup);
            Controls.Add(label16);
            Controls.Add(PatName);
            Controls.Add(label10);
            Controls.Add(PatId);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Blood_Transfer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blood_Transfer";
            Load += Blood_Transfer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label8;
        private Label Title;
        private Label label9;
        private ComboBox PatId;
        private Label label12;
        private TextBox PatName;
        private Label label10;
        private ComboBox PatBGroup;
        private Label label16;
        private Label AvA;
        private Button Transfer;
    }
}