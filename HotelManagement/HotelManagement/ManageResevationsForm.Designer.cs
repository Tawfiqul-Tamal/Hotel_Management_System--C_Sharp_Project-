namespace HotelManagement
{
    partial class ManageResevationsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.brnNew = new System.Windows.Forms.Button();
            this.cmbExtraBedID = new System.Windows.Forms.ComboBox();
            this.cmbRoomID = new System.Windows.Forms.ComboBox();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblExtraBedID = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvUI = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUI)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 580);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(926, 44);
            this.panel8.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Manage Bookings";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(935, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 474);
            this.panel4.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.brnNew);
            this.panel7.Controls.Add(this.cmbExtraBedID);
            this.panel7.Controls.Add(this.cmbRoomID);
            this.panel7.Controls.Add(this.cmbUserID);
            this.panel7.Controls.Add(this.cmbStatus);
            this.panel7.Controls.Add(this.dtpCheckOut);
            this.panel7.Controls.Add(this.lblCheckOut);
            this.panel7.Controls.Add(this.dtpBookingDate);
            this.panel7.Controls.Add(this.txtBill);
            this.panel7.Controls.Add(this.lblPass);
            this.panel7.Controls.Add(this.dtpCheckIn);
            this.panel7.Controls.Add(this.txtBookingID);
            this.panel7.Controls.Add(this.lblStatus);
            this.panel7.Controls.Add(this.lblCheckIn);
            this.panel7.Controls.Add(this.lblExtraBedID);
            this.panel7.Controls.Add(this.lblRoomID);
            this.panel7.Controls.Add(this.lblUserID);
            this.panel7.Controls.Add(this.lblBookingDate);
            this.panel7.Controls.Add(this.lblBookingID);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(244, 474);
            this.panel7.TabIndex = 1;
            // 
            // brnNew
            // 
            this.brnNew.Location = new System.Drawing.Point(142, 121);
            this.brnNew.Name = "brnNew";
            this.brnNew.Size = new System.Drawing.Size(57, 20);
            this.brnNew.TabIndex = 24;
            this.brnNew.Text = "New";
            this.brnNew.UseVisualStyleBackColor = true;
            this.brnNew.Click += new System.EventHandler(this.brnNew_Click);
            // 
            // cmbExtraBedID
            // 
            this.cmbExtraBedID.FormattingEnabled = true;
            this.cmbExtraBedID.Location = new System.Drawing.Point(18, 242);
            this.cmbExtraBedID.Name = "cmbExtraBedID";
            this.cmbExtraBedID.Size = new System.Drawing.Size(102, 21);
            this.cmbExtraBedID.TabIndex = 23;
            this.cmbExtraBedID.SelectedIndexChanged += new System.EventHandler(this.cmbExtraBedID_SelectedIndexChanged);
            // 
            // cmbRoomID
            // 
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Location = new System.Drawing.Point(18, 191);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(102, 21);
            this.cmbRoomID.TabIndex = 22;
            this.cmbRoomID.SelectedIndexChanged += new System.EventHandler(this.cmbRoomID_SelectedIndexChanged);
            // 
            // cmbUserID
            // 
            this.cmbUserID.FormattingEnabled = true;
            this.cmbUserID.Location = new System.Drawing.Point(17, 144);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(103, 21);
            this.cmbUserID.TabIndex = 21;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Booked",
            "Paid"});
            this.cmbStatus.Location = new System.Drawing.Point(18, 395);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(102, 21);
            this.cmbStatus.TabIndex = 20;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(17, 343);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOut.TabIndex = 19;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(13, 316);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(86, 19);
            this.lblCheckOut.TabIndex = 18;
            this.lblCheckOut.Text = "Check Out:";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(17, 96);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBookingDate.TabIndex = 17;
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(17, 446);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(103, 20);
            this.txtBill.TabIndex = 16;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(14, 419);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(37, 19);
            this.lblPass.TabIndex = 15;
            this.lblPass.Text = "Bill:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(17, 293);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 13;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(17, 46);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.Size = new System.Drawing.Size(103, 20);
            this.txtBookingID.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(13, 368);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 19);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(13, 266);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(75, 19);
            this.lblCheckIn.TabIndex = 5;
            this.lblCheckIn.Text = "Check In:";
            // 
            // lblExtraBedID
            // 
            this.lblExtraBedID.AutoSize = true;
            this.lblExtraBedID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraBedID.Location = new System.Drawing.Point(13, 216);
            this.lblExtraBedID.Name = "lblExtraBedID";
            this.lblExtraBedID.Size = new System.Drawing.Size(104, 19);
            this.lblExtraBedID.TabIndex = 4;
            this.lblExtraBedID.Text = "Extra Bed ID:";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomID.Location = new System.Drawing.Point(14, 169);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(76, 19);
            this.lblRoomID.TabIndex = 3;
            this.lblRoomID.Text = "Room ID:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(13, 122);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(123, 19);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "Client\'s User ID:";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.Location = new System.Drawing.Point(13, 72);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(107, 19);
            this.lblBookingDate.TabIndex = 1;
            this.lblBookingDate.Text = "Booking Date:";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(13, 19);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(92, 19);
            this.lblBookingID.TabIndex = 0;
            this.lblBookingID.Text = "Booking ID:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(926, 474);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dgvUI);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(926, 474);
            this.panel6.TabIndex = 1;
            // 
            // dgvUI
            // 
            this.dgvUI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(190)))), ((int)(((byte)(196)))));
            this.dgvUI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUI.Location = new System.Drawing.Point(0, 0);
            this.dgvUI.Name = "dgvUI";
            this.dgvUI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUI.Size = new System.Drawing.Size(924, 472);
            this.dgvUI.TabIndex = 0;
            this.dgvUI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUI_CellClick);
            this.dgvUI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUI_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Booking_ID";
            this.Column1.HeaderText = "Booking ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Booking_Date";
            this.Column2.HeaderText = "Booking Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "User_ID";
            this.Column3.HeaderText = "User ID";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Room_ID";
            this.Column4.HeaderText = "Room ID";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "EB_ID";
            this.Column5.HeaderText = "Extra Bed ID";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Check_In";
            this.Column6.HeaderText = "Check In";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Check_Out";
            this.Column7.HeaderText = "Check Out";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Status";
            this.Column8.HeaderText = "Status";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Bill";
            this.Column9.HeaderText = "Bill";
            this.Column9.Name = "Column9";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(935, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 44);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(244, 44);
            this.panel5.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(145, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 31);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(7, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(250, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 31);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(129, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(8, 8);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ManageResevationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 580);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageResevationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "77";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageResevations_FormClosing);
            this.Load += new System.EventHandler(this.ManageResevationsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUI)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblExtraBedID;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbExtraBedID;
        private System.Windows.Forms.ComboBox cmbRoomID;
        private System.Windows.Forms.ComboBox cmbUserID;
        private System.Windows.Forms.Button brnNew;
    }
}