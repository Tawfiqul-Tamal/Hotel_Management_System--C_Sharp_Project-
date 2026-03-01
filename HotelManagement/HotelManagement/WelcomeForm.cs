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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RegistrationForm rf=new RegistrationForm();
            rf.Owner = this;
            rf.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Owner = this;
            lf.Show();
            this.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
           if(this.Owner != null) 
                this.Owner.Hide();
        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Show();
        }
    }
}
