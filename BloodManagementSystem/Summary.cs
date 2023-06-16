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
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
            getData();
        }
        SqlConnection sql = new SqlConnection("Server=tcp:final12.database.windows.net,1433;Initial Catalog=bloodbank;Persist Security Info=False;User ID=CloudSA03fb3ce3;Password=[your_password];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        private void getData()
        {
            sql.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select count(*) from Donor", sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            SqlDataAdapter adapter1 = new SqlDataAdapter("Select count(*) from Transfer", sql);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            SqlDataAdapter adapter2 = new SqlDataAdapter("Select count(*) from Employee", sql);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            SqlDataAdapter adapter3 = new SqlDataAdapter("Select count(*) from Patient", sql);
            DataTable dt3 = new DataTable();
            adapter3.Fill(dt3);
            SqlDataAdapter adapter4 = new SqlDataAdapter("Select Sum(BStock) from Blood", sql);
            DataTable dt4 = new DataTable();
            adapter4.Fill(dt4);
            int blood = Convert.ToInt32(dt4.Rows[0][0].ToString());
            DonorNum.Text = dt.Rows[0][0].ToString();
            TranferNum.Text = dt1.Rows[0][0].ToString();
            UserNum.Text = dt2.Rows[0][0].ToString();
            PatientNum.Text = dt3.Rows[0][0].ToString();
            TotalBlood.Text = "" + blood;
            sql.Close();
        }
        private void Summary_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Donor viewPatient = new Donor();
            viewPatient.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ViewDonor viewPatient = new ViewDonor();
            viewPatient.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patients viewPatient = new Patients();
            viewPatient.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            BloodStock viewPatient = new BloodStock();
            viewPatient.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Blood_Transfer viewPatient = new Blood_Transfer();
            viewPatient.Show();
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
