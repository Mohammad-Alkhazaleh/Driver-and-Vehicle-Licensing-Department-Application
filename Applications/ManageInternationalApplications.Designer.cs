namespace NewDVLD_Project.Licenses
{
    partial class ManageInternationalApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInternationalApplications));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddInternationalDrivingLicense = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvInternationalDrivingLicense = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShowLicesneDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalDrivingLicense)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(796, 468);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddInternationalDrivingLicense
            // 
            this.btnAddInternationalDrivingLicense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddInternationalDrivingLicense.BackgroundImage")));
            this.btnAddInternationalDrivingLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddInternationalDrivingLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddInternationalDrivingLicense.Location = new System.Drawing.Point(827, 196);
            this.btnAddInternationalDrivingLicense.Name = "btnAddInternationalDrivingLicense";
            this.btnAddInternationalDrivingLicense.Size = new System.Drawing.Size(44, 37);
            this.btnAddInternationalDrivingLicense.TabIndex = 34;
            this.btnAddInternationalDrivingLicense.UseVisualStyleBackColor = true;
            this.btnAddInternationalDrivingLicense.Click += new System.EventHandler(this.btnAddInternationalDrivingLicense_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(273, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "International License Applications";
            // 
            // combFilter
            // 
            this.combFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combFilter.FormattingEnabled = true;
            this.combFilter.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone ",
            "Email"});
            this.combFilter.Location = new System.Drawing.Point(80, 205);
            this.combFilter.Name = "combFilter";
            this.combFilter.Size = new System.Drawing.Size(141, 21);
            this.combFilter.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Filter by : ";
            // 
            // lblNumRecords
            // 
            this.lblNumRecords.AutoSize = true;
            this.lblNumRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRecords.Location = new System.Drawing.Point(89, 474);
            this.lblNumRecords.Name = "lblNumRecords";
            this.lblNumRecords.Size = new System.Drawing.Size(14, 13);
            this.lblNumRecords.TabIndex = 30;
            this.lblNumRecords.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(10, 473);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(74, 13);
            this.lblRecords.TabIndex = 29;
            this.lblRecords.Text = "#Records : ";
            // 
            // dgvInternationalDrivingLicense
            // 
            this.dgvInternationalDrivingLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalDrivingLicense.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalDrivingLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalDrivingLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInternationalDrivingLicense.Location = new System.Drawing.Point(10, 234);
            this.dgvInternationalDrivingLicense.Name = "dgvInternationalDrivingLicense";
            this.dgvInternationalDrivingLicense.Size = new System.Drawing.Size(861, 224);
            this.dgvInternationalDrivingLicense.TabIndex = 28;
            this.dgvInternationalDrivingLicense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInternationalDrivingLicense_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsShowPersonDetails,
            this.tsShowLicesneDetails,
            this.tsShowPersonLicenseHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 70);
            // 
            // tsShowPersonDetails
            // 
            this.tsShowPersonDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsShowPersonDetails.Image")));
            this.tsShowPersonDetails.Name = "tsShowPersonDetails";
            this.tsShowPersonDetails.Size = new System.Drawing.Size(225, 22);
            this.tsShowPersonDetails.Text = "Show Person Details";
            this.tsShowPersonDetails.Click += new System.EventHandler(this.tsShowPersonDetails_Click);
            // 
            // tsShowLicesneDetails
            // 
            this.tsShowLicesneDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsShowLicesneDetails.Image")));
            this.tsShowLicesneDetails.Name = "tsShowLicesneDetails";
            this.tsShowLicesneDetails.Size = new System.Drawing.Size(225, 22);
            this.tsShowLicesneDetails.Text = "Show Licesne Details";
            this.tsShowLicesneDetails.Click += new System.EventHandler(this.tsShowLicesneDetails_Click);
            // 
            // tsShowPersonLicenseHistory
            // 
            this.tsShowPersonLicenseHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsShowPersonLicenseHistory.Image")));
            this.tsShowPersonLicenseHistory.Name = "tsShowPersonLicenseHistory";
            this.tsShowPersonLicenseHistory.Size = new System.Drawing.Size(225, 22);
            this.tsShowPersonLicenseHistory.Text = "Show Person License History";
            this.tsShowPersonLicenseHistory.Click += new System.EventHandler(this.tsShowPersonLicenseHistory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(504, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // ManageInternationalApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 499);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddInternationalDrivingLicense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumRecords);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvInternationalDrivingLicense);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageInternationalApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageInternationalLicense";
            this.Load += new System.EventHandler(this.ManageInternationalApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalDrivingLicense)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddInternationalDrivingLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvInternationalDrivingLicense;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem tsShowLicesneDetails;
        private System.Windows.Forms.ToolStripMenuItem tsShowPersonLicenseHistory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}