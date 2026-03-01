using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HotelManagement
{
    public partial class ManageStaffAdminForm : Form
    {
        public ManageStaffAdminForm()
        {
            InitializeComponent();
        }

        private void ManageStaffAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageStaffAdmin_Load(object sender, EventArgs e)
        {
            this.LoadUserData();
        }
        private void LoadUserData()
        {
            string conPath = ApplicationHelper.ConnectionPath;
            var con = new SqlConnection();
            con.ConnectionString = conPath;
            con.Open();

            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"Select * from UserInfo where User_Type='Admin' ";
            cmd.ExecuteNonQuery();



            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            dgvUI.DataSource = dt;
            dgvUI.Refresh();
            dgvUI.ClearSelection();

            con.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadUserData();
            this.NewUserData();
            
        }

        private void dgvUI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            txtID.Text = dgvUI.Rows[e.RowIndex].Cells[0].Value.ToString();

            string userType = dgvUI.Rows[e.RowIndex].Cells[1].Value.ToString();
            if(userType =="Admin")
                rbAdmin.Checked = true;
            else if(userType == "Staff")
                rbStaff.Checked = true;

            txtName.Text = dgvUI.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtContact.Text = dgvUI.Rows[e.RowIndex].Cells[3].Value.ToString();

            string gender = dgvUI.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (gender == "Male")
                rbMale.Checked = true;
            else if (gender == "Female")
                rbFemale.Checked = true;

            dtpDOB.Text = dgvUI.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dgvUI.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPass.Text= dgvUI.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void NewUserData()
        {
            txtID.Text = "Auto Generated";
            txtName.Text = "";
            txtContact.Text = "";
            dtpDOB.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            rbAdmin.Checked = false;
            rbStaff.Checked = false;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dgvUI.ClearSelection();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewUserData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (id == "Auto Generated" || id=="")
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

                con.Close();

                MessageBox.Show($"User {id} Deleted Successfully");
                this.LoadUserData();
                this.NewUserData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                string userType = "";
                string gender = "";
                string pass = txtPass.Text;
                string query = "";
                if (rbAdmin.Checked == true)
                {
                    userType = rbAdmin.Text;
                }
                else if (rbStaff.Checked == true)
                {
                    userType = rbStaff.Text;
                }
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
                    query = $"INSERT INTO UserInfo values ('{userType}','{name}','{contact}','{gender}','{dob}','{email}','{pass}')";
                    confirmText = "User Inserted Succesfully";
                }
                else
                {
                    query = $"UPDATE UserInfo set User_Type = '{userType}',Name = '{name}',Contact = '{contact}',Gender = '{gender}',Date_Of_Birth = '{dob}',Email = '{email}',Password = '{pass}' WHERE User_ID = '{ id }'";
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
