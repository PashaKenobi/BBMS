namespace BloodManagementSystem
{
    partial class BloodStock
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
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
            panel1.TabIndex = 4;
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
            label7.Click += label7_Click;
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
            panel2.TabIndex = 6;
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
            label9.Location = new Point(601, 60);
            label9.Name = "label9";
            label9.Size = new Size(170, 37);
            label9.TabIndex = 22;
            label9.Text = "Blood Stock";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.Location = new Point(559, 124);
            listView1.Name = "listView1";
            listView1.Size = new Size(244, 282);
            listView1.TabIndex = 60;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Blood Group";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Stock";
            columnHeader2.Width = 80;
            // 
            // BloodStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 600);
            Controls.Add(listView1);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BloodStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BloodStock";
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
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}