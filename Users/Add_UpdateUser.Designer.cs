namespace NewDVLD_Project.Users
{
    partial class Add_UpdateUser
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
            this.errPr = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpPersonalInfo = new System.Windows.Forms.TabPage();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.txtbConfirmPass = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbUserName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbpLoginInfo = new System.Windows.Forms.TabPage();
            this.ucPersonInformation1 = new NewDVLD_Project.People.ucPersonInformationWithNext();
            this.ucPersonFilter1 = new NewDVLD_Project.People.ucPersonFilter_Add();
            this.lblAdd_EditUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errPr)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbpPersonalInfo.SuspendLayout();
            this.tbpLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errPr
            // 
            this.errPr.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(560, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 51;
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
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpPersonalInfo);
            this.tabControl1.Controls.Add(this.tbpLoginInfo);
            this.tabControl1.Location = new System.Drawing.Point(22, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 342);
            this.tabControl1.TabIndex = 49;
            // 
            // tbpPersonalInfo
            // 
            this.tbpPersonalInfo.Controls.Add(this.cbIsActive);
            this.tbpPersonalInfo.Controls.Add(this.txtbConfirmPass);
            this.tbpPersonalInfo.Controls.Add(this.txtbPassword);
            this.tbpPersonalInfo.Controls.Add(this.txtbUserName);
            this.tbpPersonalInfo.Controls.Add(this.lblUserID);
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
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbIsActive.Location = new System.Drawing.Point(173, 174);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(67, 17);
            this.cbIsActive.TabIndex = 37;
            this.cbIsActive.Text = "Is Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // txtbConfirmPass
            // 
            this.txtbConfirmPass.Location = new System.Drawing.Point(173, 139);
            this.txtbConfirmPass.Name = "txtbConfirmPass";
            this.txtbConfirmPass.PasswordChar = '*';
            this.txtbConfirmPass.Size = new System.Drawing.Size(141, 20);
            this.txtbConfirmPass.TabIndex = 36;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(173, 105);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(141, 20);
            this.txtbPassword.TabIndex = 35;
            // 
            // txtbUserName
            // 
            this.txtbUserName.Location = new System.Drawing.Point(173, 72);
            this.txtbUserName.Name = "txtbUserName";
            this.txtbUserName.Size = new System.Drawing.Size(141, 20);
            this.txtbUserName.TabIndex = 34;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(172, 39);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(35, 18);
            this.lblUserID.TabIndex = 33;
            this.lblUserID.Text = "???";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(88, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "User ID : ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(60, 72);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(108, 18);
            this.lblUserName.TabIndex = 30;
            this.lblUserName.Text = "User Name : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(70, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Password : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 18);
            this.label14.TabIndex = 32;
            this.label14.Text = "Confirm Password : ";
            // 
            // tbpLoginInfo
            // 
            this.tbpLoginInfo.Controls.Add(this.ucPersonInformation1);
            this.tbpLoginInfo.Controls.Add(this.ucPersonFilter1);
            this.tbpLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tbpLoginInfo.Name = "tbpLoginInfo";
            this.tbpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLoginInfo.Size = new System.Drawing.Size(642, 316);
            this.tbpLoginInfo.TabIndex = 0;
            this.tbpLoginInfo.Text = "LoginInfo";
            this.tbpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // ucPersonInformation1
            // 
            this.ucPersonInformation1.Location = new System.Drawing.Point(8, 74);
            this.ucPersonInformation1.Name = "ucPersonInformation1";
            this.ucPersonInformation1.Size = new System.Drawing.Size(631, 226);
            this.ucPersonInformation1.TabIndex = 46;
            this.ucPersonInformation1.Load += new System.EventHandler(this.ucPersonInformation1_Load);
            // 
            // ucPersonFilter1
            // 
            this.ucPersonFilter1.Location = new System.Drawing.Point(7, 6);
            this.ucPersonFilter1.Name = "ucPersonFilter1";
            this.ucPersonFilter1.Size = new System.Drawing.Size(629, 62);
            this.ucPersonFilter1.TabIndex = 45;
            // 
            // lblAdd_EditUser
            // 
            this.lblAdd_EditUser.AutoSize = true;
            this.lblAdd_EditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd_EditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdd_EditUser.Location = new System.Drawing.Point(254, 26);
            this.lblAdd_EditUser.Name = "lblAdd_EditUser";
            this.lblAdd_EditUser.Size = new System.Drawing.Size(145, 24);
            this.lblAdd_EditUser.TabIndex = 48;
            this.lblAdd_EditUser.Text = "Add New User";
            // 
            // Add_UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 466);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblAdd_EditUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_UpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_UpdateUser";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errPr)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbpPersonalInfo.ResumeLayout(false);
            this.tbpPersonalInfo.PerformLayout();
            this.tbpLoginInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errPr;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpPersonalInfo;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.TextBox txtbConfirmPass;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tbpLoginInfo;
        private System.Windows.Forms.Label lblAdd_EditUser;
        private People.ucPersonFilter_Add ucPersonFilter1;
        private People.ucPersonInformationWithNext ucPersonInformation1;
    }
}