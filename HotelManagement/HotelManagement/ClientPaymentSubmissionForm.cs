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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HotelManagement
{
    public partial class ClientPaymentSubmissionForm : Form
    {
        public ClientPaymentSubmissionForm()
        {
            InitializeComponent();
        }



        private void btnPay_Click(object sender, EventArgs e)
        {
            DateTime paymentDate = dtpPaymentDate.Value;
           string bookingId = cmbBookingId.Text;
            string type = "";
            if (rbCash.Checked)
            {
                type = "Cash";
            }
            else if (rbCard.Checked)
            {
                type = "Card";
            }
            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Error: Type is required");
                return;
            }
            string amount = txtAmount.Text;
            if (string.IsNullOrWhiteSpace(amount))
            {
                MessageBox.Show("Error: Amount is required");
                return;
            }
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"insert into Payment values ('{paymentDate}' , '{bookingId}','{type}', '{amount}','')";

                cmd.ExecuteNonQuery();
                
                con.Close();
                MessageBox.Show("Paid Successfully");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbBookingId_Click(object sender, EventArgs e)
        {

        }

        private void ClientPaymentSubmissionForm_Load(object sender, EventArgs e)
        {
            LoadPaymentForm();
        }

        private void LoadPaymentForm()
        {
            try
            {
                string conPah = ApplicationHelper.ConnectionPath;
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * From RoomBooking where USER_ID='{ApplicationHelper.userID}'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                cmbBookingId.DataSource = dt;
                cmbBookingId.DisplayMember = "Booking_ID";
                cmbBookingId.ValueMember = "Booking_ID";
                
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
