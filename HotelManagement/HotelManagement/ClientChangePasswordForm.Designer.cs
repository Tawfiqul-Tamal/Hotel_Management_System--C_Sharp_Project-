namespace HotelManagement
{
    partial class ClientChangePasswordForm
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
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPass.Location = new System.Drawing.Point(62, 90);
            this.lblCurrentPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(165, 22);
            this.lblCurrentPass.TabIndex = 0;
            this.lblCurrentPass.Text = "Current Password:";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(89, 139);
            this.lblNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(137, 22);
            this.lblNewPass.TabIndex = 1;
            this.lblNewPass.Text = "New Password:";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(226, 93);
            this.txtCurrentPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(186, 20);
            this.txtCurrentPass.TabIndex = 2;
            this.txtCurrentPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(226, 139);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(186, 20);
            this.txtNewPass.TabIndex = 3;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(226, 206);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(327, 206);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(84, 29);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClientChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 328);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblCurrentPass);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ClientChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientChangePasswordForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientChangePasswordForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
    }
}