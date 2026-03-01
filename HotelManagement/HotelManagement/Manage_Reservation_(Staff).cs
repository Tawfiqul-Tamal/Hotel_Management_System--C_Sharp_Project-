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
    public partial class Manage_Reservation__Staff_ : Form
    {
        public Manage_Reservation__Staff_()
        {
            InitializeComponent();
        }

        private void Manage_Reservation__Staff__Load(object sender, EventArgs e)
        {
            if
             (this.Owner != null)
                this.Owner.Hide();

            this.LoadData();
            this.NewData();
        }

        private void LoadData()
        {/*
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * from RoomBooking ; Select * from UserInfo where User_Type='Client'; Select * from RoomPrice;Select * from ExtraBed";

                DataSet ds = new DataSet();
                var adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                


                dgvMR.AutoGenerateColumns = false;
                dgvMR.DataSource = ds.Tables[0];
                dgvMR.Refresh();
                dgvMR.ClearSelection();//data initially select thakbe na grid a 


                cmbRID.DataSource = ds.Tables[2];
                cmbRID.DisplayMember = "Room_ID";
                cmbRID.ValueMember = "Room_ID";


                cmbGuestID.DataSource = ds.Tables[1];
                cmbGuestID.DisplayMember = "User_ID";
                cmbGuestID.ValueMember = "User_ID";


                cmbEBID.DataSource = ds.Tables[3];
                cmbEBID.DisplayMember = "EB_ID";
                cmbEBID.ValueMember = "EB_ID";
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/





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

            dgvMR.DataSource = ds.Tables[0];
            dgvMR.Refresh();
            dgvMR.ClearSelection();


            //client combobox

            cmbGuestID.DataSource = ds.Tables[1];
            cmbGuestID.DisplayMember = "User_ID";

            ////RoomID combobox

            cmbRID.DataSource = ds.Tables[2];
            cmbRID.DisplayMember = "Room_ID";

            //Extra Bed combobox
            cmbEBID.DataSource = ds.Tables[3];
            cmbEBID.DisplayMember = "EB_ID";

            con.Close();











        }

        private void dgvMR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            txtBID.Text = dgvMR.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpBD.Text = dgvMR.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbGuestID.Text = dgvMR.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbRID.Text = dgvMR.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbEBID.Text = dgvMR.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpCheckIn.Text = dgvMR.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpCheckOut.Text = dgvMR.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbStatus.Text = dgvMR.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtBill.Text = dgvMR.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        public void NewData()
        {
            txtBID.Text = "Auto Generated";
            dtpBD.Text = "";
            cmbGuestID.Text = "";
            cmbRID.Text = "";
            cmbEBID.Text = "";
            dtpCheckIn.Text = "";
            dtpCheckOut.Text = "";
            cmbStatus.Text = "";
            txtBill.Text = "";

            dgvMR.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /* string bid = txtBID.Text;
             if (bid == "Auto Generated")
             {
                 MessageBox.Show("Please Select The Row First");
                 return;
             }
             var result = MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo);

             if (result == DialogResult.No)
                 return;

             try
             {

                 var con = new SqlConnection();
                 con.ConnectionString = ApplicationHelper.ConnectionPath;
                 con.Open();

                 var cmd = new SqlCommand();
                 cmd.Connection = con;
                 cmd.CommandText = $"delete from RoomBooking where Booking_ID={bid}";

                 cmd.ExecuteNonQuery();

                 MessageBox.Show("Complete Deleted");
                 this.LoadData();
                 this.NewData();
                 con.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/


            string bid = txtBID.Text;
            if (bid == "Auto Generated" || bid == "")
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
                cmd.CommandText = $"delete from RoomBooking where Booking_ID={bid} ";
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Booking {bid} Deleted Successfully");
                this.LoadData();
                this.NewData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }












        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            this.LoadData();
            this.NewData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           /* string bid = txtBID.Text;
            string bd = dtpBD.Value.ToString("yyyy-MM-dd");
            string gid = cmbGuestID.Text;
            string rid = cmbRID.Text;
            string ebid = cmbEBID.Text;
            string cin = dtpCheckIn.Value.ToString("yyyy-MM-dd");
            string cout = dtpCheckOut.Value.ToString("yyyy-MM-dd");
            string st = cmbStatus.Text;
            string bill = txtBill.Text;
           */



            try
            {
                string bid = txtBID.Text;
                string bd = dtpBD.Value.ToString("yyyy-MM-dd");
                string gid = cmbGuestID.Text;
                string rid = cmbRID.Text;
                string ebid = cmbEBID.Text;
                string cin = dtpCheckIn.Value.ToString("yyyy-MM-dd");
                string cout = dtpCheckOut.Value.ToString("yyyy-MM-dd");
                string st = cmbStatus.Text;
                string bill = txtBill.Text;

                string conPath = ApplicationHelper.ConnectionPath;
                var con = new SqlConnection();
                con.ConnectionString = conPath;
                con.Open();




                string query = "";
                
                if (bid == "Auto Generated")
                {
                    query = $"INSERT INTO RoomBooking values ('{bd}','{gid}','{rid}','{ebid}','{cin}','{cout}','{st}','{bill}')";
                    

                    //already booked
                    var cmd2 = new SqlCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = $"SELECT Booking_ID from RoomBooking Where Room_ID='{rid}'  AND check_in='{cin}';SELECT * FROM ExtraBed; SELECT * FROM ROOMBOOKING";


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

                    
                    this.LoadData();
                    this.NewData();


                }
                else
                {

                    query = $"UPDATE RoomBooking set Booking_Date = '{bd}',User_ID = '{gid}',Room_ID = '{rid}',EB_ID = '{ebid}',Check_In = '{cin}',Check_Out = '{cout}',Status = '{st}',Bill='{bill}' WHERE Booking_ID = '{bid}'";
                    

                    var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    
                    this.LoadData();
                    this.NewData();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }











            /*string query = "";
            if (bid == "Auto Generated")
            {
                query = $"insert into RoomBooking values ('{bd}',{gid},{rid},{ebid},'{cin}','{cout}','{st}',{bill})";
            }
            else

            {
                query = $"update RoomBooking set Booking_Date ='{bd}',User_ID= {gid},Room_ID = {rid},EB_ID = {ebid},Check_In='{cin}',Check_Out='{cout}',Status ='{st}',Bill = {bill} where Booking_ID = {bid}";
            }

            try
            {

                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

                var cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.CommandText = $"SELECT Booking_ID from RoomBooking Where Room_ID='{rid}'  AND check_in='{cin}'";


                DataTable dt = new DataTable();
                var adp = new SqlDataAdapter(cmd2);
                adp.Fill(dt);
       
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("The room is already booked on that day");
                    return;
                }
                ;

                cmd2.ExecuteNonQuery();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Completed");
                this.LoadData();
                this.NewData();
                con.Close();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            } */
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if
               (this.Owner != null)
                this.Owner.Show();
            this.Hide();
        }

        private void btnNew_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnNew_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ActiveCaption;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ActiveCaption;
        }

        private void btnRef_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnRef_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ActiveCaption;
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ActiveCaption;
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cmbRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.LoadBill();

        }
        private void LoadBill()
        {
            try
            {
                if (cmbRID.SelectedItem == null || cmbEBID.SelectedItem == null)
                {
                    return;
                }

                string rid = cmbRID.Text;
                string ebid = cmbEBID.Text;


                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

                var cmd3 = new SqlCommand();
                cmd3.Connection = con;
                cmd3.CommandText = $"SELECT r.Price + e.Price AS Bill FROM RoomPrice r LEFT JOIN ExtraBed e ON e.EB_ID = '{ebid}' WHERE r.Room_ID = '{rid}'";

                object bill = cmd3.ExecuteScalar();

                txtBill.Text = bill.ToString();
            }
            catch (Exception ex) { }

        }

        private void cmbExtraBedID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadBill();
        }
    }
}
