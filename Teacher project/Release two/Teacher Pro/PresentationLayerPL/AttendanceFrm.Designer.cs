namespace PresentationLayerPL
{
    partial class AttendanceFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceFrm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.pnlTitle = new System.Windows.Forms.Panel();
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPickerDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.btnShowALLAbsenceGroup = new System.Windows.Forms.Button();
            this.btnShowALLAbsence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(19, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 17);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Attendance";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1077, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(22, 286);
            this.dgvAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.Size = new System.Drawing.Size(1082, 381);
            this.dgvAttendance.TabIndex = 173;
            this.dgvAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellClick);
            this.dgvAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellContentClick);
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
            this.pnlTitle.Size = new System.Drawing.Size(1122, 34);
            this.pnlTitle.TabIndex = 172;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(61, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 35);
            this.panel1.TabIndex = 170;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(61, 243);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(70, 35);
            this.btnNew.TabIndex = 169;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlShowAll
            // 
            this.pnlShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlShowAll.Location = new System.Drawing.Point(453, 243);
            this.pnlShowAll.Name = "pnlShowAll";
            this.pnlShowAll.Size = new System.Drawing.Size(5, 35);
            this.pnlShowAll.TabIndex = 168;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlUpdate.Location = new System.Drawing.Point(348, 243);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(5, 35);
            this.pnlUpdate.TabIndex = 167;
            // 
            // pnlDelete
            // 
            this.pnlDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlDelete.Location = new System.Drawing.Point(248, 243);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(5, 35);
            this.pnlDelete.TabIndex = 166;
            // 
            // pnlSave
            // 
            this.pnlSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlSave.Location = new System.Drawing.Point(153, 243);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(5, 35);
            this.pnlSave.TabIndex = 165;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAll.Image")));
            this.btnShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.Location = new System.Drawing.Point(453, 243);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(95, 35);
            this.btnShowAll.TabIndex = 161;
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
            this.btnUpdate.Location = new System.Drawing.Point(348, 243);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 35);
            this.btnUpdate.TabIndex = 162;
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
            this.btnDelete.Location = new System.Drawing.Point(248, 243);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 35);
            this.btnDelete.TabIndex = 163;
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
            this.btnSave.Location = new System.Drawing.Point(153, 243);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 35);
            this.btnSave.TabIndex = 164;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 201;
            this.label2.Text = "Group";
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(148, 54);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(491, 25);
            this.cmbGroups.TabIndex = 200;
            this.cmbGroups.SelectionChangeCommitted += new System.EventHandler(this.cmbGroups_SelectionChangeCommitted);
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(148, 95);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(491, 25);
            this.cmbStudents.TabIndex = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 203;
            this.label1.Text = "Student";
            // 
            // dtPickerDate
            // 
            this.dtPickerDate.Location = new System.Drawing.Point(148, 145);
            this.dtPickerDate.Name = "dtPickerDate";
            this.dtPickerDate.Size = new System.Drawing.Size(491, 23);
            this.dtPickerDate.TabIndex = 204;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 205;
            this.label3.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAbsence);
            this.groupBox1.Controls.Add(this.btnShowALLAbsenceGroup);
            this.groupBox1.Controls.Add(this.btnShowALLAbsence);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(645, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 237);
            this.groupBox1.TabIndex = 230;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Absence Monthly";
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.AllowUserToAddRows = false;
            this.dgvAbsence.AllowUserToDeleteRows = false;
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(6, 68);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.ReadOnly = true;
            this.dgvAbsence.Size = new System.Drawing.Size(453, 163);
            this.dgvAbsence.TabIndex = 204;
            // 
            // btnShowALLAbsenceGroup
            // 
            this.btnShowALLAbsenceGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnShowALLAbsenceGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowALLAbsenceGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowALLAbsenceGroup.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnShowALLAbsenceGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnShowALLAbsenceGroup.Image")));
            this.btnShowALLAbsenceGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowALLAbsenceGroup.Location = new System.Drawing.Point(268, 20);
            this.btnShowALLAbsenceGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowALLAbsenceGroup.Name = "btnShowALLAbsenceGroup";
            this.btnShowALLAbsenceGroup.Size = new System.Drawing.Size(191, 35);
            this.btnShowALLAbsenceGroup.TabIndex = 203;
            this.btnShowALLAbsenceGroup.Text = "Show All by Group";
            this.btnShowALLAbsenceGroup.UseVisualStyleBackColor = false;
            this.btnShowALLAbsenceGroup.Click += new System.EventHandler(this.btnShowALLAbsenceGroup_Click);
            // 
            // btnShowALLAbsence
            // 
            this.btnShowALLAbsence.BackColor = System.Drawing.Color.Transparent;
            this.btnShowALLAbsence.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowALLAbsence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowALLAbsence.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnShowALLAbsence.Image = ((System.Drawing.Image)(resources.GetObject("btnShowALLAbsence.Image")));
            this.btnShowALLAbsence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowALLAbsence.Location = new System.Drawing.Point(8, 20);
            this.btnShowALLAbsence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowALLAbsence.Name = "btnShowALLAbsence";
            this.btnShowALLAbsence.Size = new System.Drawing.Size(151, 35);
            this.btnShowALLAbsence.TabIndex = 203;
            this.btnShowALLAbsence.Text = "Show All";
            this.btnShowALLAbsence.UseVisualStyleBackColor = false;
            this.btnShowALLAbsence.Click += new System.EventHandler(this.btnShowALLAbsence_Click);
            // 
            // AttendanceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 680);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPickerDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.pnlTitle);
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
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AttendanceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceFrm";
            this.Load += new System.EventHandler(this.AttendanceFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel pnlTitle;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPickerDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.Button btnShowALLAbsenceGroup;
        private System.Windows.Forms.Button btnShowALLAbsence;
    }
}