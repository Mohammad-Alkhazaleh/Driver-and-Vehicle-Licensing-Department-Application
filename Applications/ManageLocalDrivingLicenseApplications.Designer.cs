namespace NewDVLD_Project.Applications
{
    partial class ManageLocalDrivingLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLocalDrivingLicenseApplications));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsIssueDrivingLicenseFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSechdualStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSechdualWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSechdualVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSechdualTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tscancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddLocalDrivingLicense = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvLocalDrivingLicense = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // tsShowLicense
            // 
            this.tsShowLicense.Image = ((System.Drawing.Image)(resources.GetObject("tsShowLicense.Image")));
            this.tsShowLicense.Name = "tsShowLicense";
            this.tsShowLicense.Size = new System.Drawing.Size(246, 26);
            this.tsShowLicense.Text = "Show License";
            this.tsShowLicense.Click += new System.EventHandler(this.tsShowLicense_Click);
            // 
            // tsIssueDrivingLicenseFirstTime
            // 
            this.tsIssueDrivingLicenseFirstTime.Image = ((System.Drawing.Image)(resources.GetObject("tsIssueDrivingLicenseFirstTime.Image")));
            this.tsIssueDrivingLicenseFirstTime.Name = "tsIssueDrivingLicenseFirstTime";
            this.tsIssueDrivingLicenseFirstTime.Size = new System.Drawing.Size(246, 26);
            this.tsIssueDrivingLicenseFirstTime.Text = "Issue Driving License(First Time)";
            this.tsIssueDrivingLicenseFirstTime.Click += new System.EventHandler(this.tsIssueDrivingLicenseFirstTime_Click);
            // 
            // tsSechdualStreetTest
            // 
            this.tsSechdualStreetTest.Image = ((System.Drawing.Image)(resources.GetObject("tsSechdualStreetTest.Image")));
            this.tsSechdualStreetTest.Name = "tsSechdualStreetTest";
            this.tsSechdualStreetTest.Size = new System.Drawing.Size(187, 22);
            this.tsSechdualStreetTest.Text = "Sechdual Street Test";
            this.tsSechdualStreetTest.Click += new System.EventHandler(this.tsSechdualStreetTest_Click);
            // 
            // tsSechdualWrittenTest
            // 
            this.tsSechdualWrittenTest.Image = ((System.Drawing.Image)(resources.GetObject("tsSechdualWrittenTest.Image")));
            this.tsSechdualWrittenTest.Name = "tsSechdualWrittenTest";
            this.tsSechdualWrittenTest.Size = new System.Drawing.Size(187, 22);
            this.tsSechdualWrittenTest.Text = "Sechdual Written Test";
            this.tsSechdualWrittenTest.Click += new System.EventHandler(this.tsSechdualWrittenTest_Click);
            // 
            // tsSechdualVisionTest
            // 
            this.tsSechdualVisionTest.Image = ((System.Drawing.Image)(resources.GetObject("tsSechdualVisionTest.Image")));
            this.tsSechdualVisionTest.Name = "tsSechdualVisionTest";
            this.tsSechdualVisionTest.Size = new System.Drawing.Size(187, 22);
            this.tsSechdualVisionTest.Text = "Sechdual Vision Test";
            this.tsSechdualVisionTest.Click += new System.EventHandler(this.tsSechdualVisionTest_Click);
            // 
            // tsSechdualTest
            // 
            this.tsSechdualTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSechdualVisionTest,
            this.tsSechdualWrittenTest,
            this.tsSechdualStreetTest});
            this.tsSechdualTest.Image = ((System.Drawing.Image)(resources.GetObject("tsSechdualTest.Image")));
            this.tsSechdualTest.Name = "tsSechdualTest";
            this.tsSechdualTest.Size = new System.Drawing.Size(246, 26);
            this.tsSechdualTest.Text = "Sechdual Test";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(243, 6);
            // 
            // tscancelApplication
            // 
            this.tscancelApplication.Image = ((System.Drawing.Image)(resources.GetObject("tscancelApplication.Image")));
            this.tscancelApplication.Name = "tscancelApplication";
            this.tscancelApplication.Size = new System.Drawing.Size(246, 26);
            this.tscancelApplication.Text = "Cancel Application";
            this.tscancelApplication.Click += new System.EventHandler(this.tscancelApplication_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
            // 
            // tsDeleteApplication
            // 
            this.tsDeleteApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsDeleteApplication.Image")));
            this.tsDeleteApplication.Name = "tsDeleteApplication";
            this.tsDeleteApplication.Size = new System.Drawing.Size(246, 26);
            this.tsDeleteApplication.Text = "Delete Application";
            // 
            // tsEditApplication
            // 
            this.tsEditApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsEditApplication.Image")));
            this.tsEditApplication.Name = "tsEditApplication";
            this.tsEditApplication.Size = new System.Drawing.Size(246, 26);
            this.tsEditApplication.Text = "Edit Application";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showApplicationDetailsToolStripMenuItem.Image")));
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.tsEditApplication,
            this.tsDeleteApplication,
            this.toolStripSeparator2,
            this.tscancelApplication,
            this.toolStripSeparator3,
            this.tsSechdualTest,
            this.tsIssueDrivingLicenseFirstTime,
            this.tsShowLicense,
            this.tsShowPersonLicenseHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(247, 252);
            // 
            // tsShowPersonLicenseHistory
            // 
            this.tsShowPersonLicenseHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsShowPersonLicenseHistory.Image")));
            this.tsShowPersonLicenseHistory.Name = "tsShowPersonLicenseHistory";
            this.tsShowPersonLicenseHistory.Size = new System.Drawing.Size(246, 26);
            this.tsShowPersonLicenseHistory.Text = "Show Person License History";
            this.tsShowPersonLicenseHistory.Click += new System.EventHandler(this.tsShowPersonLicenseHistory_Click);
            // 
            // btnAddLocalDrivingLicense
            // 
            this.btnAddLocalDrivingLicense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddLocalDrivingLicense.BackgroundImage")));
            this.btnAddLocalDrivingLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddLocalDrivingLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLocalDrivingLicense.Location = new System.Drawing.Point(891, 192);
            this.btnAddLocalDrivingLicense.Name = "btnAddLocalDrivingLicense";
            this.btnAddLocalDrivingLicense.Size = new System.Drawing.Size(44, 37);
            this.btnAddLocalDrivingLicense.TabIndex = 25;
            this.btnAddLocalDrivingLicense.UseVisualStyleBackColor = true;
            this.btnAddLocalDrivingLicense.Click += new System.EventHandler(this.btnAddLocalDrivingLicense_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(276, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Local Driving License Applications";
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
            this.combFilter.Location = new System.Drawing.Point(77, 201);
            this.combFilter.Name = "combFilter";
            this.combFilter.Size = new System.Drawing.Size(141, 21);
            this.combFilter.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Filter by : ";
            // 
            // lblNumRecords
            // 
            this.lblNumRecords.AutoSize = true;
            this.lblNumRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRecords.Location = new System.Drawing.Point(86, 470);
            this.lblNumRecords.Name = "lblNumRecords";
            this.lblNumRecords.Size = new System.Drawing.Size(14, 13);
            this.lblNumRecords.TabIndex = 21;
            this.lblNumRecords.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(7, 469);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(74, 13);
            this.lblRecords.TabIndex = 20;
            this.lblRecords.Text = "#Records : ";
            // 
            // dgvLocalDrivingLicense
            // 
            this.dgvLocalDrivingLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalDrivingLicense.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalDrivingLicense.Location = new System.Drawing.Point(7, 230);
            this.dgvLocalDrivingLicense.Name = "dgvLocalDrivingLicense";
            this.dgvLocalDrivingLicense.Size = new System.Drawing.Size(928, 224);
            this.dgvLocalDrivingLicense.TabIndex = 19;
            this.dgvLocalDrivingLicense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalDrivingLicense_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(851, 464);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(518, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // ManageLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 491);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddLocalDrivingLicense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumRecords);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvLocalDrivingLicense);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageLocalDrivingLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageLocalDrivingLicenseApplications";
            this.Load += new System.EventHandler(this.ManageLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsShowLicense;
        private System.Windows.Forms.ToolStripMenuItem tsIssueDrivingLicenseFirstTime;
        private System.Windows.Forms.ToolStripMenuItem tsSechdualStreetTest;
        private System.Windows.Forms.ToolStripMenuItem tsSechdualWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsSechdualVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsSechdualTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tscancelApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsDeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem tsEditApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsShowPersonLicenseHistory;
        private System.Windows.Forms.Button btnAddLocalDrivingLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicense;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}