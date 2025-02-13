namespace NewDVLD_Project.Tests
{
    partial class ucDrivingLicenseApplicationInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPassedTests = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblAppliedForLicense = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblD_L_APPID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPassedTests);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblAppliedForLicense);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblD_L_APPID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 86);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License Application Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPassedTests
            // 
            this.lblPassedTests.AutoSize = true;
            this.lblPassedTests.Location = new System.Drawing.Point(407, 54);
            this.lblPassedTests.Name = "lblPassedTests";
            this.lblPassedTests.Size = new System.Drawing.Size(10, 13);
            this.lblPassedTests.TabIndex = 64;
            this.lblPassedTests.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(282, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 18);
            this.label16.TabIndex = 65;
            this.label16.Text = "Passed Tests : ";
            // 
            // lblAppliedForLicense
            // 
            this.lblAppliedForLicense.AutoSize = true;
            this.lblAppliedForLicense.Location = new System.Drawing.Point(405, 29);
            this.lblAppliedForLicense.Name = "lblAppliedForLicense";
            this.lblAppliedForLicense.Size = new System.Drawing.Size(10, 13);
            this.lblAppliedForLicense.TabIndex = 62;
            this.lblAppliedForLicense.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(237, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 18);
            this.label14.TabIndex = 63;
            this.label14.Text = "Applied For License : ";
            // 
            // lblD_L_APPID
            // 
            this.lblD_L_APPID.AutoSize = true;
            this.lblD_L_APPID.Location = new System.Drawing.Point(117, 30);
            this.lblD_L_APPID.Name = "lblD_L_APPID";
            this.lblD_L_APPID.Size = new System.Drawing.Size(10, 13);
            this.lblD_L_APPID.TabIndex = 61;
            this.lblD_L_APPID.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 18);
            this.label11.TabIndex = 61;
            this.label11.Text = "D.L.App ID : ";
            // 
            // ucDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucDrivingLicenseApplicationInfo";
            this.Size = new System.Drawing.Size(648, 92);
            this.Load += new System.EventHandler(this.ucDrivingLicenseApplicationInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPassedTests;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblAppliedForLicense;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblD_L_APPID;
        private System.Windows.Forms.Label label11;
    }
}
