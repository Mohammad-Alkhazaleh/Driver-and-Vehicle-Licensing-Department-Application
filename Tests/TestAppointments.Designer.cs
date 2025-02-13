namespace NewDVLD_Project.Tests
{
    partial class TestAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestAppointments));
            this.DGV_Appointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tstakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddVisionTestSchedual = new System.Windows.Forms.Button();
            this.lblNumRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.ucDrivingLicenseApplicationInfo1 = new NewDVLD_Project.Tests.ucDrivingLicenseApplicationInfo();
            this.ucApplicationInfo1 = new NewDVLD_Project.Tests.ucApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Appointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Appointments
            // 
            this.DGV_Appointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Appointments.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Appointments.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_Appointments.Location = new System.Drawing.Point(30, 474);
            this.DGV_Appointments.Name = "DGV_Appointments";
            this.DGV_Appointments.Size = new System.Drawing.Size(639, 119);
            this.DGV_Appointments.TabIndex = 67;
            this.DGV_Appointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Appointments_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstakeTest,
            this.tsEdit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // tstakeTest
            // 
            this.tstakeTest.Image = ((System.Drawing.Image)(resources.GetObject("tstakeTest.Image")));
            this.tstakeTest.Name = "tstakeTest";
            this.tstakeTest.Size = new System.Drawing.Size(180, 22);
            this.tstakeTest.Text = "Take Test";
            this.tstakeTest.Click += new System.EventHandler(this.tstakeTest_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsEdit.Image")));
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(180, 22);
            this.tsEdit.Text = "Edit";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddVisionTestSchedual
            // 
            this.btnAddVisionTestSchedual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddVisionTestSchedual.BackgroundImage")));
            this.btnAddVisionTestSchedual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddVisionTestSchedual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVisionTestSchedual.Location = new System.Drawing.Point(630, 435);
            this.btnAddVisionTestSchedual.Name = "btnAddVisionTestSchedual";
            this.btnAddVisionTestSchedual.Size = new System.Drawing.Size(39, 34);
            this.btnAddVisionTestSchedual.TabIndex = 58;
            this.btnAddVisionTestSchedual.UseVisualStyleBackColor = true;
            this.btnAddVisionTestSchedual.Click += new System.EventHandler(this.btnAddVisionTestSchedual_Click);
            // 
            // lblNumRecords
            // 
            this.lblNumRecords.AutoSize = true;
            this.lblNumRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRecords.Location = new System.Drawing.Point(106, 602);
            this.lblNumRecords.Name = "lblNumRecords";
            this.lblNumRecords.Size = new System.Drawing.Size(14, 13);
            this.lblNumRecords.TabIndex = 65;
            this.lblNumRecords.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(27, 601);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(74, 13);
            this.lblRecords.TabIndex = 64;
            this.lblRecords.Text = "#Records : ";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(595, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 63;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(27, 453);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(130, 18);
            this.lblUserName.TabIndex = 59;
            this.lblUserName.Text = "Appointments  : ";
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTestName.Location = new System.Drawing.Point(224, 109);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(184, 24);
            this.lblTestName.TabIndex = 60;
            this.lblTestName.Text = "Test Appointments";
            // 
            // ucDrivingLicenseApplicationInfo1
            // 
            this.ucDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(28, 136);
            this.ucDrivingLicenseApplicationInfo1.Name = "ucDrivingLicenseApplicationInfo1";
            this.ucDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(648, 92);
            this.ucDrivingLicenseApplicationInfo1.TabIndex = 68;
            // 
            // ucApplicationInfo1
            // 
            this.ucApplicationInfo1.Location = new System.Drawing.Point(28, 241);
            this.ucApplicationInfo1.Name = "ucApplicationInfo1";
            this.ucApplicationInfo1.Size = new System.Drawing.Size(650, 188);
            this.ucApplicationInfo1.TabIndex = 66;
            // 
            // TestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 629);
            this.Controls.Add(this.ucDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.ucApplicationInfo1);
            this.Controls.Add(this.DGV_Appointments);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddVisionTestSchedual);
            this.Controls.Add(this.lblNumRecords);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblTestName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestAppointments";
            this.Load += new System.EventHandler(this.TestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Appointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Appointments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tstakeTest;
        private System.Windows.Forms.ToolStripMenuItem tsEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddVisionTestSchedual;
        private System.Windows.Forms.Label lblNumRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTestName;
        private ucApplicationInfo ucApplicationInfo1;
        private ucDrivingLicenseApplicationInfo ucDrivingLicenseApplicationInfo1;
    }
}