using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BloodManagementSystem
{
    public partial class ViewDonor : Form
    {
        public ViewDonor()
        {
            InitializeComponent();
            fillTable();
        }
        SqlConnection sql = new SqlConnection("Server=tcp:final12.database.windows.net,1433;Initial Catalog=bloodbank;Persist Security Info=False;User ID=CloudSA03fb3ce3;Password=[your_password];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private void fillTable()
        {
            sql.Open();
            string query = "select * from Donor";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataTable();
            adapter.Fill(data);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Dnum"].ToString());
                listitem.SubItems.Add(dr["DName"].ToString());
                listitem.SubItems.Add(dr["DAge"].ToString());
                listitem.SubItems.Add(dr["DGender"].ToString());
                listitem.SubItems.Add(dr["DPhone"].ToString());
                listitem.SubItems.Add(dr["DTown"].ToString());
                listitem.SubItems.Add(dr["DAdress"].ToString());
                listitem.SubItems.Add(dr["DBGroup"].ToString());
                DonorList.Items.Add(listitem);
            }
            sql.Close();
        }
        private void ViewDonor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Donor viewPatient = new Donor();
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

        private void label6_Click(object sender, EventArgs e)
        {
            Summary viewPatient = new Summary();
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
