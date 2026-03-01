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
using System.Xml.Linq;

namespace HotelManagement
{
    public partial class ManageRoomPriceForm : Form
    {
        public ManageRoomPriceForm()
        {
            InitializeComponent();
        }

        private void dgvUI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageRoomPriceForm_Load(object sender, EventArgs e)
        {
            this.LoadRoomPriceData();
            this.NewRoomPriceData();
        }
        private void LoadRoomPriceData()
        {
            string conPath = ApplicationHelper.ConnectionPath;
            var con = new SqlConnection();
            con.ConnectionString = conPath;
            con.Open();

            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"select RoomPrice.Room_ID,RoomPrice.RC_ID,RoomCategory.Title as Category,RoomPrice.RS_ID,RoomSize.Title as Size,RoomPrice.Price from roomprice inner join RoomCategory on RoomCategory.RC_ID=RoomPrice.RC_ID inner join RoomSize on RoomSize.RS_ID=RoomPrice.RS_ID; Select * from RoomCategory; Select * from RoomSize";
            cmd.ExecuteNonQuery();



            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);

            dgvUI.DataSource = ds.Tables[0];
            dgvUI.Refresh();
            dgvUI.ClearSelection();


            //RoomCatgory ComboBox


            cmbRoomCategory.DataSource = ds.Tables[1];
            cmbRoomCategory.DisplayMember = "Title";
            cmbRoomCategory.ValueMember = "RC_ID";


            //RoomSize ComboBox

            cmbRoomSize.DataSource = ds.Tables[2];
            cmbRoomSize.DisplayMember = "Title";
            cmbRoomSize.ValueMember = "RS_ID";



            con.Close();
        }
        private void NewRoomPriceData()
        {
            txtID.Text = "";
            cmbRoomCategory.Text = "";
            cmbRoomSize.Text = "";
            txtPrice.Text = "";
        }

        private void ManageRoomPriceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewRoomPriceData();
        }

        private void dgvUI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvUI.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRCID.Text = dgvUI.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbRoomCategory.Text = dgvUI.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRSID.Text = dgvUI.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbRoomSize.Text = dgvUI.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPrice.Text = dgvUI.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadRoomPriceData();
            this.NewRoomPriceData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (id == "")
            {
                MessageBox.Show("Please Select a Specific Row First!");
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
                cmd.CommandText = $"delete from RoomPrice where Room_ID={id} ";
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Room [{id}] Deleted Successfully");
                this.LoadRoomPriceData();
                this.NewRoomPriceData();
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
                    string id = txtID.Text;
                // Get RoomCategory ID
                int rcID = Convert.ToInt32(cmbRoomCategory.SelectedValue);

                // Get RoomSize ID
                int rsID = Convert.ToInt32(cmbRoomSize.SelectedValue);
                string price = txtPrice.Text;

                    string confirmText = "";
                    string query = "";

                    bool flag = false;
                    for (int i = 0; i < dgvUI.Rows.Count; i++)
                    {
                        if (dgvUI.Rows[i].Cells[0].Value != null && dgvUI.Rows[i].Cells[0].Value.ToString() == id)
                        {
                            flag = true;
                        }
                    }

                    if (flag == false)
                    {
                        query = $"INSERT INTO RoomPrice values ('{id}','{rcID}','{rsID}','{price}')";
                        confirmText = "New Room Inserted Succesfully";
                    }
                    else
                    {
                        query = $"UPDATE RoomPrice set RC_ID = '{rcID}',RS_ID = '{rsID}',Price={price} where Room_ID='{id}' ";
                        confirmText = $"Room [{id}] Updated Successfully";
                    }
                    string conPath = ApplicationHelper.ConnectionPath;
                    var con = new SqlConnection();
                    con.ConnectionString = conPath;
                    con.Open();

                    var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(confirmText);
                    this.LoadRoomPriceData();
                }

            
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }

        }
    }
}
