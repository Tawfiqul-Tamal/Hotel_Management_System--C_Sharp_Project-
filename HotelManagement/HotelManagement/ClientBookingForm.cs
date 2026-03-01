using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagement
{
    public partial class ClientBookingForm : Form
    {
        public ClientBookingForm()
        {
            InitializeComponent();
        }



        private void btnCustomerLogOut_Click(object sender, EventArgs e)
        {

        }

        private void ClientHomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {ApplicationHelper.name} [{ApplicationHelper.userType}]";
            this.LoadClientHomeForm();
            NewData();

        }
        private void LoadClientHomeForm()
        {
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select Booking_ID,Booking_Date, Room_ID, EB_ID, Check_In, Check_Out, Status, Bill FROM RoomBooking WHERE User_ID = {ApplicationHelper.userID} ; select * from RoomPrice; select * from ExtraBed; select * from RoomCategory;select * from RoomSize";
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                cmd.ExecuteNonQuery();

                dgvData.DataSource = ds.Tables[0];
                dgvData.Refresh();
                dgvData.ClearSelection();

                cmbRoomId.DataSource = ds.Tables[1];
                cmbRoomId.DisplayMember = "Room_ID";

                cmbExtraBedId.DataSource = ds.Tables[2];
                cmbExtraBedId.DisplayMember = "EB_ID";

                //cmbRoomCategory.DataSource = ds.Tables[3];
                //cmbRoomCategory.DisplayMember = "Title";

                //cmbRoomSize.DataSource = ds.Tables[4];
                //cmbRoomSize.DisplayMember = "Capacity";



                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoadBill()
        {
            try
            {
                if (cmbRoomId.SelectedItem == null || cmbExtraBedId.SelectedItem == null)
                {
                    return;
                }

                string roomId = cmbRoomId.Text;
                string ebId = cmbExtraBedId.Text;


                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

                var cmd3 = new SqlCommand();
                cmd3.Connection = con;
                cmd3.CommandText = $"SELECT r.Price + e.Price AS Bill FROM RoomPrice r LEFT JOIN ExtraBed e ON e.EB_ID = '{ebId}' WHERE r.Room_ID = '{roomId}'";

                object bill = cmd3.ExecuteScalar();

                txtBill.Text = bill.ToString();
            }
            catch (Exception ex) { }

        }

        private void NewData()
        {
            txtBookingId.Text = "Auto Generated";
            dtpBookingDate.Text = "";
            cmbRoomId.Text = "";
            cmbExtraBedId.Text ="";
            dtpCheckIn.Text = "";
            dtpCheckOut.Text = "";
            txtBill.Text = "";
            dgvData.ClearSelection();
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            NewData();
           
           
        }

        private void btnOffers_Click(object sender, EventArgs e)
        {

        }

        private void btnPayments_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadClientHomeForm();
            NewData();

        }

        private void ClientHomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            { this.Owner.Show(); }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            txtBookingId.Text = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpBookingDate.Text = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbRoomId.Text = dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbExtraBedId.Text = dgvData.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpCheckIn.Text = dgvData.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpCheckOut.Text = dgvData.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtBill.Text = dgvData.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtBookingId.Text;
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
                cmd.CommandText = $"delete from RoomBooking where Booking_ID={id} ";
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Booking {id} Deleted Successfully");
                this.LoadClientHomeForm();
                this.NewData();


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
            string bookingId=txtBookingId.Text;
            DateTime bookingDate = dtpBookingDate.Value;
            string roomId = cmbRoomId.Text;
            string extraBedId = cmbExtraBedId.Text;
            DateTime checkIn = dtpCheckIn.Value;
            DateTime checkOut = dtpCheckOut.Value;
            string bill = txtBill.Text;

            
                string conPath = ApplicationHelper.ConnectionPath;
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();
                var cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.CommandText = $"SELECT Booking_ID from RoomBooking Where Room_ID='{roomId}'  AND check_in='{checkIn}';SELECT * FROM ExtraBed; SELECT * FROM ROOMBOOKING";


                DataSet ds = new DataSet();
                var adp = new SqlDataAdapter(cmd2);
                adp.Fill(ds);
                cmd2.ExecuteNonQuery();
                string query = "";
                if(bookingId=="Auto Generated") 
                { 
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                    MessageBox.Show("The room is already booked on that day");
                    return;
                    }

                    var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = $"insert into RoomBooking values ('{bookingDate}' , '{ApplicationHelper.userID}','{roomId}', '{extraBedId}', '{checkIn}', '{checkOut}', 'Booked', '{bill}')";
                    cmd.ExecuteNonQuery();
                    this.LoadClientHomeForm();
                    con.Close();
                    MessageBox.Show("Booking Done Successfully!");
                }
                else
                {
                    query = $"UPDATE RoomBooking set Booking_Date = '{bookingDate}',User_ID = '{ApplicationHelper.userID}',Room_ID = '{roomId}',EB_ID = '{extraBedId}',Check_In = '{checkIn}',Check_Out = '{checkOut}',Status = 'Booked',Bill='{bill}' WHERE Booking_ID = '{bookingId}'";
                     

                    var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show($"Booking {bookingId} Updated Successfully");
                    this.LoadClientHomeForm();
                    this.NewData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbRoomId_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadBill();
        }

        private void cmbExtraBedId_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadBill();
        }
    }
}
