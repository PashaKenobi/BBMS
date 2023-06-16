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

namespace BloodManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection("Server=tcp:final12.database.windows.net,1433;Initial Catalog=bloodbank;Persist Security Info=False;User ID=CloudSA03fb3ce3;Password=[your_password];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select count(*) from Employee where EmpUName='" + LoginUName.Text + "'and EmpPass= '" + LoginPassword.Text + "';";
            sql.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            sql.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
