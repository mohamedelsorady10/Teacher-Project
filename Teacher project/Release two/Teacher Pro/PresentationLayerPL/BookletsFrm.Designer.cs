namespace PresentationLayerPL
{
    partial class BookletsFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookletsFrm));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvBooklets = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBooklet = new System.Windows.Forms.TextBox();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.npdPaymentAmount = new System.Windows.Forms.NumericUpDown();
            this.npdPaymentRemainder = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNotPaidBooklet = new System.Windows.Forms.DataGridView();
            this.btnShowALLNotPaidGroupBooket = new System.Windows.Forms.Button();
            this.btnShowALLNotPaidBooket = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooklets)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdPaymentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdPaymentRemainder)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotPaidBooklet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 220;
            this.label2.Text = "Group Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbStudents
            // 
            this.cmbStudents.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(162, 147);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(420, 25);
            this.cmbStudents.TabIndex = 218;
            // 
            // cmbGroups
            // 
            this.cmbGroups.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(162, 99);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(420, 25);
            this.cmbGroups.TabIndex = 217;
            this.cmbGroups.SelectionChangeCommitted += new System.EventHandler(this.cmbGroups_SelectionChangeCommitted);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(964, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlSave
            // 
            this.pnlSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlSave.Location = new System.Drawing.Point(145, 383);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(5, 35);
            this.pnlSave.TabIndex = 207;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnShowAll.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAll.Image")));
            this.btnShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.Location = new System.Drawing.Point(465, 383);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(95, 35);
            this.btnShowAll.TabIndex = 203;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(349, 383);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 35);
            this.btnUpdate.TabIndex = 204;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(19, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 17);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Booklets";
            // 
            // dgvBooklets
            // 
            this.dgvBooklets.AllowUserToAddRows = false;
            this.dgvBooklets.AllowUserToDeleteRows = false;
            this.dgvBooklets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooklets.Location = new System.Drawing.Point(22, 432);
            this.dgvBooklets.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBooklets.Name = "dgvBooklets";
            this.dgvBooklets.ReadOnly = true;
            this.dgvBooklets.Size = new System.Drawing.Size(966, 254);
            this.dgvBooklets.TabIndex = 213;
            this.dgvBooklets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooklets_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(53, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 35);
            this.panel1.TabIndex = 212;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(53, 383);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(70, 35);
            this.btnNew.TabIndex = 211;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlDelete
            // 
            this.pnlDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlDelete.Location = new System.Drawing.Point(240, 383);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(5, 35);
            this.pnlDelete.TabIndex = 208;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(240, 383);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 35);
            this.btnDelete.TabIndex = 205;
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
            this.btnSave.Location = new System.Drawing.Point(145, 383);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 35);
            this.btnSave.TabIndex = 206;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblBasicSalary.Location = new System.Drawing.Point(21, 194);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(101, 17);
            this.lblBasicSalary.TabIndex = 202;
            this.lblBasicSalary.Text = "Payment Date";
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblGroupName.Location = new System.Drawing.Point(21, 149);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(101, 17);
            this.lblGroupName.TabIndex = 201;
            this.lblGroupName.Text = "Student Name";
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
            this.pnlTitle.Size = new System.Drawing.Size(1010, 34);
            this.pnlTitle.TabIndex = 200;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(349, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 35);
            this.panel2.TabIndex = 209;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(465, 383);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 35);
            this.panel3.TabIndex = 221;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 220;
            this.label1.Text = "Booklet Name";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBooklet
            // 
            this.txtBooklet.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBooklet.Location = new System.Drawing.Point(162, 59);
            this.txtBooklet.Name = "txtBooklet";
            this.txtBooklet.Size = new System.Drawing.Size(420, 23);
            this.txtBooklet.TabIndex = 223;
            this.txtBooklet.Leave += new System.EventHandler(this.txtBooklet_Leave);
            // 
            // dpDate
            // 
            this.dpDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dpDate.Location = new System.Drawing.Point(161, 190);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(421, 23);
            this.dpDate.TabIndex = 224;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(21, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 202;
            this.label3.Text = "Payment Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(20, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 202;
            this.label4.Text = "Payment Remainder\r\n";
            // 
            // npdPaymentAmount
            // 
            this.npdPaymentAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.npdPaymentAmount.Location = new System.Drawing.Point(162, 233);
            this.npdPaymentAmount.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.npdPaymentAmount.Name = "npdPaymentAmount";
            this.npdPaymentAmount.Size = new System.Drawing.Size(420, 23);
            this.npdPaymentAmount.TabIndex = 225;
            // 
            // npdPaymentRemainder
            // 
            this.npdPaymentRemainder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.npdPaymentRemainder.Location = new System.Drawing.Point(162, 271);
            this.npdPaymentRemainder.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.npdPaymentRemainder.Name = "npdPaymentRemainder";
            this.npdPaymentRemainder.Size = new System.Drawing.Size(420, 23);
            this.npdPaymentRemainder.TabIndex = 225;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNotPaidBooklet);
            this.groupBox1.Controls.Add(this.btnShowALLNotPaidGroupBooket);
            this.groupBox1.Controls.Add(this.btnShowALLNotPaidBooket);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(598, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 369);
            this.groupBox1.TabIndex = 284;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Not Paid Bookets";
            // 
            // dgvNotPaidBooklet
            // 
            this.dgvNotPaidBooklet.AllowUserToAddRows = false;
            this.dgvNotPaidBooklet.AllowUserToDeleteRows = false;
            this.dgvNotPaidBooklet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotPaidBooklet.Location = new System.Drawing.Point(6, 68);
            this.dgvNotPaidBooklet.Name = "dgvNotPaidBooklet";
            this.dgvNotPaidBooklet.ReadOnly = true;
            this.dgvNotPaidBooklet.Size = new System.Drawing.Size(378, 284);
            this.dgvNotPaidBooklet.TabIndex = 204;
            // 
            // btnShowALLNotPaidGroupBooket
            // 
            this.btnShowALLNotPaidGroupBooket.BackColor = System.Drawing.Color.Transparent;
            this.btnShowALLNotPaidGroupBooket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowALLNotPaidGroupBooket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowALLNotPaidGroupBooket.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnShowALLNotPaidGroupBooket.Image = ((System.Drawing.Image)(resources.GetObject("btnShowALLNotPaidGroupBooket.Image")));
            this.btnShowALLNotPaidGroupBooket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowALLNotPaidGroupBooket.Location = new System.Drawing.Point(189, 20);
            this.btnShowALLNotPaidGroupBooket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowALLNotPaidGroupBooket.Name = "btnShowALLNotPaidGroupBooket";
            this.btnShowALLNotPaidGroupBooket.Size = new System.Drawing.Size(191, 35);
            this.btnShowALLNotPaidGroupBooket.TabIndex = 203;
            this.btnShowALLNotPaidGroupBooket.Text = "Show All by Group";
            this.btnShowALLNotPaidGroupBooket.UseVisualStyleBackColor = false;
            this.btnShowALLNotPaidGroupBooket.Click += new System.EventHandler(this.btnShowALLNotPaidGroupBooket_Click);
            // 
            // btnShowALLNotPaidBooket
            // 
            this.btnShowALLNotPaidBooket.BackColor = System.Drawing.Color.Transparent;
            this.btnShowALLNotPaidBooket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowALLNotPaidBooket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowALLNotPaidBooket.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnShowALLNotPaidBooket.Image = ((System.Drawing.Image)(resources.GetObject("btnShowALLNotPaidBooket.Image")));
            this.btnShowALLNotPaidBooket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowALLNotPaidBooket.Location = new System.Drawing.Point(8, 20);
            this.btnShowALLNotPaidBooket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowALLNotPaidBooket.Name = "btnShowALLNotPaidBooket";
            this.btnShowALLNotPaidBooket.Size = new System.Drawing.Size(175, 35);
            this.btnShowALLNotPaidBooket.TabIndex = 203;
            this.btnShowALLNotPaidBooket.Text = "Show All Monthly";
            this.btnShowALLNotPaidBooket.UseVisualStyleBackColor = false;
            this.btnShowALLNotPaidBooket.Click += new System.EventHandler(this.btnShowALLNotPaidBooket_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BookletsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 695);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.npdPaymentRemainder);
            this.Controls.Add(this.npdPaymentAmount);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.txtBooklet);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.pnlSave);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvBooklets);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBasicSalary);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookletsFrm";
            this.Text = "Booklets";
            this.Load += new System.EventHandler(this.BookletsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooklets)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdPaymentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdPaymentRemainder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotPaidBooklet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBooklets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBasicSalary;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBooklet;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown npdPaymentAmount;
        private System.Windows.Forms.NumericUpDown npdPaymentRemainder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNotPaidBooklet;
        private System.Windows.Forms.Button btnShowALLNotPaidGroupBooket;
        private System.Windows.Forms.Button btnShowALLNotPaidBooket;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}