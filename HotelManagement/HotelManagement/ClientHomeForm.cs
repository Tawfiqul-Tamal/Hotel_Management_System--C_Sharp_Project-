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
    public partial class ClientHomeForm : Form
    {
        public ClientHomeForm()
        {
            InitializeComponent();
        }

        private void btnCustomerLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientHomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            ClientBookingForm cbf = new ClientBookingForm();
            cbf.Owner = this;
            this.Hide();
            cbf.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            ClientPaymentForm clientPaymentForm = new ClientPaymentForm();  
            clientPaymentForm.Show();
            clientPaymentForm.Owner = this;
            this.Hide();
        }

        private void btnOffers_Click(object sender, EventArgs e)
        {
            ClientOffersViewForm clientOffersViewForm = new ClientOffersViewForm();
            clientOffersViewForm.Show();
            this.Hide();
            clientOffersViewForm.Owner = this;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ClientChangePasswordForm clientChangePasswordForm = new ClientChangePasswordForm();
            clientChangePasswordForm.Show();
            this.Hide();
            clientChangePasswordForm.Owner=this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientFeedbackForm cf=new ClientFeedbackForm();
            cf.Owner = this;
            cf.Show();
            this.Hide();

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void ClientHomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {ApplicationHelper.name} [{ApplicationHelper.userType}]";
        }

        private void btnBookings_MouseHover(object sender, EventArgs e)
        {
            btnBookings.BackColor = Color.LightBlue;
        }

        private void btnBookings_MouseLeave(object sender, EventArgs e)
        {
            btnBookings.BackColor = Color.White;
        }

        private void btnPayment_MouseHover(object sender, EventArgs e)
        {
            btnPayment.BackColor = Color.LightBlue;
        }

        private void btnPayment_MouseLeave(object sender, EventArgs e)
        {
            btnPayment.BackColor = Color.White;
        }

        private void btnOffers_MouseHover(object sender, EventArgs e)
        {
            btnOffers.BackColor = Color.LightBlue;
        }

        private void btnOffers_MouseLeave(object sender, EventArgs e)
        {
            btnOffers.BackColor = Color.White;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnFeedback.BackColor = Color.LightBlue;
        }

        private void btnFeedback_MouseLeave(object sender, EventArgs e)
        {
            btnFeedback.BackColor = Color.White;
        }

        private void btnChangePassword_MouseHover(object sender, EventArgs e)
        {
            btnChangePassword.BackColor = Color.LightBlue;
        }

        private void btnChangePassword_MouseLeave(object sender, EventArgs e)
        {
            btnChangePassword.BackColor = Color.White;
        }

        private void btnCustomerLogOut_MouseHover(object sender, EventArgs e)
        {
            btnCustomerLogOut.BackColor = Color.LightBlue;
        }

        private void btnCustomerLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnCustomerLogOut.BackColor = Color.White;
        }
    }
}
