namespace HotelManagement
{
    partial class StaffChangePassword
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtCurrPass = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(57, 263);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 34);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(44, 183);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(158, 25);
            this.lblNewPassword.TabIndex = 19;
            this.lblNewPassword.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Current Password:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(215, 191);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(208, 20);
            this.txtNewPass.TabIndex = 17;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtCurrPass
            // 
            this.txtCurrPass.Location = new System.Drawing.Point(215, 150);
            this.txtCurrPass.Name = "txtCurrPass";
            this.txtCurrPass.Size = new System.Drawing.Size(208, 20);
            this.txtCurrPass.TabIndex = 16;
            this.txtCurrPass.UseSystemPasswordChar = true;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangePass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(285, 263);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(164, 34);
            this.btnChangePass.TabIndex = 15;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            this.btnChangePass.MouseLeave += new System.EventHandler(this.btnChangePass_MouseLeave);
            this.btnChangePass.MouseHover += new System.EventHandler(this.btnChangePass_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(139, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Change Password Form";
            // 
            // StaffChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(517, 361);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtCurrPass);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaffChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffChangePassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffChangePassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtCurrPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label label3;
    }
}