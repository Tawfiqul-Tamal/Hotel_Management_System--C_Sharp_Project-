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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email= txtEmail.Text;
            string pass=txtPass.Text;

            try
            {
                string conPath = ApplicationHelper.ConnectionPath;
                var con = new SqlConnection();
                con.ConnectionString = conPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"Select * from UserInfo where Email='{email}' AND Password='{pass}'";
                cmd.ExecuteNonQuery();



                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);


                if (dt.Rows.Count != 1)
                {
                    MessageBox.Show("Invalid Email or Password!");
                    return;
                }

                ApplicationHelper.name = dt.Rows[0]["Name"].ToString();
                ApplicationHelper.userType = dt.Rows[0]["User_Type"].ToString();
                ApplicationHelper.userID = dt.Rows[0]["User_ID"].ToString();
                MessageBox.Show($"Welcome, {ApplicationHelper.name}");

                if (ApplicationHelper.userType == "Admin")
                {
                    AdminHomeForm ahf = new AdminHomeForm();
                    ahf.Owner= this;
                    ahf.Show();
                    txtEmail.Clear();
                    txtPass.Clear();
                    this.Hide();
                }
                else if (ApplicationHelper.userType == "Staff")
                {
                    Staff_Dash_Board shf = new Staff_Dash_Board();
                    shf.Owner = this;
                    shf.Show();
                    txtEmail.Clear();
                    txtPass.Clear();
                    this.Hide();
                }
                else if (ApplicationHelper.userType == "Client")
                {
                    ClientHomeForm chf = new ClientHomeForm();
                    chf.Owner = this;
                    chf.Show();
                    txtEmail.Clear();
                    txtPass.Clear();
                    this.Hide();
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm fp=new ForgetPasswordForm();
            fp.Owner = this;
            fp.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
