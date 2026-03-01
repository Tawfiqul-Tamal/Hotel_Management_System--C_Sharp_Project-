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
    public partial class ManageExtraBedForm : Form
    {
        public ManageExtraBedForm()
        {
            InitializeComponent();
        }

        private void ManageExtraBedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
        private void LoadExtraBedData()
        {
            string conPath = ApplicationHelper.ConnectionPath;
            var con = new SqlConnection();
            con.ConnectionString = conPath;
            con.Open();

            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"select * from ExtraBed ";
            cmd.ExecuteNonQuery();



            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            dgvUI.DataSource = dt;
            dgvUI.Refresh();
            dgvUI.ClearSelection();

            con.Close();

        }
        private void NewExtraBedData()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
        }

        private void ManageExtraBedForm_Load(object sender, EventArgs e)
        {
            this.LoadExtraBedData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewExtraBedData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadExtraBedData();
            this.NewExtraBedData();
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
                cmd.CommandText = $"delete from ExtraBed where EB_ID={id} ";
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show($"Extra Bed {id} Deleted Successfully");
                this.LoadExtraBedData();
                this.NewExtraBedData();
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
                    query = $"INSERT INTO ExtraBed values ('{id}','{name}','{price}')";
                    confirmText = "New Extra Bed Inserted Succesfully";
                }
                else
                {
                    query = $"UPDATE ExtraBed set Title = '{name}',Price={price} where EB_ID='{id}' ";
                    confirmText = $"Extra Bed [{id}] Updated Successfully";
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
                this.LoadExtraBedData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvUI.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvUI.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dgvUI.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
