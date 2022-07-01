namespace PresentationLayerPL
{
    partial class StudentsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsFrm));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtParentMobile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlShowAll = new System.Windows.Forms.Panel();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStudentMobile = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.pnlTitle.Size = new System.Drawing.Size(955, 34);
            this.pnlTitle.TabIndex = 62;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(19, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 17);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Students";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(908, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(22, 332);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(901, 326);
            this.dgvStudents.TabIndex = 61;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 141;
            this.label3.Text = "Group";
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(656, 224);
            this.cmbGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(263, 25);
            this.cmbGroups.TabIndex = 140;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Enabled = false;
            this.txtNotes.Location = new System.Drawing.Point(656, 169);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(263, 23);
            this.txtNotes.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 138;
            this.label5.Text = "Notes";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(656, 119);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(263, 23);
            this.txtAddress.TabIndex = 137;
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // txtParentMobile
            // 
            this.txtParentMobile.Enabled = false;
            this.txtParentMobile.Location = new System.Drawing.Point(200, 224);
            this.txtParentMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParentMobile.Name = "txtParentMobile";
            this.txtParentMobile.Size = new System.Drawing.Size(260, 23);
            this.txtParentMobile.TabIndex = 136;
            this.txtParentMobile.Leave += new System.EventHandler(this.txtParentMobile_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 135;
            this.label1.Text = "Student Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 134;
            this.label4.Text = "Parent Mobile";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(91, 278);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 42);
            this.panel1.TabIndex = 133;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(91, 278);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(93, 42);
            this.btnNew.TabIndex = 132;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlShowAll
            // 
            this.pnlShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlShowAll.Location = new System.Drawing.Point(614, 278);
            this.pnlShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.pnlShowAll.Name = "pnlShowAll";
            this.pnlShowAll.Size = new System.Drawing.Size(7, 42);
            this.pnlShowAll.TabIndex = 131;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlUpdate.Location = new System.Drawing.Point(474, 278);
            this.pnlUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(7, 42);
            this.pnlUpdate.TabIndex = 130;
            // 
            // pnlDelete
            // 
            this.pnlDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlDelete.Location = new System.Drawing.Point(340, 278);
            this.pnlDelete.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(7, 42);
            this.pnlDelete.TabIndex = 129;
            // 
            // pnlSave
            // 
            this.pnlSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlSave.Location = new System.Drawing.Point(214, 278);
            this.pnlSave.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(7, 42);
            this.pnlSave.TabIndex = 128;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAll.Image")));
            this.btnShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.Location = new System.Drawing.Point(614, 278);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(127, 42);
            this.btnShowAll.TabIndex = 124;
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
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(474, 278);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 42);
            this.btnUpdate.TabIndex = 125;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(340, 278);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 42);
            this.btnDelete.TabIndex = 126;
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
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(214, 278);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 42);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStudentMobile
            // 
            this.txtStudentMobile.Enabled = false;
            this.txtStudentMobile.Location = new System.Drawing.Point(200, 170);
            this.txtStudentMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentMobile.Name = "txtStudentMobile";
            this.txtStudentMobile.Size = new System.Drawing.Size(260, 23);
            this.txtStudentMobile.TabIndex = 123;
            this.txtStudentMobile.Leave += new System.EventHandler(this.txtStudentMobile_Leave);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Location = new System.Drawing.Point(200, 119);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(260, 23);
            this.txtStudentName.TabIndex = 122;
            this.txtStudentName.Leave += new System.EventHandler(this.txtStudentName_Leave);
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Location = new System.Drawing.Point(37, 171);
            this.lblBasicSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(104, 17);
            this.lblBasicSalary.TabIndex = 121;
            this.lblBasicSalary.Text = "Student Mobile";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(35, 123);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(105, 17);
            this.lblEmployeeName.TabIndex = 120;
            this.lblEmployeeName.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 142;
            this.label2.Text = "Search by";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Student Name",
            "Student Mobile",
            "Group Name"});
            this.cmbSearchBy.Location = new System.Drawing.Point(90, 22);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(245, 25);
            this.cmbSearchBy.TabIndex = 143;
            this.cmbSearchBy.SelectionChangeCommitted += new System.EventHandler(this.cmbSearchBy_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbSearchBy);
            this.groupBox1.Location = new System.Drawing.Point(22, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 70);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(611, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 145;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(341, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 23);
            this.txtSearch.TabIndex = 144;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StudentsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 671);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtParentMobile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pnlShowAll);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.pnlSave);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStudentMobile);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblBasicSalary);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.dgvStudents);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentsFrm";
            this.Load += new System.EventHandler(this.StudentsFrm_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtParentMobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlShowAll;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStudentMobile;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblBasicSalary;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}