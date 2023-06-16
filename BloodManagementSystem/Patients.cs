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
using System.Configuration;

namespace BloodManagementSystem
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }
        string filename = "";

        SqlConnection sql = new SqlConnection("Server=tcp:final12.database.windows.net,1433;Initial Catalog=bloodbank;Persist Security Info=False;User ID=CloudSA03fb3ce3;Password=[your_password];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private void Button_Click(object sender, EventArgs e)
        {
            if (PName.Text == "" || PAge.Text == "" || PPhone.Text == "" || PCity.SelectedIndex == -1 || PAdress.Text == "" || PGender.SelectedIndex == -1 || PBGroup.SelectedIndex == -1 || PEmail.Text == "")
            {
                MessageBox.Show("Please fill all information");
            }
            else
            {
                try
                {
                    string query = "insert into patient values('" + PName.Text + "','" + PAge.Text + "','" + PGender.SelectedItem.ToString() + "','" + PPhone.Text + "','" + PCity.SelectedItem.ToString() + "','" + PAdress.Text + "','" + PBGroup.SelectedItem.ToString() + "','" + PEmail.Text + "')";
                    sql.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sql);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Saved Succesfully");
                    sql.Close();
                    SaveImages();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Reset()
        {
            PName.Text = string.Empty;
            PAge.Text = string.Empty;
            PEmail.Text = string.Empty;
            PCity.SelectedIndex = -1;
            PBGroup.SelectedIndex = -1;
            PPhone.Text = string.Empty;
            PAdress.Text = string.Empty;
            PGender.SelectedIndex = -1;
            pictureBox1.Image = null;
        }
        private void Patients_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            this.Hide();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filename = openFile.FileName;
                pictureBox1.ImageLocation = filename;
            }

        }

        private void SaveImages()
        {
            byte[] images = null;
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            images = reader.ReadBytes((int)reader.BaseStream.Length);
            sql.Open();
            string query = "insert into Image values(@images,'" + PName.Text + "') ";
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int n = cmd.ExecuteNonQuery();
            sql.Close();
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
