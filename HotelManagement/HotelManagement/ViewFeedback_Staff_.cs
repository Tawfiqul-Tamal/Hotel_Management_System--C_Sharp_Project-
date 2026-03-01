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
    public partial class ViewFeedback_Staff_ : Form
    {
        public ViewFeedback_Staff_()
        {
            InitializeComponent();
        }

        private void ViewFeedback_Staff__Load(object sender, EventArgs e)
        {
            string conPath = ApplicationHelper.ConnectionPath;
            var con = new SqlConnection();
            con.ConnectionString = conPath;
            con.Open();

            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"select * from Feedback ";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            dgvUI.DataSource = dt;
            dgvUI.Refresh();
            dgvUI.ClearSelection();

            con.Close();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if
              (this.Owner != null)
                this.Owner.Show();
            this.Hide();
        }

        private void ViewFeedback_Staff__FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
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
    }
}
