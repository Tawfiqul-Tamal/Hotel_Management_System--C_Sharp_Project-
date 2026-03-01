namespace HotelManagement
{
    partial class ClientBookingForm
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
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbExtraBedId = new System.Windows.Forms.ComboBox();
            this.cmbRoomId = new System.Windows.Forms.ComboBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblExtraBedId = new System.Windows.Forms.Label();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBooking.Location = new System.Drawing.Point(7, 7);
            this.btnNewBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(147, 35);
            this.btnNewBooking.TabIndex = 0;
            this.btnNewBooking.Text = "New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = true;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(4, 4);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(79, 17);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "lblWelcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvData, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.32684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.67316F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1289, 510);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1030, 43);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(257, 49);
            this.panel5.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(23, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(164, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1030, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 37);
            this.panel4.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 37);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client Booking Form";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnNewBooking);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 49);
            this.panel1.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(169, 7);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 35);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Booking";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(334, 7);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 35);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(2, 96);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1024, 412);
            this.dgvData.TabIndex = 6;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Booking_ID";
            this.Column1.HeaderText = "Booking ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Booking_Date";
            this.Column2.HeaderText = "Booking Date";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Room_ID";
            this.Column3.HeaderText = "Room ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "EB_ID";
            this.Column4.HeaderText = "Extra Bed ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Check_In";
            this.Column5.HeaderText = "Check In";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Check_Out";
            this.Column6.HeaderText = "Check Out";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Bill";
            this.Column7.HeaderText = "Bill";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbExtraBedId);
            this.panel3.Controls.Add(this.cmbRoomId);
            this.panel3.Controls.Add(this.dtpCheckOut);
            this.panel3.Controls.Add(this.dtpCheckIn);
            this.panel3.Controls.Add(this.dtpBookingDate);
            this.panel3.Controls.Add(this.txtBill);
            this.panel3.Controls.Add(this.lblBill);
            this.panel3.Controls.Add(this.txtBookingId);
            this.panel3.Controls.Add(this.lblCheckOut);
            this.panel3.Controls.Add(this.lblCheckIn);
            this.panel3.Controls.Add(this.lblExtraBedId);
            this.panel3.Controls.Add(this.lblRoomId);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblBookingId);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1030, 96);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 412);
            this.panel3.TabIndex = 8;
            // 
            // cmbExtraBedId
            // 
            this.cmbExtraBedId.FormattingEnabled = true;
            this.cmbExtraBedId.Location = new System.Drawing.Point(23, 193);
            this.cmbExtraBedId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbExtraBedId.Name = "cmbExtraBedId";
            this.cmbExtraBedId.Size = new System.Drawing.Size(205, 21);
            this.cmbExtraBedId.TabIndex = 43;
            this.cmbExtraBedId.SelectedIndexChanged += new System.EventHandler(this.cmbExtraBedId_SelectedIndexChanged);
            // 
            // cmbRoomId
            // 
            this.cmbRoomId.FormattingEnabled = true;
            this.cmbRoomId.Location = new System.Drawing.Point(23, 141);
            this.cmbRoomId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRoomId.Name = "cmbRoomId";
            this.cmbRoomId.Size = new System.Drawing.Size(208, 21);
            this.cmbRoomId.TabIndex = 42;
            this.cmbRoomId.SelectedIndexChanged += new System.EventHandler(this.cmbRoomId_SelectedIndexChanged);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(23, 299);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(208, 20);
            this.dtpCheckOut.TabIndex = 41;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(23, 243);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(208, 20);
            this.dtpCheckIn.TabIndex = 40;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(23, 92);
            this.dtpBookingDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(208, 20);
            this.dtpBookingDate.TabIndex = 39;
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(23, 355);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(208, 20);
            this.txtBill.TabIndex = 33;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(23, 333);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(37, 19);
            this.lblBill.TabIndex = 32;
            this.lblBill.Text = "Bill:";
            // 
            // txtBookingId
            // 
            this.txtBookingId.BackColor = System.Drawing.SystemColors.Window;
            this.txtBookingId.Location = new System.Drawing.Point(23, 41);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.ReadOnly = true;
            this.txtBookingId.Size = new System.Drawing.Size(208, 20);
            this.txtBookingId.TabIndex = 19;
            this.txtBookingId.Text = "Auto Generated";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(23, 279);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(86, 19);
            this.lblCheckOut.TabIndex = 23;
            this.lblCheckOut.Text = "Check Out:";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(23, 223);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(75, 19);
            this.lblCheckIn.TabIndex = 22;
            this.lblCheckIn.Text = "Check In:";
            // 
            // lblExtraBedId
            // 
            this.lblExtraBedId.AutoSize = true;
            this.lblExtraBedId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraBedId.Location = new System.Drawing.Point(23, 172);
            this.lblExtraBedId.Name = "lblExtraBedId";
            this.lblExtraBedId.Size = new System.Drawing.Size(104, 19);
            this.lblExtraBedId.TabIndex = 21;
            this.lblExtraBedId.Text = "Extra Bed ID:";
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomId.Location = new System.Drawing.Point(23, 121);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(76, 19);
            this.lblRoomId.TabIndex = 20;
            this.lblRoomId.Text = "Room ID:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(23, 72);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(107, 19);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Booking Date:";
            // 
            // lblBookingId
            // 
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingId.Location = new System.Drawing.Point(23, 20);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(92, 19);
            this.lblBookingId.TabIndex = 17;
            this.lblBookingId.Text = "Booking ID:";
            // 
            // ClientBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1289, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientBookingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientHomeForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientHomeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblExtraBedId;
        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblBookingId;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.ComboBox cmbExtraBedId;
        private System.Windows.Forms.ComboBox cmbRoomId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}