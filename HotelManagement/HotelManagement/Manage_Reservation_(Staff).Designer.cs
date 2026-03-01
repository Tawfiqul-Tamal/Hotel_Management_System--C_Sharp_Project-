namespace HotelManagement
{
    partial class Manage_Reservation__Staff_
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbEBID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRID = new System.Windows.Forms.ComboBox();
            this.cmbGuestID = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRID = new System.Windows.Forms.Label();
            this.lblBID = new System.Windows.Forms.Label();
            this.dgvMR = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMR)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRef);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnRef
            // 
            this.btnRef.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRef.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef.Location = new System.Drawing.Point(261, 2);
            this.btnRef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(109, 41);
            this.btnRef.TabIndex = 2;
            this.btnRef.Text = "Refresh";
            this.btnRef.UseVisualStyleBackColor = false;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            this.btnRef.MouseLeave += new System.EventHandler(this.btnRef_MouseLeave);
            this.btnRef.MouseHover += new System.EventHandler(this.btnRef_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(132, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(8, 2);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 41);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseLeave += new System.EventHandler(this.btnNew_MouseLeave);
            this.btnNew.MouseHover += new System.EventHandler(this.btnNew_MouseHover);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(269, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 41);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // cmbEBID
            // 
            this.cmbEBID.FormattingEnabled = true;
            this.cmbEBID.Location = new System.Drawing.Point(183, 220);
            this.cmbEBID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEBID.Name = "cmbEBID";
            this.cmbEBID.Size = new System.Drawing.Size(253, 24);
            this.cmbEBID.TabIndex = 22;
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Extra Bed ID";
            // 
            // dtpBD
            // 
            this.dtpBD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBD.Location = new System.Drawing.Point(183, 95);
            this.dtpBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(253, 22);
            this.dtpBD.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Booking Date";
            // 
            // cmbRID
            // 
            this.cmbRID.FormattingEnabled = true;
            this.cmbRID.Location = new System.Drawing.Point(183, 182);
            this.cmbRID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRID.Name = "cmbRID";
            this.cmbRID.Size = new System.Drawing.Size(253, 24);
            this.cmbRID.TabIndex = 18;
            
            // 
            // cmbGuestID
            // 
            this.cmbGuestID.FormattingEnabled = true;
            this.cmbGuestID.Location = new System.Drawing.Point(183, 133);
            this.cmbGuestID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGuestID.Name = "cmbGuestID";
            this.cmbGuestID.Size = new System.Drawing.Size(253, 24);
            this.cmbGuestID.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1255, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 56);
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
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestID.Location = new System.Drawing.Point(29, 137);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(87, 23);
            this.lblGuestID.TabIndex = 16;
            this.lblGuestID.Text = "Guest ID";
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(183, 395);
            this.txtBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBill.Name = "txtBill";
            this.txtBill.ReadOnly = true;
            this.txtBill.Size = new System.Drawing.Size(253, 22);
            this.txtBill.TabIndex = 15;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "Booked"});
            this.cmbStatus.Location = new System.Drawing.Point(183, 350);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(253, 24);
            this.cmbStatus.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bill";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Status";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Location = new System.Drawing.Point(183, 306);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(253, 22);
            this.dtpCheckOut.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Check Out Date";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Location = new System.Drawing.Point(183, 258);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(253, 22);
            this.dtpCheckIn.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Check In Date";
            // 
            // lblRID
            // 
            this.lblRID.AutoSize = true;
            this.lblRID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRID.Location = new System.Drawing.Point(29, 186);
            this.lblRID.Name = "lblRID";
            this.lblRID.Size = new System.Drawing.Size(85, 23);
            this.lblRID.TabIndex = 4;
            this.lblRID.Text = "Room ID";
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBID.Location = new System.Drawing.Point(29, 53);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(105, 23);
            this.lblBID.TabIndex = 1;
            this.lblBID.Text = "Booking ID";
            // 
            // dgvMR
            // 
            this.dgvMR.AllowUserToAddRows = false;
            this.dgvMR.AllowUserToDeleteRows = false;
            this.dgvMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column9,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMR.Location = new System.Drawing.Point(0, 0);
            this.dgvMR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMR.Name = "dgvMR";
            this.dgvMR.ReadOnly = true;
            this.dgvMR.RowHeadersWidth = 51;
            this.dgvMR.RowTemplate.Height = 24;
            this.dgvMR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMR.Size = new System.Drawing.Size(1244, 525);
            this.dgvMR.TabIndex = 0;
            this.dgvMR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMR_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Booking_ID";
            this.Column1.HeaderText = "Booking ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Booking_Date";
            this.Column8.HeaderText = "Booking Date";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "User_ID";
            this.Column2.HeaderText = "Guest ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Room_ID";
            this.Column3.HeaderText = "Room ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "EB_ID";
            this.Column9.HeaderText = "Extra Bed ID";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Check_In";
            this.Column4.HeaderText = "Check In Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Check_Out";
            this.Column5.HeaderText = "Check Out Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Status";
            this.Column6.HeaderText = "Status";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Bill";
            this.Column7.HeaderText = "Bill";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvMR);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1246, 527);
            this.panel3.TabIndex = 2;
            // 
            // txtBID
            // 
            this.txtBID.Location = new System.Drawing.Point(183, 50);
            this.txtBID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBID.Name = "txtBID";
            this.txtBID.ReadOnly = true;
            this.txtBID.Size = new System.Drawing.Size(253, 22);
            this.txtBID.TabIndex = 0;
            this.txtBID.Text = "Auto Generated";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbEBID);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.dtpBD);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cmbRID);
            this.panel4.Controls.Add(this.cmbGuestID);
            this.panel4.Controls.Add(this.lblGuestID);
            this.panel4.Controls.Add(this.txtBill);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cmbStatus);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dtpCheckOut);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dtpCheckIn);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblRID);
            this.panel4.Controls.Add(this.lblBID);
            this.panel4.Controls.Add(this.txtBID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1255, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(467, 527);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 473F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1725, 591);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Manage_Reservation__Staff_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1725, 591);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Manage_Reservation__Staff_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Reservation (Staff)";
            this.Load += new System.EventHandler(this.Manage_Reservation__Staff__Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMR)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbEBID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRID;
        private System.Windows.Forms.ComboBox cmbGuestID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRID;
        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.DataGridView dgvMR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}