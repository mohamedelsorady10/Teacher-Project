namespace PresentationLayerPL
{
    partial class InformationFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationFrm));
            this.txtTotalBooklet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.txtTotalRemainderPayment = new System.Windows.Forms.TextBox();
            this.txtTotalRemainderBooklet = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalculateAll = new System.Windows.Forms.Button();
            this.pnlShowAll = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotalBooklet
            // 
            this.txtTotalBooklet.Enabled = false;
            this.txtTotalBooklet.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotalBooklet.Location = new System.Drawing.Point(224, 225);
            this.txtTotalBooklet.Name = "txtTotalBooklet";
            this.txtTotalBooklet.Size = new System.Drawing.Size(205, 23);
            this.txtTotalBooklet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(29, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Booklet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(457, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(457, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Remainder in Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(29, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Remainder in Booklet";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Enabled = false;
            this.txtTotalPayment.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotalPayment.Location = new System.Drawing.Point(654, 225);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(217, 23);
            this.txtTotalPayment.TabIndex = 0;
            // 
            // txtTotalRemainderPayment
            // 
            this.txtTotalRemainderPayment.Enabled = false;
            this.txtTotalRemainderPayment.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotalRemainderPayment.Location = new System.Drawing.Point(654, 293);
            this.txtTotalRemainderPayment.Name = "txtTotalRemainderPayment";
            this.txtTotalRemainderPayment.Size = new System.Drawing.Size(217, 23);
            this.txtTotalRemainderPayment.TabIndex = 0;
            // 
            // txtTotalRemainderBooklet
            // 
            this.txtTotalRemainderBooklet.Enabled = false;
            this.txtTotalRemainderBooklet.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotalRemainderBooklet.Location = new System.Drawing.Point(224, 287);
            this.txtTotalRemainderBooklet.Name = "txtTotalRemainderBooklet";
            this.txtTotalRemainderBooklet.Size = new System.Drawing.Size(205, 23);
            this.txtTotalRemainderBooklet.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 23);
            this.dateTimePicker1.TabIndex = 5;
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
            this.pnlTitle.Size = new System.Drawing.Size(950, 34);
            this.pnlTitle.TabIndex = 63;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(19, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(83, 17);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Information";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(905, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalculateAll
            // 
            this.btnCalculateAll.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculateAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalculateAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateAll.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCalculateAll.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculateAll.Image")));
            this.btnCalculateAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculateAll.Location = new System.Drawing.Point(603, 91);
            this.btnCalculateAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculateAll.Name = "btnCalculateAll";
            this.btnCalculateAll.Size = new System.Drawing.Size(162, 40);
            this.btnCalculateAll.TabIndex = 125;
            this.btnCalculateAll.Text = "Calculate";
            this.btnCalculateAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculateAll.UseVisualStyleBackColor = false;
            this.btnCalculateAll.Click += new System.EventHandler(this.btnCalculateAll_Click);
            // 
            // pnlShowAll
            // 
            this.pnlShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlShowAll.Location = new System.Drawing.Point(603, 91);
            this.pnlShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.pnlShowAll.Name = "pnlShowAll";
            this.pnlShowAll.Size = new System.Drawing.Size(7, 40);
            this.pnlShowAll.TabIndex = 132;
            // 
            // InformationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 404);
            this.Controls.Add(this.pnlShowAll);
            this.Controls.Add(this.btnCalculateAll);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalRemainderBooklet);
            this.Controls.Add(this.txtTotalRemainderPayment);
            this.Controls.Add(this.txtTotalPayment);
            this.Controls.Add(this.txtTotalBooklet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformationFrm";
            this.Load += new System.EventHandler(this.InformationFrm_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalBooklet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.TextBox txtTotalRemainderPayment;
        private System.Windows.Forms.TextBox txtTotalRemainderBooklet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalculateAll;
        private System.Windows.Forms.Panel pnlShowAll;
    }
}