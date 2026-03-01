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
    public partial class AdminViewCheckInCheckOut : Form
    {
        public AdminViewCheckInCheckOut()
        {
            InitializeComponent();
        }

        private void AdminViewCheckInCheckOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null) {
                this.Owner.Show();
           
            }
        }

        private void AdminViewCheckInCheckOut_Load(object sender, EventArgs e)
        {
            this.LoadCheckInOutData();
        }
        private void LoadCheckInOutData()
        {
            string conPath = ApplicationHelper.ConnectionPath;
            var con = new SqlConnection();
            con.ConnectionString = conPath;
            con.Open();

            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"select * from  Check_In_Out";
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
    }
}
