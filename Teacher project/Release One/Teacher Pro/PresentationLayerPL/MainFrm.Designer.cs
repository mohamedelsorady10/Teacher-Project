namespace PresentationLayerPL
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAttend = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.pnlTitle.Controls.Add(this.button2);
            this.pnlTitle.Controls.Add(this.button1);
            this.pnlTitle.Controls.Add(this.btnAttend);
            this.pnlTitle.Controls.Add(this.btnStudents);
            this.pnlTitle.Controls.Add(this.btnGroups);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Controls.Add(this.btnMinimize);
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(990, 42);
            this.pnlTitle.TabIndex = 153;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(568, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Payments";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(472, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tests";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAttend
            // 
            this.btnAttend.FlatAppearance.BorderSize = 0;
            this.btnAttend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttend.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAttend.Location = new System.Drawing.Point(359, 0);
            this.btnAttend.Name = "btnAttend";
            this.btnAttend.Size = new System.Drawing.Size(124, 42);
            this.btnAttend.TabIndex = 6;
            this.btnAttend.Text = "Attendence";
            this.btnAttend.UseVisualStyleBackColor = true;
            this.btnAttend.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStudents.Location = new System.Drawing.Point(247, 0);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(113, 42);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudentDetails_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.FlatAppearance.BorderSize = 0;
            this.btnGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroups.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroups.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGroups.Location = new System.Drawing.Point(147, 0);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(99, 42);
            this.btnGroups.TabIndex = 2;
            this.btnGroups.Text = "Groups";
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(44, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 42);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(904, -4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 49);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(949, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 42);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PresentationLayerPL.Properties.Resources._6858245d15f32d5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 478);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAttend;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button2;
    }
}