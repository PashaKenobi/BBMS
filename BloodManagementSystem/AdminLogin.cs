using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BloodManagementSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdLoginUName.Text.Equals("") || AdLoginPassword.Text.Equals(""))
            {
                MessageBox.Show("Please Enter both Username and Password");
            }
            else if (AdLoginUName.Text.Equals("Admin") && AdLoginPassword.Text.Equals("12345"))
            {
                Employee employee = new Employee();
                employee.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong");
                AdLoginUName.Text = "";
                AdLoginPassword.Text = "";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
