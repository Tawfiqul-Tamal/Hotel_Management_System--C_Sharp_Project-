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
    public partial class ClientPaymentForm : Form
    {
        public ClientPaymentForm()
        {
            InitializeComponent();
        }

        private void btnNewPayment_Click(object sender, EventArgs e)
        {
            ClientPaymentSubmissionForm clientPaymentSubmissionForm = new ClientPaymentSubmissionForm();
            clientPaymentSubmissionForm.Show();
        }

        private void LoadData()
        {
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select p.* FROM Payment p JOIN RoomBooking b ON p.booking_id = b.booking_id\r\nWHERE b.user_id = '{ApplicationHelper.userID}'; ";

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                dgvData.DataSource = dt;
                dgvData.Refresh();
                dgvData.ClearSelection();

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ClientPaymentForm_Load(object sender, EventArgs e)
        {
            LoadData();
           
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void ClientPaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.Owner != null)
                { this.Owner.Show(); }
        }
    }
}
