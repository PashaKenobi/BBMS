namespace BloodManagementSystem
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
        int startPos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPos += 2;
            progressBar1.Value = startPos;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void First_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}