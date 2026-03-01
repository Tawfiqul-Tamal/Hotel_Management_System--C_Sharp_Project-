namespace HotelManagement
{
    partial class ClientPaymentSubmissionForm
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
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.btnPay = new System.Windows.Forms.Button();
            this.cmbBookingId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.Location = new System.Drawing.Point(111, 94);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(117, 19);
            this.lblBookingDate.TabIndex = 17;
            this.lblBookingDate.Text = "Payment Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Amount:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(179, 180);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 19);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Booking ID:";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(246, 94);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(240, 22);
            this.dtpPaymentDate.TabIndex = 18;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(246, 222);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(240, 22);
            this.txtAmount.TabIndex = 20;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.Location = new System.Drawing.Point(246, 180);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(66, 23);
            this.rbCash.TabIndex = 21;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCard.Location = new System.Drawing.Point(419, 178);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(67, 23);
            this.rbCard.TabIndex = 22;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Card";
            this.rbCard.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(401, 270);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(85, 35);
            this.btnPay.TabIndex = 23;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // cmbBookingId
            // 
            this.cmbBookingId.FormattingEnabled = true;
            this.cmbBookingId.Location = new System.Drawing.Point(246, 132);
            this.cmbBookingId.Name = "cmbBookingId";
            this.cmbBookingId.Size = new System.Drawing.Size(240, 24);
            this.cmbBookingId.TabIndex = 24;
            this.cmbBookingId.Click += new System.EventHandler(this.cmbBookingId_Click);
            // 
            // ClientPaymentSubmissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(636, 365);
            this.Controls.Add(this.cmbBookingId);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.rbCard);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.lblBookingDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label1);
            this.Name = "ClientPaymentSubmissionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientPaymentSubmissionForm";
            this.Load += new System.EventHandler(this.ClientPaymentSubmissionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox cmbBookingId;
    }
}