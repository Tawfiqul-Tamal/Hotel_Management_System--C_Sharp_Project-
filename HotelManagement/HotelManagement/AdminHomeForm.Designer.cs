namespace HotelManagement
{
    partial class AdminHomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnStaffAdmin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnSizes = new System.Windows.Forms.Button();
            this.btnPrices = new System.Windows.Forms.Button();
            this.btnExtraBed = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 38);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(109, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "lblWelcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnStaffAdmin
            // 
            this.btnStaffAdmin.BackColor = System.Drawing.Color.LightCyan;
            this.btnStaffAdmin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffAdmin.Location = new System.Drawing.Point(54, 97);
            this.btnStaffAdmin.Name = "btnStaffAdmin";
            this.btnStaffAdmin.Size = new System.Drawing.Size(172, 94);
            this.btnStaffAdmin.TabIndex = 1;
            this.btnStaffAdmin.Text = "Manage Admins";
            this.btnStaffAdmin.UseVisualStyleBackColor = false;
            this.btnStaffAdmin.Click += new System.EventHandler(this.button1_Click);
            this.btnStaffAdmin.MouseLeave += new System.EventHandler(this.btnStaffAdmin_MouseLeave);
            this.btnStaffAdmin.MouseHover += new System.EventHandler(this.btnStaffAdmin_MouseHover_1);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.MintCream;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(818, 35);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 32);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.LightCyan;
            this.btnClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(282, 97);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(172, 94);
            this.btnClient.TabIndex = 7;
            this.btnClient.Text = "Manage Clients";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnGuest_Click);
            this.btnClient.MouseLeave += new System.EventHandler(this.btnStaffAdmin_MouseLeave);
            this.btnClient.MouseHover += new System.EventHandler(this.btnStaffAdmin_MouseHover_1);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.LightCyan;
            this.btnCategories.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.Location = new System.Drawing.Point(54, 387);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(172, 94);
            this.btnCategories.TabIndex = 9;
            this.btnCategories.Text = "Room Categories";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnRooms_Click);
            this.btnCategories.MouseLeave += new System.EventHandler(this.btnStaffAdmin_MouseLeave);
            this.btnCategories.MouseHover += new System.EventHandler(this.btnStaffAdmin_MouseHover_1);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.MintCream;
            this.btnChangePass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(609, 34);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(184, 32);
            this.btnChangePass.TabIndex = 10;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnSizes
            // 
            this.btnSizes.BackColor = System.Drawing.Color.LightCyan;
            this.btnSizes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSizes.Location = new System.Drawing.Point(282, 387);
            this.btnSizes.Name = "btnSizes";
            this.btnSizes.Size = new System.Drawing.Size(172, 94);
            this.btnSizes.TabIndex = 11;
            this.btnSizes.Text = "Room Size";
            this.btnSizes.UseVisualStyleBackColor = false;
            this.btnSizes.Click += new System.EventHandler(this.btnSizes_Click);
            this.btnSizes.MouseLeave += new System.EventHandler(this.btnStaffAdmin_MouseLeave);
            this.btnSizes.MouseHover += new System.EventHandler(this.btnStaffAdmin_MouseHover_1);
            // 
            // btnPrices
            // 
            this.btnPrices.BackColor = System.Drawing.Color.LightCyan;
            this.btnPrices.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrices.Location = new System.Drawing.Point(512, 387);
            this.btnPrices.Name = "btnPrices";
            this.btnPrices.Size = new System.Drawing.Size(172, 94);
            this.btnPrices.TabIndex = 12;
            this.btnPrices.Text = "Room Prices";
            this.btnPrices.UseVisualStyleBackColor = false;
            this.btnPrices.Click += new System.EventHandler(this.btnPrices_Click);
            this.btnPrices.MouseLeave += new System.EventHandler(this.btnStaffAdmin_MouseLeave);
            this.btnPrices.MouseHover += new System.EventHandler(this.btnStaffAdmin_MouseHover_1);
            // 
            // btnExtraBed
            // 
            this.btnExtraBed.BackColor = System.Drawing.Color.LightCyan;
            this.btnExtraBed.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraBed.Location = new System.Drawing.Point(738, 387);
            this.btnExtraBed.Name = "btnExtraBed";
            this.btnExtraBed.Size = new System.Drawing.Size(172, 94);
            this.btnExtraBed.TabIndex = 13;
            this.btnExtraBed.Text = "Extra Bed";
            this.btnExtraBed.UseVisualStyleBackColor = false;
            this.btnExtraBed.Click += new System.EventHandler(this.btnExtraBed_Click);
            this.btnExtraBed.MouseLeave += new System.EventHandler(this.btnStaffAdmin_MouseLeave);
            this.btnExtraBed.MouseHover += new System.EventHandler(this.btnStaffAdmin_MouseHover_1);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.LightCyan;
            this.btnPayment.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(282, 240);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(172, 94);
            this.btnPayment.TabIndex = 14;
            this.btnPayment.Text = "View Payments";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            this.btnPayment.MouseLeave += new System.EventHandler(this.btnStaffAdmin_MouseLeave);
            this.btnPayment.MouseHover += new System.EventHandler(this.btnStaffAdmin_MouseHover_1);
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.LightCyan;
            this.btnFeedback.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.Location = new System.Drawing.Point(512, 240);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(172, 94);
            this.btnFeedback.TabIndex = 15;
            this.btnFeedback.Text = "View Feedbacks";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            this.btnFeedback.MouseLeave += new System.EventHandler(this.btnStaffAdmin_MouseLeave);
            this.btnFeedback.MouseHover += new System.EventHandler(this.btnStaffAdmin_MouseHover_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 94);
            this.button1.TabIndex = 16;
            this.button1.Text = "View Entry/Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseLeave += new System.EventHandler(this.btnStaffAdmin_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.btnStaffAdmin_MouseHover_1);
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.Color.LightCyan;
            this.btnReservations.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.Location = new System.Drawing.Point(512, 97);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(172, 94);
            this.btnReservations.TabIndex = 8;
            this.btnReservations.Text = "Manage Reservations";
            this.btnReservations.UseVisualStyleBackColor = false;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            this.btnReservations.MouseLeave += new System.EventHandler(this.btnStaffAdmin_MouseLeave);
            this.btnReservations.MouseHover += new System.EventHandler(this.btnStaffAdmin_MouseHover_1);
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(968, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnExtraBed);
            this.Controls.Add(this.btnPrices);
            this.Controls.Add(this.btnSizes);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStaffAdmin);
            this.Controls.Add(this.lblWelcome);
            this.MaximizeBox = false;
            this.Name = "AdminHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHomeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHomeForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminHomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnStaffAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnSizes;
        private System.Windows.Forms.Button btnPrices;
        private System.Windows.Forms.Button btnExtraBed;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReservations;
    }
}