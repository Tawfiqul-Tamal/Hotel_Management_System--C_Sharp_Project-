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
    public partial class Update_Room_Status__Staff_ : Form
    {
        public Update_Room_Status__Staff_()
        {
            InitializeComponent();
        }

        private void Update_Room_Status__Staff__Load(object sender, EventArgs e)
        {
            if
             (this.Owner != null)
                this.Owner.Hide();
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT \r\n    rb.Booking_ID,\r\n    rb.Room_ID,\r\n    rb.Status,\r\n    p.Payment_ID,\r\n    p.Payment_Date\r\nFROM RoomBooking rb\r\nINNER JOIN Payment p ON rb.Booking_ID = p.Booking_ID;";

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                dgvUS.AutoGenerateColumns = false;
                dgvUS.DataSource = dt;
                dgvUS.Refresh();


                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtBID.Text = dgvUS.Rows[e.RowIndex].Cells[0].Value.ToString();

            cmbStatus.Text = dgvUS.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT \r\n    rb.Booking_ID,\r\n    rb.Room_ID,\r\n    rb.Status,\r\n    p.Payment_ID,\r\n    p.Payment_Date\r\nFROM RoomBooking rb\r\nINNER JOIN Payment p ON rb.Booking_ID = p.Booking_ID";

                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                dgvUS.AutoGenerateColumns = false;
                dgvUS.DataSource = dt;
                dgvUS.Refresh();


                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            txtBID.Text = "Auto Generated";
            cmbStatus.Text = "";

            dgvUS.ClearSelection();
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
                cmd.CommandText = "SELECT \r\n    rb.Booking_ID,\r\n    rb.Room_ID,\r\n    rb.Status,\r\n    p.Payment_ID,\r\n    p.Payment_Date\r\nFROM RoomBooking rb\r\nINNER JOIN Payment p ON rb.Booking_ID = p.Booking_ID";

                DataTable dt = new DataTable();
                var adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                con.Close();

                dgvUS.AutoGenerateColumns = false;
                dgvUS.DataSource = dt;
                dgvUS.Refresh();
                dgvUS.ClearSelection();//data initially select thakbe na grid a 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void NewData()
        {
            txtBID.Text = "Auto Generated";
            cmbStatus.Text = "";
            dgvUS.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string bid = txtBID.Text;
            string st = cmbStatus.Text;


            string query = $"update RoomBooking set  Status ='{st}'where Booking_ID= {bid}";


            try
            {

                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

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
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if
               (this.Owner != null)
                this.Owner.Show();
            this.Hide();
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
    }
}
