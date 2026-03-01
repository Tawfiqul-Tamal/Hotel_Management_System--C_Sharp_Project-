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
    public partial class ManageRoomCatergory : Form
    {
        public ManageRoomCatergory()
        {
            InitializeComponent();
        }

        private void ManageRooms_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string name = txtName.Text;

                string confirmText = "";
                string query = "";

                bool flag=false;
                for (int i = 0; i < dgvUI.Rows.Count; i++)
                {
                    if (dgvUI.Rows[i].Cells[0].Value != null && dgvUI.Rows[i].Cells[0].Value.ToString() == id)
                    {
                        flag = true;
                    }
                }

                if (flag == false)
                {
                    query = $"INSERT INTO RoomCategory values ('{id}','{name}')";
                    confirmText = "Category Inserted Succesfully";
                }
                else
                {
                    query = $"UPDATE RoomCategory set Title = '{name}' where RC_ID='{id}' ";
                    confirmText = $"Category {id} Updated Successfully";
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
                this.LoadRoomCategoryData();

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            this.LoadRoomCategoryData();
        }
        private void LoadRoomCategoryData()
        {
            string conPath = ApplicationHelper.ConnectionPath;
            var con = new SqlConnection();
            con.ConnectionString = conPath;
            con.Open();

            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"select * from RoomCategory ";
            cmd.ExecuteNonQuery();



            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            dgvUI.DataSource = dt;
            dgvUI.Refresh();
            dgvUI.ClearSelection();

            con.Close();

        }
        private void NewRoomCategoryData()
        {
            txtID.Text = "";
            txtName.Text = "";
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewRoomCategoryData();
            this.LoadRoomCategoryData();
        }

        private void dgvUI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvUI.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvUI.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (id == "")
            {
                MessageBox.Show("Please Select a Specific Category First!");
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
                cmd.CommandText = $"delete from RoomCategory where RC_ID={id} ";
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show($"Category {id} Deleted Successfully");
                this.LoadRoomCategoryData();
                this.NewRoomCategoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadRoomCategoryData();
            this.NewRoomCategoryData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
