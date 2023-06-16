using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BloodManagementSystem
{
    public partial class ViewPatient : Form
    {
        public ViewPatient()
        {
            InitializeComponent();
            fillTable();
        }

        SqlConnection sql = new SqlConnection("Server=tcp:final12.database.windows.net,1433;Initial Catalog=bloodbank;Persist Security Info=False;User ID=CloudSA03fb3ce3;Password=[your_password];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        int key = 0;
        ViewPatient view;
        private void fillTable()
        {
            sql.Open();
            string query = "select * from patient";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataTable();
            adapter.Fill(data);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Pnum"].ToString());
                listitem.SubItems.Add(dr["PName"].ToString());
                listitem.SubItems.Add(dr["PAge"].ToString());
                listitem.SubItems.Add(dr["PGender"].ToString());
                listitem.SubItems.Add(dr["PPhone"].ToString());
                listitem.SubItems.Add(dr["PTown"].ToString());
                listitem.SubItems.Add(dr["PAdress"].ToString());
                listitem.SubItems.Add(dr["PBGroup"].ToString());
                PatientList.Items.Add(listitem);
            }
            sql.Close();
        }

        private void ViewPatient_Load(object sender, EventArgs e)
        {

        }

        private void PatientList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            foreach (ListViewItem item in PatientList.Items)
            {
                if (item.Selected)
                {
                    PNameList.Text = PatientList.Items[item.Index].SubItems[1].Text;
                    PAgeList.Text = PatientList.Items[item.Index].SubItems[2].Text;
                    PGenderList.Text = PatientList.Items[item.Index].SubItems[3].Text;
                    PPhoneList.Text = PatientList.Items[item.Index].SubItems[4].Text;
                    PCityList.Text = PatientList.Items[item.Index].SubItems[5].Text;
                    PAdressList.Text = PatientList.Items[item.Index].SubItems[6].Text;
                    PBGroupList.Text = PatientList.Items[item.Index].SubItems[7].Text;
                }
            }
            sql.Open();
            string query = "Select * from Image where PName='" + PNameList.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, sql);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                byte[] images = ((byte[])reader[1]);
                MemoryStream stream = new MemoryStream(images);
                pictureBox1.Image = Image.FromStream(stream);
            }
            else
            {
                pictureBox1.Image = null;
            }
            sql.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PNameList.Text.Equals(""))
            {
                MessageBox.Show("Please Select patient");
                key = 0;
            }
            else
            {
                foreach (ListViewItem item in PatientList.Items)
                {
                    if (item.Selected)
                    {
                        key = Convert.ToInt32(PatientList.Items[item.Index].SubItems[0].Text.ToString());
                    }
                }
                try
                {
                    string query = "Delete From patient where Pnum = " + key + ";";
                    sql.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sql);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Deleted Succesfully");
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
            PNameList.Text = string.Empty;
            PAgeList.Text = string.Empty;
            PCityList.SelectedIndex = -1;
            PBGroupList.SelectedIndex = -1;
            PPhoneList.Text = string.Empty;
            PAdressList.Text = string.Empty;
            PGenderList.SelectedIndex = -1;
            pictureBox1.Image = null;
        }

        private void View_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (PNameList.Text == "" || PAgeList.Text == "" || PPhoneList.Text == "" || PGenderList.SelectedIndex == -1 || PAdressList.Text == "" || PCityList.SelectedIndex == -1 || PBGroupList.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select patient");
                key = 0;
            }
            else
            {
                foreach (ListViewItem item in PatientList.Items)
                {
                    if (item.Selected)
                    {
                        key = Convert.ToInt32(PatientList.Items[item.Index].SubItems[0].Text.ToString());
                    }
                }
                try
                {
                    string query = "Update patient set Pname= '" + PNameList.Text + "',PAge='" + PAgeList.Text + "',PGender='" + PGenderList.SelectedItem.ToString() + "',PPhone='" + PPhoneList.Text + "',PTown='" + PCityList.SelectedItem.ToString() + "',PAdress='" + PAdressList.Text + "',PBGroup='" + PBGroupList.SelectedItem.ToString() + "' where Pnum = " + key + ";";
                    sql.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sql);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Edited Succesfully");
                    sql.Close();
                    Reset();
                    fillTable();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
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
