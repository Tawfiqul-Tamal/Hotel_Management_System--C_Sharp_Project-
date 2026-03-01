namespace HotelManagement
{
    partial class Generate_Bills__Staff_
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
            this.dtpPD = new System.Windows.Forms.DateTimePicker();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblBID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvGBAP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnDP = new System.Windows.Forms.Button();
            this.btnGB = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGBAP)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpPD
            // 
            this.dtpPD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPD.Location = new System.Drawing.Point(183, 116);
            this.dtpPD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPD.Name = "dtpPD";
            this.dtpPD.Size = new System.Drawing.Size(250, 22);
            this.dtpPD.TabIndex = 21;
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(19, 114);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(130, 23);
            this.lblGuestName.TabIndex = 16;
            this.lblGuestName.Text = "Payment Date";
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(183, 251);
            this.txtBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(250, 22);
            this.txtBill.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bill";
            // 
            // cmbPM
            // 
            this.cmbPM.FormattingEnabled = true;
            this.cmbPM.Items.AddRange(new object[] {
            "Cash",
            "Mobile",
            "Card"});
            this.cmbPM.Location = new System.Drawing.Point(183, 158);
            this.cmbPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPM.Name = "cmbPM";
            this.cmbPM.Size = new System.Drawing.Size(250, 24);
            this.cmbPM.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Payment Method";
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(183, 64);
            this.txtPID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPID.Name = "txtPID";
            this.txtPID.ReadOnly = true;
            this.txtPID.Size = new System.Drawing.Size(250, 22);
            this.txtPID.TabIndex = 0;
            this.txtPID.Text = "Auto Generated";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbDiscount);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cmbBID);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnLogOut);
            this.panel4.Controls.Add(this.dtpPD);
            this.panel4.Controls.Add(this.lblGuestName);
            this.panel4.Controls.Add(this.txtBill);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cmbPM);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblBID);
            this.panel4.Controls.Add(this.txtPID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(705, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(465, 507);
            this.panel4.TabIndex = 3;
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "0 ",
            "10 ",
            "20 ",
            "30 "});
            this.cmbDiscount.Location = new System.Drawing.Point(183, 290);
            this.cmbDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(250, 24);
            this.cmbDiscount.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Discount";
            // 
            // cmbBID
            // 
            this.cmbBID.FormattingEnabled = true;
            this.cmbBID.Location = new System.Drawing.Point(183, 202);
            this.cmbBID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBID.Name = "cmbBID";
            this.cmbBID.Size = new System.Drawing.Size(250, 24);
            this.cmbBID.TabIndex = 24;
            this.cmbBID.SelectedIndexChanged += new System.EventHandler(this.cmbBID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Booking ID";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(116, 382);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(129, 49);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            this.btnLogOut.MouseHover += new System.EventHandler(this.btnLogOut_MouseHover);
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBID.Location = new System.Drawing.Point(19, 63);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(110, 23);
            this.lblBID.TabIndex = 1;
            this.lblBID.Text = "Payment ID";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 471F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1173, 571);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvGBAP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(696, 507);
            this.panel3.TabIndex = 2;
            // 
            // dgvGBAP
            // 
            this.dgvGBAP.AllowUserToAddRows = false;
            this.dgvGBAP.AllowUserToDeleteRows = false;
            this.dgvGBAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGBAP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dgvGBAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGBAP.Location = new System.Drawing.Point(0, 0);
            this.dgvGBAP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGBAP.Name = "dgvGBAP";
            this.dgvGBAP.ReadOnly = true;
            this.dgvGBAP.RowHeadersWidth = 51;
            this.dgvGBAP.RowTemplate.Height = 24;
            this.dgvGBAP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGBAP.Size = new System.Drawing.Size(694, 505);
            this.dgvGBAP.TabIndex = 0;
            this.dgvGBAP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGBAP_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Payment_ID";
            this.Column1.HeaderText = "Payment ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Payment_Date";
            this.Column2.HeaderText = "Payment Date";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Booking_ID";
            this.Column4.HeaderText = "Booking ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Type";
            this.Column3.HeaderText = "Payment Method";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Amount";
            this.Column5.HeaderText = "Bill";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Discount";
            this.Column6.HeaderText = "Discount  (%)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(705, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 56);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(49, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 41);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(269, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 41);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRef);
            this.panel1.Controls.Add(this.btnDP);
            this.panel1.Controls.Add(this.btnGB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnRef
            // 
            this.btnRef.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRef.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef.Location = new System.Drawing.Point(481, 2);
            this.btnRef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(109, 41);
            this.btnRef.TabIndex = 3;
            this.btnRef.Text = "Refresh";
            this.btnRef.UseVisualStyleBackColor = false;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            this.btnRef.MouseLeave += new System.EventHandler(this.btnRef_MouseLeave);
            this.btnRef.MouseHover += new System.EventHandler(this.btnRef_MouseHover);
            // 
            // btnDP
            // 
            this.btnDP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDP.Location = new System.Drawing.Point(237, 2);
            this.btnDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDP.Name = "btnDP";
            this.btnDP.Size = new System.Drawing.Size(201, 41);
            this.btnDP.TabIndex = 1;
            this.btnDP.Text = "Delete Payment";
            this.btnDP.UseVisualStyleBackColor = false;
            this.btnDP.Click += new System.EventHandler(this.btnDP_Click);
            this.btnDP.MouseLeave += new System.EventHandler(this.btnDP_MouseLeave);
            this.btnDP.MouseHover += new System.EventHandler(this.btnDP_MouseHover);
            // 
            // btnGB
            // 
            this.btnGB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGB.Location = new System.Drawing.Point(20, 2);
            this.btnGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGB.Name = "btnGB";
            this.btnGB.Size = new System.Drawing.Size(184, 41);
            this.btnGB.TabIndex = 0;
            this.btnGB.Text = "Generate Bills";
            this.btnGB.UseVisualStyleBackColor = false;
            this.btnGB.Click += new System.EventHandler(this.btnGB_Click);
            this.btnGB.MouseLeave += new System.EventHandler(this.btnGB_MouseLeave);
            this.btnGB.MouseHover += new System.EventHandler(this.btnGB_MouseHover);
            // 
            // Generate_Bills__Staff_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1173, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Generate_Bills__Staff_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Bills Staff";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Generate_Bills__Staff__FormClosing);
            this.Load += new System.EventHandler(this.Generate_Bills__Staff__Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGBAP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpPD;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvGBAP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnDP;
        private System.Windows.Forms.Button btnGB;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBID;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}