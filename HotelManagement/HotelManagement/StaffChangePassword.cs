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
    public partial class StaffChangePassword : Form
    {
        public StaffChangePassword()
        {
            InitializeComponent();
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            
            if
                (this.Owner != null)
                this.Owner.Show();
            this.Hide();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string currentPass = txtCurrPass.Text;
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

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ActiveCaption;
        }

        private void btnChangePass_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnChangePass_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ActiveCaption;
        }

        private void StaffChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
