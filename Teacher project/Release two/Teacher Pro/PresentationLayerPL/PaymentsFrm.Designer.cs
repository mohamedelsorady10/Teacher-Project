namespace PresentationLayerPL
{
    partial class PaymentsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsFrm));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNotPaid = new System.Windows.Forms.DataGridView();
            this.btnShowALLNotPaidGroup = new System.Windows.Forms.Button();
            this.btnShowALLNotPaid = new System.Windows.Forms.Button();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.npdRemainder = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.npdAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPickerDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnShowAllByGroup = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.btnShowAllByMonth = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdRemainder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1082, 34);
            this.pnlTitle.TabIndex = 200;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(19, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 17);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Paymets";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1036, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(883, 297);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 35);
            this.panel5.TabIndex = 287;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(709, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 35);
            this.panel4.TabIndex = 286;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(539, 297);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 35);
            this.panel3.TabIndex = 285;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(340, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 35);
            this.panel2.TabIndex = 284;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNotPaid);
            this.groupBox1.Controls.Add(this.btnShowALLNotPaidGroup);
            this.groupBox1.Controls.Add(this.btnShowALLNotPaid);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(662, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 224);
            this.groupBox1.TabIndex = 283;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Not Paid Monthly";
            // 
            // dgvNotPaid
            // 
            this.dgvNotPaid.AllowUserToAddRows = false;
            this.dgvNotPaid.AllowUserToDeleteRows = false;
            this.dgvNotPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotPaid.Location = new System.Drawing.Point(6, 68);
            this.dgvNotPaid.Name = "dgvNotPaid";
            this.dgvNotPaid.ReadOnly = true;
            this.dgvNotPaid.Size = new System.Drawing.Size(378, 150);
            this.dgvNotPaid.TabIndex = 204;
            // 
            // btnShowALLNotPaidGroup
            // 
            this.btnShowALLNotPaidGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnShowALLNotPaidGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowALLNotPaidGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowALLNotPaidGroup.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnShowALLNotPaidGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnShowALLNotPaidGroup.Image")));
            this.btnShowALLNotPaidGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowALLNotPaidGroup.Location = new System.Drawing.Point(189, 20);
            this.btnShowALLNotPaidGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowALLNotPaidGroup.Name = "btnShowALLNotPaidGroup";
            this.btnShowALLNotPaidGroup.Size = new System.Drawing.Size(191, 35);
            this.btnShowALLNotPaidGroup.TabIndex = 203;
            this.btnShowALLNotPaidGroup.Text = "Show All by Group";
            this.btnShowALLNotPaidGroup.UseVisualStyleBackColor = false;
            this.btnShowALLNotPaidGroup.Click += new System.EventHandler(this.btnShowALLNotPaidGroup_Click);
            // 
            // btnShowALLNotPaid
            // 
            this.btnShowALLNotPaid.BackColor = System.Drawing.Color.Transparent;
            this.btnShowALLNotPaid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowALLNotPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowALLNotPaid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnShowALLNotPaid.Image = ((System.Drawing.Image)(resources.GetObject("btnShowALLNotPaid.Image")));
            this.btnShowALLNotPaid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowALLNotPaid.Location = new System.Drawing.Point(8, 20);
            this.btnShowALLNotPaid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowALLNotPaid.Name = "btnShowALLNotPaid";
            this.btnShowALLNotPaid.Size = new System.Drawing.Size(162, 35);
            this.btnShowALLNotPaid.TabIndex = 203;
            this.btnShowALLNotPaid.Text = "Show All";
            this.btnShowALLNotPaid.UseVisualStyleBackColor = false;
            this.btnShowALLNotPaid.Click += new System.EventHandler(this.btnShowALLNotPaid_Click);
            // 
            // cmbStudents
            // 
            this.cmbStudents.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(159, 92);
            this.cmbStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(491, 25);
            this.cmbStudents.TabIndex = 282;
            // 
            // npdRemainder
            // 
            this.npdRemainder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.npdRemainder.Location = new System.Drawing.Point(159, 215);
            this.npdRemainder.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.npdRemainder.Name = "npdRemainder";
            this.npdRemainder.Size = new System.Drawing.Size(491, 23);
            this.npdRemainder.TabIndex = 281;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(39, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 280;
            this.label4.Text = "Remainder";
            // 
            // npdAmount
            // 
            this.npdAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.npdAmount.Location = new System.Drawing.Point(159, 177);
            this.npdAmount.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.npdAmount.Name = "npdAmount";
            this.npdAmount.Size = new System.Drawing.Size(491, 23);
            this.npdAmount.TabIndex = 279;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(39, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 278;
            this.label1.Text = "Amount of Paid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(39, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 277;
            this.label3.Text = "Date";
            // 
            // dtPickerDate
            // 
            this.dtPickerDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtPickerDate.Location = new System.Drawing.Point(159, 136);
            this.dtPickerDate.Name = "dtPickerDate";
            this.dtPickerDate.Size = new System.Drawing.Size(491, 23);
            this.dtPickerDate.TabIndex = 276;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 275;
            this.label2.Text = "Group";
            // 
            // cmbGroups
            // 
            this.cmbGroups.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(159, 51);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(491, 25);
            this.cmbGroups.TabIndex = 274;
            this.cmbGroups.SelectionChangeCommitted += new System.EventHandler(this.cmbGroups_SelectionChangeCommitted);
            // 
            // pnlSave
            // 
            this.pnlSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlSave.Location = new System.Drawing.Point(154, 296);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(5, 35);
            this.pnlSave.TabIndex = 268;
            // 
            // btnShowAllByGroup
            // 
            this.btnShowAllByGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAllByGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowAllByGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllByGroup.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnShowAllByGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAllByGroup.Image")));
            this.btnShowAllByGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllByGroup.Location = new System.Drawing.Point(709, 296);
            this.btnShowAllByGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAllByGroup.Name = "btnShowAllByGroup";
            this.btnShowAllByGroup.Size = new System.Drawing.Size(168, 35);
            this.btnShowAllByGroup.TabIndex = 264;
            this.btnShowAllByGroup.Text = "Show All by Group";
            this.btnShowAllByGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAllByGroup.UseVisualStyleBackColor = false;
            this.btnShowAllByGroup.Click += new System.EventHandler(this.btnShowAllByGroup_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.BackColor = System.Drawing.Color.Transparent;
            this.ShowAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAll.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ShowAll.Image = ((System.Drawing.Image)(resources.GetObject("ShowAll.Image")));
            this.ShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowAll.Location = new System.Drawing.Point(883, 296);
            this.ShowAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(159, 35);
            this.ShowAll.TabIndex = 263;
            this.ShowAll.Text = "Show All history";
            this.ShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowAll.UseVisualStyleBackColor = false;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // btnShowAllByMonth
            // 
            this.btnShowAllByMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAllByMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowAllByMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllByMonth.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnShowAllByMonth.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAllByMonth.Image")));
            this.btnShowAllByMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllByMonth.Location = new System.Drawing.Point(539, 297);
            this.btnShowAllByMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAllByMonth.Name = "btnShowAllByMonth";
            this.btnShowAllByMonth.Size = new System.Drawing.Size(164, 35);
            this.btnShowAllByMonth.TabIndex = 262;
            this.btnShowAllByMonth.Text = "Show All by Month";
            this.btnShowAllByMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAllByMonth.UseVisualStyleBackColor = false;
            this.btnShowAllByMonth.Click += new System.EventHandler(this.btnShowAllByMonth_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(340, 296);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 35);
            this.btnUpdate.TabIndex = 265;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Location = new System.Drawing.Point(30, 339);
            this.dgvPayment.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.Size = new System.Drawing.Size(1012, 319);
            this.dgvPayment.TabIndex = 273;
            this.dgvPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellClick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(61, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 35);
            this.panel1.TabIndex = 272;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(62, 296);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(70, 35);
            this.btnNew.TabIndex = 271;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.pnlUpdate.Location = new System.Drawing.Point(340, 296);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(5, 35);
            this.pnlUpdate.TabIndex = 270;
            // 
            // pnlDelete
            // 
            this.pnlDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlDelete.Location = new System.Drawing.Point(249, 296);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(5, 35);
            this.pnlDelete.TabIndex = 269;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(249, 296);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 35);
            this.btnDelete.TabIndex = 266;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(154, 296);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 35);
            this.btnSave.TabIndex = 267;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblGroupName.Location = new System.Drawing.Point(38, 93);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(101, 17);
            this.lblGroupName.TabIndex = 261;
            this.lblGroupName.Text = "Student Name";
            // 
            // PaymentsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 709);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.npdRemainder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.npdAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPickerDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.pnlSave);
            this.Controls.Add(this.btnShowAllByGroup);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.btnShowAllByMonth);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentsFrm";
            this.Load += new System.EventHandler(this.PaymentsFrm_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdRemainder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNotPaid;
        private System.Windows.Forms.Button btnShowALLNotPaidGroup;
        private System.Windows.Forms.Button btnShowALLNotPaid;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.NumericUpDown npdRemainder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown npdAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPickerDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnShowAllByGroup;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button btnShowAllByMonth;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGroupName;
    }
}