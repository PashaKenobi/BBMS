namespace BloodManagementSystem
{
    partial class First
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First));
            Title = new Label();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.Firebrick;
            Title.Location = new Point(108, 53);
            Title.Name = "Title";
            Title.Size = new Size(389, 32);
            Title.TabIndex = 0;
            Title.Text = "Blood Bank Management System";
            Title.Click += Title_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(148, 135);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(317, 23);
            progressBar1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(206, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // First
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(631, 343);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "First";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            Load += First_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}