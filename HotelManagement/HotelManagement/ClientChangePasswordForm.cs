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
    public partial class ClientChangePasswordForm : Form
    {
        public ClientChangePasswordForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currentPass = txtCurrentPass.Text;
            string newPass = txtNewPass.Text;


            string conPath = ApplicationHelper.ConnectionPath;
            var con = new SqlConnection();
            con.ConnectionString = conPath;
            con.Open();

            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"Select * from UserInfo where User_ID='{ApplicationHelper.userID}' AND Password='{currentPass}'";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            if (dt.Rows.Count != 1)
            {
                MessageBox.Show("Failed! Please Enter The Correct Password!");
                return;
            }

            var cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandText = $"UPDATE UserInfo set Password = '{newPass}' where User_ID='{ApplicationHelper.userID}' ";
            cmd2.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Password Updated Successfully");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientChangePasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
