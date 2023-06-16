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
    public partial class BloodStock : Form
    {
        public BloodStock()
        {
            InitializeComponent();
            fillTable();
        }
        SqlConnection sql = new SqlConnection("Server=tcp:final12.database.windows.net,1433;Initial Catalog=bloodbank;Persist Security Info=False;User ID=CloudSA03fb3ce3;Password=[your_password];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        private void fillTable()
        {
            sql.Open();
            string query = "select * from Blood";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataTable();
            adapter.Fill(data);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["BGroup"].ToString());
                listitem.SubItems.Add(dr["BStock"].ToString());
                listView1.Items.Add(listitem);
            }
            sql.Close();
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

        private void label7_Click(object sender, EventArgs e)
        {
            Blood_Transfer donor = new Blood_Transfer();
            donor.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Summary donor = new Summary();
            donor.Show();
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
