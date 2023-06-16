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
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection("Server=tcp:final12.database.windows.net,1433;Initial Catalog=bloodbank;Persist Security Info=False;User ID=CloudSA03fb3ce3;Password=[your_password];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private void button1_Click(object sender, EventArgs e)
        {
            if (DName.Text == "" || DAge.Text == "" || DPhone.Text == "" || DCity.SelectedIndex == -1 || DAdress.Text == "" || DGender.SelectedIndex == -1 || DBGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all information");
            }
            else
            {
                try
                {
                    int stock = 1;
                    string query = "insert into Donor values('" + DName.Text + "','" + DAge.Text + "','" + DGender.SelectedItem.ToString() + "','" + DPhone.Text + "','" + DCity.SelectedItem.ToString() + "','" + DAdress.Text + "','" + DBGroup.SelectedItem.ToString() + "')";
                    string Bloodquery = "Update Blood set BStock+='" + stock + "'where BGroup='" + DBGroup.SelectedItem.ToString() + "';";
                    sql.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sql);
                    SqlCommand sqlCommand2 = new SqlCommand(Bloodquery, sql);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand2.ExecuteNonQuery();
                    MessageBox.Show("Saved Succesfully");
                    Reset();
                    sql.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Reset()
        {
            DName.Text = string.Empty;
            DAge.Text = string.Empty;
            DCity.SelectedIndex = -1;
            DBGroup.SelectedIndex = -1;
            DPhone.Text = string.Empty;
            DAdress.Text = string.Empty;
            DGender.SelectedIndex = -1;
        }

        private void Donor_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ViewDonor viewDonor = new ViewDonor();
            viewDonor.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            BloodStock BloodStock = new BloodStock();
            BloodStock.Show();
            this.Hide();
        }

        private void Donor_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewPatient BloodStock = new ViewPatient();
            BloodStock.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Blood_Transfer BloodStock = new Blood_Transfer();
            BloodStock.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Summary BloodStock = new Summary();
            BloodStock.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
