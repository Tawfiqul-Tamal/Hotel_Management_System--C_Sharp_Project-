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

namespace HotelManagement
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Error: Full Name is required");
                return;
            }
            string contact = txtContact.Text;
            if (string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("Error: Contact is required");
                return;
            }
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Error: Gender is required");
                return;
            }
            DateTime dob = dtpDob.Value;

            string email = txtEmail.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Error: Email is required");
                return;
            }
            string password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Error: Password is required");
                return;
            }
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"insert into UserInfo values ('Client','{fullName}' ,'{contact}', '{gender}', '{dob}', '{email}', '{password}')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration Done");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Show();
        }
    }
}
