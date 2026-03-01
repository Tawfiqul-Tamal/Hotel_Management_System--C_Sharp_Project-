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
    public partial class Manage_Guest_Check_IN_OUT__Staff_ : Form
    {
        public Manage_Guest_Check_IN_OUT__Staff_()
        {
            InitializeComponent();
        }

        private void Manage_Guest_Check_IN_OUT__Staff__Load(object sender, EventArgs e)
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
                cmd.CommandText = "Select * from Check_In_Out;Select * from RoomPrice";



                DataSet ds = new DataSet();
                var adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                con.Close();

                dgvMGCICO.AutoGenerateColumns = false;
                dgvMGCICO.DataSource = ds.Tables[0];
                dgvMGCICO.Refresh();
                dgvMGCICO.ClearSelection();//data initially select thakbe na grid a 
       
                cmbRID.DataSource = ds.Tables[1];
                cmbRID.DisplayMember = "Room_ID";
                cmbRID.ValueMember = "Room_ID";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMGCICO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtCID.Text = dgvMGCICO.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbRID.Text = dgvMGCICO.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpCIN.Text = dgvMGCICO.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpCOUT.Text = dgvMGCICO.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbStatus.Text = dgvMGCICO.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            this.NewData();
        }
        public void NewData()
        {
            txtCID.Text = "Auto Generated";
            cmbRID.Text = "";
            
            dtpCIN.Text = "";
            dtpCOUT.Text = "";
            cmbStatus.Text = "";
            dgvMGCICO.ClearSelection(); //dan paser data clear kore 
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cid = txtCID.Text;
            if (cid == "Auto Generated")
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
                cmd.CommandText = $"delete from Check_In_Out where C_ID={cid}";

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cid = txtCID.Text;
            string rid = cmbRID.Text;
            
            string cin = dtpCIN.Value.ToString("yyyy-MM-dd");
            string cout = dtpCOUT.Value.ToString("yyyy-MM-dd");
            string st = cmbStatus.Text;

            string query = "";
            if (cid == "Auto Generated")
            {
 
                query = $"INSERT INTO Check_In_Out (Room_ID, Check_In, Check_Out,Status) VALUES ({rid}, '{cin}', '{cout}','{st}')";
            }
            else

            {

                query = $"UPDATE Check_In_Out SET Room_ID = {rid}, Check_In = '{cin}', Check_Out = '{cout}',Status = '{st}' WHERE C_ID = {cid}";
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

        private void btnRef_Click(object sender, EventArgs e)
        {
            this.LoadData();
            this.NewData();
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
    }
}
