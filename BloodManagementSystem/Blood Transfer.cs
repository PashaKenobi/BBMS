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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Collections;
using System.Net.Mail;
using System.Net;
using FluentEmail.Smtp;
using FluentEmail.Core;

namespace BloodManagementSystem
{
    public partial class Blood_Transfer : Form
    {
        public Blood_Transfer()
        {
            InitializeComponent();
            fillPatient();
        }
        string email;
        SqlConnection sql = new SqlConnection("Server=tcp:final12.database.windows.net,1433;Initial Catalog=bloodbank;Persist Security Info=False;User ID=CloudSA03fb3ce3;Password=[your_password];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        private void fillPatient()
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("select Pnum from patient", sql);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Pnum", typeof(string));
            dt.Load(reader);
            PatId.ValueMember = "Pnum";
            PatId.DataSource = dt;
            sql.Close();
        }
        private void patient()
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("select * from patient where Pnum= " + PatId.SelectedValue.ToString() + ";", sql);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatName.Text = dr["PName"].ToString();
                PatBGroup.Text = dr["PBGroup"].ToString();
            }

            sql.Close();
        }
        int stock;
        private void getStock(string Bgroup)
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("select * from Blood where BGroup= '" + Bgroup + "'", sql);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr["BStock"].ToString());
            }
            sql.Close();
        }

        private void Blood_Transfer_Load(object sender, EventArgs e)
        {

        }

        private void PatId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            patient();
            getStock(PatBGroup.Text);
            if (stock > 0)
            {
                Transfer.Visible = true;
                AvA.Text = "Blood Stock Available";
                AvA.Visible = true;
            }
            else
            {
                AvA.Text = "Out Of Stock";
                AvA.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ViewDonor donor = new ViewDonor();
            donor.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patients donor = new Patients();
            donor.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewPatient donor = new ViewPatient();
            donor.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            BloodStock donor = new BloodStock();
            donor.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Summary donor = new Summary();
            donor.Show();
            this.Hide();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            if (PatName.Text == "")
            {
                MessageBox.Show("Please fill all information");
            }
            else
            {
                try
                {
                    string query = "insert into Transfer values('" + PatName.Text + "','" + PatBGroup.Text + "')";
                    sql.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sql);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Transfer Succesfull");
                    Stock();
                    Reset();
                    sql.Close();
                    se();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Reset()
        {
            PatName.Text = "";
            PatBGroup.Text = "";
            AvA.Visible = false;
            Transfer.Visible = false;
        }
        private void Stock()
        {
            int stock = 1;
            string Bloodquery = "Update Blood set BStock-='" + stock + "'where BGroup='" + PatBGroup.Text + "';";
            SqlCommand sqlCommand2 = new SqlCommand(Bloodquery, sql);
            sqlCommand2.ExecuteNonQuery();
        }
        private async void se()
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("select * from Patient where Pnum= '" + PatId.SelectedValue.ToString() + "'", sql);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                email = dr["PEmail"].ToString();
            }
            var sender = new SmtpSender(() => new SmtpClient("localhost")
            {
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory,
                PickupDirectoryLocation = "C:\\"
            });
            StringBuilder template = new();
            template.AppendLine("Hello Sir/Madam");
            template.AppendLine("<p>Your blood request has been found.</p>");
            template.AppendLine("-Blood Management System");

            Email.DefaultSender = sender;
            var def = await Email
                .From("test@test.com")
                .To(email)
                .Subject("Blood Request")
                .UsingTemplate(template.ToString(), new { FirstName = PatName.Text.ToString() })
                .SendAsync();
            string query2 = "delete from patient where Pnum= " + PatId.SelectedValue.ToString() + ";";
            SqlCommand sqlCommand2 = new SqlCommand(query2, sql);
            sqlCommand2.ExecuteNonQuery();
            sql.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
