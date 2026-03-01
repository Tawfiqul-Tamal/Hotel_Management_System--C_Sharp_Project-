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
    public partial class Generate_Bills__Staff_ : Form
    {
        public Generate_Bills__Staff_()
        {
            InitializeComponent();
        }


        private void Generate_Bills__Staff__Load(object sender, EventArgs e)
        {
            if
             (this.Owner != null)
                this.Owner.Hide();
            this.LoadData();
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
                cmd.CommandText = "select * from Payment;select * from RoomBooking";

                
                DataSet ds = new DataSet();
                var adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                con.Close();

                dgvGBAP.AutoGenerateColumns = false;
                dgvGBAP.DataSource = ds.Tables[0];
                dgvGBAP.Refresh();
                dgvGBAP.ClearSelection();//data initially select thakbe na grid a 
                
                cmbBID.DataSource = ds.Tables[1];
                cmbBID.DisplayMember = "Booking_ID";
                cmbBID.ValueMember = "Booking_ID";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void NewData()
        {
            txtPID.Text = "Auto Generated";
            dtpPD.Text = "";
            cmbPM.Text = "";
            cmbBID.Text = "";
            txtBill.Text = "";
            cmbDiscount.Text = "";
            dgvGBAP.ClearSelection();
        }



        private void dgvGBAP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtPID.Text = dgvGBAP.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpPD.Text = dgvGBAP.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbBID.Text = dgvGBAP.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbPM.Text = dgvGBAP.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtBill.Text = dgvGBAP.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbDiscount.Text = dgvGBAP.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnGB_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        private void btnDP_Click(object sender, EventArgs e)
        {
            string pid = txtPID.Text;
            if (pid == "Auto Generated")
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
                cmd.CommandText = $"delete from Payment where Payment_ID={pid}";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Complete Deleted");
                this.LoadData();
                this.NewData();
                con.Close();
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
            string pid = txtPID.Text;
            string pd = dtpPD.Value.ToString("yyyy-MM-dd");
            string pm = cmbPM.Text;
            string bill = txtBill.Text;
            string dis = cmbDiscount.Text;
            string bid=cmbBID.Text;


            string query = "";
            if (pid == "Auto Generated")
            {
                query = $"insert into Payment (Payment_Date,Booking_ID, Type, Amount,Discount) values ('{pd}','{bid}','{pm}',{bill},{dis})";
            }
            else

            {
                query = $"update Payment set Payment_Date ='{pd}',Booking_ID='{bid}',Type='{pm}',Amount = {bill},Discount ={dis} where Payment_ID = {pid}";
            }

            try
            {

                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Payment saved successfully");
                this.LoadData();
                this.NewData();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     


        private void Generate_Bills__Staff__FormClosing(object sender, FormClosingEventArgs e)
        {
 
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }

        private void btnGB_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnGB_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ActiveCaption;
        }

        private void btnDP_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnDP_MouseLeave(object sender, EventArgs e)
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnLogOut_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ActiveCaption;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if
              (this.Owner != null)
                this.Owner.Show();
            this.Hide();
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

        private void cmbBID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
    

