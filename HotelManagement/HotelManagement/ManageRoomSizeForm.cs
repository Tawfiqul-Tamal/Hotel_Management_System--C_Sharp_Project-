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
    public partial class ManageRoomSizeForm : Form
    {
        public ManageRoomSizeForm()
        {
            InitializeComponent();
        }
        private void LoadRoomSizeData()
        {
            string conPath = ApplicationHelper.ConnectionPath;
            var con = new SqlConnection();
            con.ConnectionString = conPath;
            con.Open();

            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"select * from RoomSize ";
            cmd.ExecuteNonQuery();



            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            dgvUI.DataSource = dt;
            dgvUI.Refresh();
            dgvUI.ClearSelection();

            con.Close();

        }
        private void NewRoomSizeData()
        {
            txtID.Text = "";
            txtName.Text = "";
            cmbCapacity.Text = "";
        }
        private void ManageRoomSize_Load(object sender, EventArgs e)
        {
            this.LoadRoomSizeData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadRoomSizeData();
            this.NewRoomSizeData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ManageRoomSize_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewRoomSizeData();
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
                cmd.CommandText = $"delete from RoomSize where RS_ID={id} ";
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Category {id} Deleted Successfully");
                this.LoadRoomSizeData();
                this.NewRoomSizeData();
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
                string name = txtName.Text;
                string capacity=cmbCapacity.Text;

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
                    query = $"INSERT INTO RoomSize values ('{id}','{name}','{capacity}')";
                    confirmText = "Room Size Inserted Succesfully";
                }
                else
                {
                    query = $"UPDATE RoomSize set Title = '{name}' where RS_ID='{id}' ";
                    confirmText = $"Room Size {id} Updated Successfully";
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
                this.LoadRoomSizeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvUI.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvUI.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbCapacity.Text = dgvUI.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
