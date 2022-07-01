namespace PresentationLayerPL
{
    partial class TestsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestsFrm));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtPickerTestDate = new System.Windows.Forms.DateTimePicker();
            this.dgvTests = new System.Windows.Forms.DataGridView();
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
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.lblBasicSalary = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.npdTestGrade = new System.Windows.Forms.NumericUpDown();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdTestGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(705, 34);
            this.pnlTitle.TabIndex = 155;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(19, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 17);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Tests";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(663, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtPickerTestDate
            // 
            this.dtPickerTestDate.Location = new System.Drawing.Point(173, 167);
            this.dtPickerTestDate.Name = "dtPickerTestDate";
            this.dtPickerTestDate.Size = new System.Drawing.Size(488, 23);
            this.dtPickerTestDate.TabIndex = 173;
            // 
            // dgvTests
            // 
            this.dgvTests.AllowUserToAddRows = false;
            this.dgvTests.AllowUserToDeleteRows = false;
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Location = new System.Drawing.Point(22, 293);
            this.dgvTests.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.ReadOnly = true;
            this.dgvTests.Size = new System.Drawing.Size(660, 213);
            this.dgvTests.TabIndex = 172;
            this.dgvTests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTests_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 171;
            this.label4.Text = "TestDate";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(118, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 35);
            this.panel1.TabIndex = 170;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(118, 240);
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
            this.pnlShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.pnlShowAll.Location = new System.Drawing.Point(510, 240);
            this.pnlShowAll.Name = "pnlShowAll";
            this.pnlShowAll.Size = new System.Drawing.Size(5, 35);
            this.pnlShowAll.TabIndex = 168;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.pnlUpdate.Location = new System.Drawing.Point(405, 240);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(5, 35);
            this.pnlUpdate.TabIndex = 167;
            // 
            // pnlDelete
            // 
            this.pnlDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.pnlDelete.Location = new System.Drawing.Point(305, 240);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(5, 35);
            this.pnlDelete.TabIndex = 166;
            // 
            // pnlSave
            // 
            this.pnlSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.pnlSave.Location = new System.Drawing.Point(210, 240);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(5, 35);
            this.pnlSave.TabIndex = 165;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAll.Image")));
            this.btnShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.Location = new System.Drawing.Point(510, 240);
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
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(405, 240);
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
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(305, 240);
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
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(210, 240);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 35);
            this.btnSave.TabIndex = 164;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTestName
            // 
            this.txtTestName.Enabled = false;
            this.txtTestName.Location = new System.Drawing.Point(173, 59);
            this.txtTestName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(488, 23);
            this.txtTestName.TabIndex = 159;
            // 
            // lblBasicSalary
            // 
            this.lblBasicSalary.AutoSize = true;
            this.lblBasicSalary.Location = new System.Drawing.Point(51, 116);
            this.lblBasicSalary.Name = "lblBasicSalary";
            this.lblBasicSalary.Size = new System.Drawing.Size(72, 17);
            this.lblBasicSalary.TabIndex = 158;
            this.lblBasicSalary.Text = "TestGrade";
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(49, 62);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(75, 17);
            this.lblGroupName.TabIndex = 157;
            this.lblGroupName.Text = "TestName:";
            // 
            // npdTestGrade
            // 
            this.npdTestGrade.Location = new System.Drawing.Point(173, 114);
            this.npdTestGrade.Name = "npdTestGrade";
            this.npdTestGrade.Size = new System.Drawing.Size(488, 23);
            this.npdTestGrade.TabIndex = 174;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(24, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 175;
            this.button1.Text = "Print";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // TestsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.npdTestGrade);
            this.Controls.Add(this.dtPickerTestDate);
            this.Controls.Add(this.dgvTests);
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
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.lblBasicSalary);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TestsFrm";
            this.Load += new System.EventHandler(this.TestsFrm_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdTestGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtPickerTestDate;
        private System.Windows.Forms.DataGridView dgvTests;
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
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Label lblBasicSalary;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.NumericUpDown npdTestGrade;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}