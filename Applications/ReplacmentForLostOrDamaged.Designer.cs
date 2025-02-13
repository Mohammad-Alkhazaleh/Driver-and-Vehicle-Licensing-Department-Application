namespace NewDVLD_Project.Applications
{
    partial class ReplacmentForLostOrDamaged
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
            this.gbReplacmentFor = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.lblAdd_EditUser = new System.Windows.Forms.Label();
            this.llShowNewLicensesInfo = new System.Windows.Forms.LinkLabel();
            this.llShowLicesnesHistory = new System.Windows.Forms.LinkLabel();
            this.btnReplacment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_R_CreatedBy = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lbl_Replaced_LicesneID = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_L_R_ApplicationID = new System.Windows.Forms.Label();
            this.I = new System.Windows.Forms.Label();
            this.ucDriverLicenseInfo1 = new NewDVLD_Project.Licenses.ucDriverLicenseInfo();
            this.ucInternationalLicenseFilter1 = new NewDVLD_Project.Licenses.ucInternationalLicenseFilter();
            this.gbReplacmentFor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReplacmentFor
            // 
            this.gbReplacmentFor.Controls.Add(this.rbLostLicense);
            this.gbReplacmentFor.Controls.Add(this.rbDamagedLicense);
            this.gbReplacmentFor.Location = new System.Drawing.Point(545, 42);
            this.gbReplacmentFor.Name = "gbReplacmentFor";
            this.gbReplacmentFor.Size = new System.Drawing.Size(136, 72);
            this.gbReplacmentFor.TabIndex = 102;
            this.gbReplacmentFor.TabStop = false;
            this.gbReplacmentFor.Text = "ReplacmentFor";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(14, 47);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(85, 17);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(14, 24);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(111, 17);
            this.rbDamagedLicense.TabIndex = 0;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
            // 
            // lblAdd_EditUser
            // 
            this.lblAdd_EditUser.AutoSize = true;
            this.lblAdd_EditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd_EditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdd_EditUser.Location = new System.Drawing.Point(178, 11);
            this.lblAdd_EditUser.Name = "lblAdd_EditUser";
            this.lblAdd_EditUser.Size = new System.Drawing.Size(333, 24);
            this.lblAdd_EditUser.TabIndex = 95;
            this.lblAdd_EditUser.Text = "Replacment For Damaged License";
            // 
            // llShowNewLicensesInfo
            // 
            this.llShowNewLicensesInfo.AutoSize = true;
            this.llShowNewLicensesInfo.Location = new System.Drawing.Point(145, 566);
            this.llShowNewLicensesInfo.Name = "llShowNewLicensesInfo";
            this.llShowNewLicensesInfo.Size = new System.Drawing.Size(125, 13);
            this.llShowNewLicensesInfo.TabIndex = 101;
            this.llShowNewLicensesInfo.TabStop = true;
            this.llShowNewLicensesInfo.Text = "Show New Licenses Info";
            // 
            // llShowLicesnesHistory
            // 
            this.llShowLicesnesHistory.AutoSize = true;
            this.llShowLicesnesHistory.Location = new System.Drawing.Point(24, 566);
            this.llShowLicesnesHistory.Name = "llShowLicesnesHistory";
            this.llShowLicesnesHistory.Size = new System.Drawing.Size(114, 13);
            this.llShowLicesnesHistory.TabIndex = 100;
            this.llShowLicesnesHistory.TabStop = true;
            this.llShowLicesnesHistory.Text = "Show Licenses History";
            // 
            // btnReplacment
            // 
            this.btnReplacment.Location = new System.Drawing.Point(578, 561);
            this.btnReplacment.Name = "btnReplacment";
            this.btnReplacment.Size = new System.Drawing.Size(103, 23);
            this.btnReplacment.TabIndex = 99;
            this.btnReplacment.Text = "Issue Replacment";
            this.btnReplacment.UseVisualStyleBackColor = true;
            this.btnReplacment.Click += new System.EventHandler(this.btnReplacment_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(497, 561);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 98;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_R_CreatedBy);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.lblOldLicenseID);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.lbl_Replaced_LicesneID);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.lblApplicationFees);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblApplicationDate);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.lbl_L_R_ApplicationID);
            this.groupBox1.Controls.Add(this.I);
            this.groupBox1.Location = new System.Drawing.Point(16, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 125);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info For License Replacment";
            // 
            // lbl_R_CreatedBy
            // 
            this.lbl_R_CreatedBy.AutoSize = true;
            this.lbl_R_CreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_R_CreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lbl_R_CreatedBy.Location = new System.Drawing.Point(481, 90);
            this.lbl_R_CreatedBy.Name = "lbl_R_CreatedBy";
            this.lbl_R_CreatedBy.Size = new System.Drawing.Size(11, 16);
            this.lbl_R_CreatedBy.TabIndex = 78;
            this.lbl_R_CreatedBy.Text = "-";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(369, 88);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 18);
            this.label24.TabIndex = 77;
            this.label24.Text = "Created By :";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.Location = new System.Drawing.Point(480, 58);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(11, 16);
            this.lblOldLicenseID.TabIndex = 74;
            this.lblOldLicenseID.Text = "-";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(341, 56);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(128, 18);
            this.label28.TabIndex = 73;
            this.label28.Text = "Old License ID :";
            // 
            // lbl_Replaced_LicesneID
            // 
            this.lbl_Replaced_LicesneID.AutoSize = true;
            this.lbl_Replaced_LicesneID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Replaced_LicesneID.Location = new System.Drawing.Point(480, 28);
            this.lbl_Replaced_LicesneID.Name = "lbl_Replaced_LicesneID";
            this.lbl_Replaced_LicesneID.Size = new System.Drawing.Size(11, 16);
            this.lbl_Replaced_LicesneID.TabIndex = 72;
            this.lbl_Replaced_LicesneID.Text = "-";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(298, 24);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(172, 18);
            this.label30.TabIndex = 71;
            this.label30.Text = "Replaced License ID :";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFees.Location = new System.Drawing.Point(171, 89);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(11, 16);
            this.lblApplicationFees.TabIndex = 70;
            this.lblApplicationFees.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 18);
            this.label13.TabIndex = 69;
            this.label13.Text = "Application Fees : ";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(170, 58);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(11, 16);
            this.lblApplicationDate.TabIndex = 66;
            this.lblApplicationDate.Text = "-";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(26, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(145, 18);
            this.label20.TabIndex = 65;
            this.label20.Text = "Application Date : ";
            // 
            // lbl_L_R_ApplicationID
            // 
            this.lbl_L_R_ApplicationID.AutoSize = true;
            this.lbl_L_R_ApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_L_R_ApplicationID.Location = new System.Drawing.Point(170, 29);
            this.lbl_L_R_ApplicationID.Name = "lbl_L_R_ApplicationID";
            this.lbl_L_R_ApplicationID.Size = new System.Drawing.Size(11, 16);
            this.lbl_L_R_ApplicationID.TabIndex = 64;
            this.lbl_L_R_ApplicationID.Text = "-";
            // 
            // I
            // 
            this.I.AutoSize = true;
            this.I.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I.Location = new System.Drawing.Point(14, 25);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(157, 18);
            this.I.TabIndex = 63;
            this.I.Text = "L.R.Application ID : ";
            // 
            // ucDriverLicenseInfo1
            // 
            this.ucDriverLicenseInfo1.Location = new System.Drawing.Point(11, 118);
            this.ucDriverLicenseInfo1.Name = "ucDriverLicenseInfo1";
            this.ucDriverLicenseInfo1.Size = new System.Drawing.Size(674, 293);
            this.ucDriverLicenseInfo1.TabIndex = 103;
            // 
            // ucInternationalLicenseFilter1
            // 
            this.ucInternationalLicenseFilter1.Location = new System.Drawing.Point(14, 53);
            this.ucInternationalLicenseFilter1.Name = "ucInternationalLicenseFilter1";
            this.ucInternationalLicenseFilter1.Size = new System.Drawing.Size(670, 61);
            this.ucInternationalLicenseFilter1.TabIndex = 72;
            // 
            // ReplacmentForLostOrDamaged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 595);
            this.Controls.Add(this.ucDriverLicenseInfo1);
            this.Controls.Add(this.gbReplacmentFor);
            this.Controls.Add(this.ucInternationalLicenseFilter1);
            this.Controls.Add(this.lblAdd_EditUser);
            this.Controls.Add(this.llShowNewLicensesInfo);
            this.Controls.Add(this.llShowLicesnesHistory);
            this.Controls.Add(this.btnReplacment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReplacmentForLostOrDamaged";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReplacmentForLostOrDamaged";
            this.Load += new System.EventHandler(this.ReplacmentForLostOrDamaged_Load);
            this.gbReplacmentFor.ResumeLayout(false);
            this.gbReplacmentFor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbReplacmentFor;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
        private System.Windows.Forms.Label lblAdd_EditUser;
        private System.Windows.Forms.LinkLabel llShowNewLicensesInfo;
        private System.Windows.Forms.LinkLabel llShowLicesnesHistory;
        private System.Windows.Forms.Button btnReplacment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_R_CreatedBy;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lbl_Replaced_LicesneID;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_L_R_ApplicationID;
        private System.Windows.Forms.Label I;
        private Licenses.ucInternationalLicenseFilter ucInternationalLicenseFilter1;
        private Licenses.ucDriverLicenseInfo ucDriverLicenseInfo1;
    }
}