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
    public partial class Staff_Dash_Board : Form
    {
        public Staff_Dash_Board()
        {
            InitializeComponent();
        }

        private void btnMGCICO_Click(object sender, EventArgs e)
        {
            Manage_Guest_Check_IN_OUT__Staff_ mgcio = new Manage_Guest_Check_IN_OUT__Staff_();
            mgcio.Show(this);

           
        }

        private void btnURS_Click(object sender, EventArgs e)
        {
           Update_Room_Status__Staff_ urs = new Update_Room_Status__Staff_();
            urs.Show(this);
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            Manage_Reservation__Staff_ mr = new Manage_Reservation__Staff_();
            mr.Show(this);
        }

        private void btnGB_Click(object sender, EventArgs e)
        {
            Generate_Bills__Staff_ gb = new Generate_Bills__Staff_();
            gb.Show(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show(this);
            this.Hide();
        }

        private void btnMGCICO_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnMGCICO_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ActiveCaption;
        }

        private void btnURS_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnURS_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ActiveCaption;
        }

        private void btnMR_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnMR_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ActiveCaption;
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

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.PaleTurquoise;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnChangePass_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.PaleTurquoise;
        }

        private void btnChangePass_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void Staff_Dash_Board_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            StaffChangePassword scp = new StaffChangePassword();
            scp.Owner = this;
           scp.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            ViewFeedback_Staff_ svf = new ViewFeedback_Staff_();
            svf.Owner = this;
            svf.Show();
            this.Hide();
        }

        private void btnFeedback_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Aqua;
        }

        private void btnFeedback_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.ActiveCaption;
        }

        private void Staff_Dash_Board_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    } 

        
          
}

