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
    public partial class ManageClientForm : Form
    {
        public ManageClientForm()
        {
            InitializeComponent();
        }
        private void LoadUserData()
        {
            string conPath = ApplicationHelper.ConnectionPath;
            var con = new SqlConnection();
            con.ConnectionString = conPath;
            con.Open();

            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"Select * from UserInfo where User_Type='Client' ";
            cmd.ExecuteNonQuery();



            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            dgvUI.DataSource = dt;
            dgvUI.Refresh();
            dgvUI.ClearSelection();

            con.Close();
        }
        private void NewUserData()
        {
            txtID.Text = "Auto Generated";
            txtName.Text = "";
            txtContact.Text = "";
            dtpDOB.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            rbMale.Checked = false;
            rbMale.Checked = false;
            dgvUI.ClearSelection();
        }
        private void ManageGuest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void dgvUI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageClientForm_Load(object sender, EventArgs e)
        {
            this.LoadUserData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewUserData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadUserData();
            this.NewUserData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string name = txtName.Text;
                string contact = txtContact.Text;
                DateTime dob = dtpDOB.Value;
                string email = txtEmail.Text;
                string gender = "";
                string pass = txtPass.Text;
                string query = "";
                if (rbMale.Checked == true)
                {
                    gender = rbMale.Text;
                }
                else if (rbFemale.Checked == true)
                {
                    gender = rbFemale.Text;
                }

                string confirmText = "";
                if (id == "Auto Generated")
                {
                    query = $"INSERT INTO UserInfo values ('Client','{name}','{contact}','{gender}','{dob}','{email}','{pass}')";
                    confirmText = "User Inserted Succesfully";
                }
                else
                {
                    query = $"UPDATE UserInfo set User_Type = 'Client',Name = '{name}',Contact = '{contact}',Gender = '{gender}',Date_Of_Birth = '{dob}',Email = '{email}',Password = '{pass}' WHERE User_ID = '{id}'";
                    confirmText = $"User {id} Updated Successfully";
                }
                string conPath = ApplicationHelper.ConnectionPath;
                var con = new SqlConnection();
                con.ConnectionString = conPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                MessageBox.Show(confirmText);
                this.LoadUserData();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (id == "Auto Generated" || id == "")
            {
                MessageBox.Show("Please Select a Specific User First!");
                return;
            }

            var result = MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            try
            {
                string conPath = ApplicationHelper.ConnectionPath;
                var con = new SqlConnection();
                con.ConnectionString = conPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"delete from UserInfo where User_ID={id} ";
                cmd.ExecuteNonQuery();

                MessageBox.Show($"User {id} Deleted Successfully");
                this.LoadUserData();
                this.NewUserData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            txtID.Text = dgvUI.Rows[e.RowIndex].Cells[0].Value.ToString();

            string userType = dgvUI.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtName.Text = dgvUI.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtContact.Text = dgvUI.Rows[e.RowIndex].Cells[3].Value.ToString();

            string gender = dgvUI.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (gender == "Male")
                rbMale.Checked = true;
            else if (gender == "Female")
                rbFemale.Checked = true;

            dtpDOB.Text = dgvUI.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dgvUI.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPass.Text = dgvUI.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
