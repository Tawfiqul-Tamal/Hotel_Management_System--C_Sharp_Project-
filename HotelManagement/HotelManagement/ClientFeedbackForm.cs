using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagement
{
    public partial class ClientFeedbackForm : Form
    {
        public ClientFeedbackForm()
        {
            InitializeComponent();
        }

        private void dgvUI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientFeedbackForm_Load(object sender, EventArgs e)
        {
            this.LoadFeedbackData();
        }

        private void LoadFeedbackData()
        {
            string conPath = ApplicationHelper.ConnectionPath;
            var con = new SqlConnection();
            con.ConnectionString = conPath;
            con.Open();

            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"select Feedback_ID,Rating,Feedback from Feedback where User_ID={ApplicationHelper.userID} ";
            cmd.ExecuteNonQuery();



            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            dgvUI.DataSource = dt;
            dgvUI.Refresh();
            dgvUI.ClearSelection();

            con.Close();
        }
        private void NewFeedback()
        {
            txtID.Text = "Auto Generated";
            cmbRating.Text = "";
            txtFeedback.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.NewFeedback();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadFeedbackData();
            this.NewFeedback();
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
                cmd.CommandText = $"delete from Feedback where Feedback_ID={id} ";
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Feedback {id} Deleted Successfully");
                this.LoadFeedbackData();
                this.NewFeedback();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            txtID.Text = dgvUI.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbRating.Text = dgvUI.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFeedback.Text = dgvUI.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string rating = cmbRating.Text;
            string feedback = txtFeedback.Text;

            string confirmText = "";
            string query = "";


            if (id=="Auto Generated")
            {
                query = $"INSERT INTO Feedback values ('{ApplicationHelper.userID}','{rating}','{feedback}')";
                confirmText = "New Feedback Inserted Succesfully";
            }
            else
            {
                query = $"UPDATE Feedback set Rating = '{rating}',Feedback='{feedback}' where Feedback_ID='{id}' ";
                confirmText = $"Feedback [{id}] Updated Successfully";
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
            this.LoadFeedbackData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientFeedbackForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
