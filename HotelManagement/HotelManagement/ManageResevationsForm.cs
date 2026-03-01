using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagement
{
    public partial class ManageResevationsForm : Form
    {
        public ManageResevationsForm()
        {
            InitializeComponent();
        }

        private void ManageResevations_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
        private void LoadBookingData()
        {
            string conPath = ApplicationHelper.ConnectionPath;
            var con = new SqlConnection();
            con.ConnectionString = conPath;
            con.Open();
            
            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"Select * from RoomBooking ; Select * from UserInfo where User_Type='Client'; Select * from RoomPrice;Select * from ExtraBed";
            cmd.ExecuteNonQuery();



            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);

            dgvUI.DataSource = ds.Tables[0];
            dgvUI.Refresh();
            dgvUI.ClearSelection();


            //client combobox

            cmbUserID.DataSource = ds.Tables[1];
            cmbUserID.DisplayMember = "User_ID";

            ////RoomID combobox

            cmbRoomID.DataSource = ds.Tables[2];
            cmbRoomID.DisplayMember = "Room_ID";

            //Extra Bed combobox
            cmbExtraBedID.DataSource = ds.Tables[3];
            cmbExtraBedID.DisplayMember = "EB_ID";

            con.Close();

        }
        private void NewBookingData()
        {
            txtBookingID.Text = "Auto Generated";
            dtpBookingDate.Text = "";
            cmbUserID.Text = "";
            cmbRoomID.Text = "";
            cmbExtraBedID.Text = "";
            dtpCheckIn.Text = "";
            dtpCheckOut.Text = "";
            cmbStatus.Text = "";
            txtBill.Text = "";
            dgvUI.ClearSelection();
        }
        private void ManageResevationsForm_Load(object sender, EventArgs e)
        {
            this.LoadBookingData();
            this.NewBookingData();
        }

        private void dgvUI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            txtBookingID.Text = dgvUI.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpBookingDate.Text = dgvUI.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbUserID.Text = dgvUI.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbRoomID.Text = dgvUI.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbExtraBedID.Text = dgvUI.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpCheckIn.Text = dgvUI.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpCheckOut.Text = dgvUI.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbStatus.Text = dgvUI.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtBill.Text= dgvUI.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewBookingData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadBookingData();
            this.NewBookingData();
        }

        private void dgvUI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string bookingId = txtBookingID.Text;
                DateTime bookingDate = dtpBookingDate.Value;
                string userId = cmbUserID.Text;
                string roomId = cmbRoomID.Text;
                string ebId = cmbExtraBedID.Text;
                DateTime checkIn = dtpCheckIn.Value;
                DateTime checkOut = dtpCheckOut.Value;
                string status = cmbStatus.Text;
                string bill = txtBill.Text;

                string conPath = ApplicationHelper.ConnectionPath;
                var con = new SqlConnection();
                con.ConnectionString = conPath;
                con.Open();




                string query = "";
                string confirmText = "";
                if (bookingId == "Auto Generated")
                {
                    query = $"INSERT INTO RoomBooking values ('{bookingDate}','{userId}','{roomId}','{ebId}','{checkIn}','{checkOut}','{status}','{bill}')";
                    confirmText = "Booking Inserted Succesfully";

                    //already booked
                    var cmd2 = new SqlCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = $"SELECT Booking_ID from RoomBooking Where Room_ID='{roomId}'  AND check_in='{checkIn}';SELECT * FROM ExtraBed; SELECT * FROM ROOMBOOKING";


                    DataSet ds = new DataSet();
                    var adp = new SqlDataAdapter(cmd2);
                    adp.Fill(ds);
                    cmd2.ExecuteNonQuery();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("The room is already booked on that day");
                        return;
                    }

                    var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(confirmText);
                    this.LoadBookingData();
                    this.NewBookingData();


                }
                else
                {

                    query = $"UPDATE RoomBooking set Booking_Date = '{bookingDate}',User_ID = '{userId}',Room_ID = '{roomId}',EB_ID = '{ebId}',Check_In = '{checkIn}',Check_Out = '{checkOut}',Status = '{status}',Bill='{bill}' WHERE Booking_ID = '{bookingId}'";
                    confirmText = $"Booking {bookingId} Updated Successfully";

                    var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(confirmText);
                    this.LoadBookingData();
                    this.NewBookingData();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtBookingID.Text;
            if (id == "Auto Generated" || id == "")
            {
                MessageBox.Show("Please Select a Specific Booking First!");
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
                this.LoadBookingData();
                this.NewBookingData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void brnNew_Click(object sender, EventArgs e)
        {
            ManageClientForm mg = new ManageClientForm();
            mg.Show();
            mg.Owner = this;
        }

        private void cmbRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.LoadBill();

        }
        private void LoadBill()
        {
            try
            {
                if (cmbRoomID.SelectedItem == null || cmbExtraBedID.SelectedItem == null)
                {
                    return;
                }

                string roomId = cmbRoomID.Text;
                string ebId = cmbExtraBedID.Text;


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

        private void cmbExtraBedID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadBill() ;
        }
    }
}
