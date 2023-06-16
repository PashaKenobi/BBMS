using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            Patients donor = new Patients();
            donor.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Summary donor = new Summary();
            donor.Show();
            this.Hide();
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

        private void label7_Click(object sender, EventArgs e)
        {
            Blood_Transfer donor = new Blood_Transfer();
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
