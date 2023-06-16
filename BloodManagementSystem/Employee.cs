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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;

namespace BloodManagementSystem
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            fillTable();
        }
        int key = 0;
        SqlConnection sql = new SqlConnection("Server=tcp:final12.database.windows.net,1433;Initial Catalog=bloodbank;Persist Security Info=False;User ID=CloudSA03fb3ce3;Password=[your_password];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private void button3_Click(object sender, EventArgs e)
        {

            if (EmpUName.Text == "" || EmpPass.Text == "")
            {
                MessageBox.Show("Please fill all information");
            }
            else
            {
                try
                {
                    string query = "insert into Employee values('" + EmpUName.Text + "','" + EmpPass.Text + "')";
                    sql.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sql);
                    sqlCommand.ExecuteNonQuery();
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
        private void fillTable()
        {
            sql.Open();
            string query = "select * from Employee";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var data = new DataTable();
            adapter.Fill(data);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["EmpId"].ToString());
                listitem.SubItems.Add(dr["EmpUName"].ToString());
                listitem.SubItems.Add(dr["EmpPass"].ToString());
                EmpList.Items.Add(listitem);
            }
            sql.Close();
        }
        private void Reset()
        {
            EmpUName.Text = string.Empty;
            EmpPass.Text = string.Empty;
            key = 0;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void EmpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in EmpList.Items)
            {
                if (item.Selected)
                {
                    EmpUName.Text = EmpList.Items[item.Index].SubItems[1].Text;
                    EmpPass.Text = EmpList.Items[item.Index].SubItems[2].Text;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpUName.Text == "" || EmpPass.Text == "")
            {
                MessageBox.Show("Please Select employee");
                key = 0;
            }
            else
            {
                foreach (ListViewItem item in EmpList.Items)
                {
                    if (item.Selected)
                    {
                        key = Convert.ToInt32(EmpList.Items[item.Index].SubItems[0].Text.ToString());
                    }
                }
                try
                {
                    string query = "Update Employee set EmpUName= '" + EmpUName.Text + "',EmpPass='" + EmpPass.Text + "'where EmpId = " + key + ";";
                    sql.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sql);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Edited Succesfully");
                    sql.Close();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpUName.Text.Equals(""))
            {
                MessageBox.Show("Please Select employee");
                key = 0;
            }
            else
            {
                foreach (ListViewItem item in EmpList.Items)
                {
                    if (item.Selected)
                    {
                        key = Convert.ToInt32(EmpList.Items[item.Index].SubItems[0].Text.ToString());
                    }
                }
                try
                {
                    string query = "Delete From Employee where EmpId = " + key + ";";
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
    }
}
