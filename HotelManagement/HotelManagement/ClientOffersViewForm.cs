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
    public partial class ClientOffersViewForm : Form
    {
        public ClientOffersViewForm()
        {
            InitializeComponent();
        }

        private void ClientOffersViewForm_Load(object sender, EventArgs e)
        {
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.ConnectionPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select RoomPrice.Room_ID 'Room ID',RoomCategory.Title 'Category',RoomSize.Title 'Size',RoomPrice.Price from roomprice inner join RoomCategory on RoomCategory.RC_ID=RoomPrice.RC_ID inner join RoomSize on RoomSize.RS_ID=RoomPrice.RS_ID ";
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                dgvClientOffersView.DataSource = dt;
                dgvClientOffersView.Refresh();
                dgvClientOffersView.ClearSelection();

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientOffersViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            { this.Owner.Show(); }
        }
    }
}
