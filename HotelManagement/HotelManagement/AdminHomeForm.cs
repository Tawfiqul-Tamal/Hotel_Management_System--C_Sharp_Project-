using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text=$"Welcome, {ApplicationHelper.name} [{ApplicationHelper.userType}]";
        }

        private void AdminHomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageStaffAdminForm msa=new ManageStaffAdminForm();
            msa.Show();
            msa.Owner = this;
            this.Hide(); 
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            ManageClientForm mg=new ManageClientForm();
            mg.Show();
            mg.Owner = this;
            this.Hide(); 
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            ManageResevationsForm mr = new ManageResevationsForm();
            mr.Show();
            mr.Owner = this;
            this.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            ManageRoomCatergory mrc = new ManageRoomCatergory();
            mrc.Show();
            mrc.Owner = this;
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSizes_Click(object sender, EventArgs e)
        {
            ManageRoomSizeForm mrs= new ManageRoomSizeForm();
            mrs.Owner = this;
            mrs.Show();
            this.Hide();
        }

        private void btnExtraBed_Click(object sender, EventArgs e)
        {
            ManageExtraBedForm meb = new ManageExtraBedForm();
            meb.Owner = this;
            meb.Show();
            this.Hide();
        }

        private void btnPrices_Click(object sender, EventArgs e)
        {
            ManageRoomPriceForm meb = new ManageRoomPriceForm();
            meb.Owner = this;
            meb.Show();
            this.Hide();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            AdminChangePasswordForm acp = new AdminChangePasswordForm();
            acp.Owner = this;
            acp.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            AdminViewPaymentForm apf = new AdminViewPaymentForm();
            apf.Owner = this;
            apf.Show();
            this.Hide();

        }

        private void btnStaffAdmin_MouseHover(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            btn.BackColor=Color.Blue;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            AdminViewFeedbackForm adf=new AdminViewFeedbackForm();
            adf.Owner = this;
            adf.Show();
            this.Hide();
        }

        private void btnStaffAdmin_MouseHover_1(object sender, EventArgs e)
        {
            Button btn =(Button)sender;
            btn.BackColor=Color.LightBlue;
        }

        private void btnStaffAdmin_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightCyan;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminViewCheckInCheckOut avc=new AdminViewCheckInCheckOut();
            avc.Owner = this;
            avc.Show();
            this.Hide();
        }


    }
}
