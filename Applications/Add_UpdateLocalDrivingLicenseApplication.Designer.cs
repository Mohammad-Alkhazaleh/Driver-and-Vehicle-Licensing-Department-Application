namespace NewDVLD_Project.Applications
{
    partial class Add_UpdateLocalDrivingLicenseApplication
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNewLocalDrivingLicenseApp = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpPersonalInfo = new System.Windows.Forms.TabPage();
            this.combLicneseClass = new System.Windows.Forms.ComboBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDLApplicationID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbpAppInfo = new System.Windows.Forms.TabPage();
            this.ucPersonInformationWithNext1 = new NewDVLD_Project.People.ucPersonInformationWithNext();
            this.ucPersonFilter1 = new NewDVLD_Project.People.ucPersonFilter_Add();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbpPersonalInfo.SuspendLayout();
            this.tbpAppInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblNewLocalDrivingLicenseApp
            // 
            this.lblNewLocalDrivingLicenseApp.AutoSize = true;
            this.lblNewLocalDrivingLicenseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLocalDrivingLicenseApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNewLocalDrivingLicenseApp.Location = new System.Drawing.Point(155, 26);
            this.lblNewLocalDrivingLicenseApp.Name = "lblNewLocalDrivingLicenseApp";
            this.lblNewLocalDrivingLicenseApp.Size = new System.Drawing.Size(368, 24);
            this.lblNewLocalDrivingLicenseApp.TabIndex = 52;
            this.lblNewLocalDrivingLicenseApp.Text = "New Local Driving License Application";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(560, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(458, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 23);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpPersonalInfo);
            this.tabControl1.Controls.Add(this.tbpAppInfo);
            this.tabControl1.Location = new System.Drawing.Point(22, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 342);
            this.tabControl1.TabIndex = 53;
            // 
            // tbpPersonalInfo
            // 
            this.tbpPersonalInfo.Controls.Add(this.combLicneseClass);
            this.tbpPersonalInfo.Controls.Add(this.lblCreatedBy);
            this.tbpPersonalInfo.Controls.Add(this.lblAppFees);
            this.tbpPersonalInfo.Controls.Add(this.lblAppDate);
            this.tbpPersonalInfo.Controls.Add(this.label2);
            this.tbpPersonalInfo.Controls.Add(this.lblDLApplicationID);
            this.tbpPersonalInfo.Controls.Add(this.label11);
            this.tbpPersonalInfo.Controls.Add(this.lblUserName);
            this.tbpPersonalInfo.Controls.Add(this.label13);
            this.tbpPersonalInfo.Controls.Add(this.label14);
            this.tbpPersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tbpPersonalInfo.Name = "tbpPersonalInfo";
            this.tbpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPersonalInfo.Size = new System.Drawing.Size(642, 316);
            this.tbpPersonalInfo.TabIndex = 1;
            this.tbpPersonalInfo.Text = "Personal Info";
            this.tbpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // combLicneseClass
            // 
            this.combLicneseClass.FormattingEnabled = true;
            this.combLicneseClass.Items.AddRange(new object[] {
            "Class 1 - Small Motorcycle",
            "Class 2 - Heavy Motorcycle License",
            "Class 3 - Ordinary driving license",
            "Class 4 - Commercial",
            "Class 5 - Agricultural",
            "Class 6 - Small and medium bus",
            "Class 7 - Truck and heavy vehicle"});
            this.combLicneseClass.Location = new System.Drawing.Point(165, 105);
            this.combLicneseClass.Name = "combLicneseClass";
            this.combLicneseClass.Size = new System.Drawing.Size(216, 21);
            this.combLicneseClass.TabIndex = 42;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(162, 171);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(14, 18);
            this.lblCreatedBy.TabIndex = 41;
            this.lblCreatedBy.Text = "-";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.Location = new System.Drawing.Point(162, 138);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(14, 18);
            this.lblAppFees.TabIndex = 40;
            this.lblAppFees.Text = "-";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.Location = new System.Drawing.Point(162, 72);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(14, 18);
            this.lblAppDate.TabIndex = 39;
            this.lblAppDate.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Created By : ";
            // 
            // lblDLApplicationID
            // 
            this.lblDLApplicationID.AutoSize = true;
            this.lblDLApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLApplicationID.Location = new System.Drawing.Point(172, 39);
            this.lblDLApplicationID.Name = "lblDLApplicationID";
            this.lblDLApplicationID.Size = new System.Drawing.Size(45, 18);
            this.lblDLApplicationID.TabIndex = 33;
            this.lblDLApplicationID.Text = "[???]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "D.L.ApplicarionID :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(18, 72);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(150, 18);
            this.lblUserName.TabIndex = 30;
            this.lblUserName.Text = "Application Date  : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "License Class : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 18);
            this.label14.TabIndex = 32;
            this.label14.Text = "Application Fees : ";
            // 
            // tbpAppInfo
            // 
            this.tbpAppInfo.Controls.Add(this.ucPersonInformationWithNext1);
            this.tbpAppInfo.Controls.Add(this.ucPersonFilter1);
            this.tbpAppInfo.Location = new System.Drawing.Point(4, 22);
            this.tbpAppInfo.Name = "tbpAppInfo";
            this.tbpAppInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAppInfo.Size = new System.Drawing.Size(642, 316);
            this.tbpAppInfo.TabIndex = 0;
            this.tbpAppInfo.Text = "Application Info";
            this.tbpAppInfo.UseVisualStyleBackColor = true;
            // 
            // ucPersonInformationWithNext1
            // 
            this.ucPersonInformationWithNext1.Location = new System.Drawing.Point(9, 84);
            this.ucPersonInformationWithNext1.Name = "ucPersonInformationWithNext1";
            this.ucPersonInformationWithNext1.Size = new System.Drawing.Size(631, 226);
            this.ucPersonInformationWithNext1.TabIndex = 45;
            // 
            // ucPersonFilter1
            // 
            this.ucPersonFilter1.Location = new System.Drawing.Point(7, 21);
            this.ucPersonFilter1.Name = "ucPersonFilter1";
            this.ucPersonFilter1.Size = new System.Drawing.Size(629, 62);
            this.ucPersonFilter1.TabIndex = 45;
            // 
            // Add_UpdateLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 466);
            this.Controls.Add(this.lblNewLocalDrivingLicenseApp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_UpdateLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_UpdateLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.Add_UpdateLocalDrivingLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbpPersonalInfo.ResumeLayout(false);
            this.tbpPersonalInfo.PerformLayout();
            this.tbpAppInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblNewLocalDrivingLicenseApp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpPersonalInfo;
        private System.Windows.Forms.ComboBox combLicneseClass;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDLApplicationID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tbpAppInfo;
        private People.ucPersonInformationWithNext ucPersonInformationWithNext1;
        private People.ucPersonFilter_Add ucPersonFilter1;
    }
}