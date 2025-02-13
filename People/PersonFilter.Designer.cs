﻿namespace NewDVLD_Project.People
{
    partial class PersonFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonFilter));
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.mtxtbFind = new System.Windows.Forms.MaskedTextBox();
            this.pbSearchUser = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combItems = new System.Windows.Forms.ComboBox();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.mtxtbFind);
            this.gbFilter.Controls.Add(this.pbSearchUser);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.combItems);
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(621, 53);
            this.gbFilter.TabIndex = 65;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // mtxtbFind
            // 
            this.mtxtbFind.Location = new System.Drawing.Point(243, 19);
            this.mtxtbFind.Name = "mtxtbFind";
            this.mtxtbFind.Size = new System.Drawing.Size(168, 20);
            this.mtxtbFind.TabIndex = 5;
            this.mtxtbFind.ValidatingType = typeof(int);
            this.mtxtbFind.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtbFind_MaskInputRejected);
            this.mtxtbFind.Click += new System.EventHandler(this.mtxtbFind_Click);
            // 
            // pbSearchUser
            // 
            this.pbSearchUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSearchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchUser.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchUser.Image")));
            this.pbSearchUser.Location = new System.Drawing.Point(417, 13);
            this.pbSearchUser.Name = "pbSearchUser";
            this.pbSearchUser.Size = new System.Drawing.Size(31, 31);
            this.pbSearchUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchUser.TabIndex = 4;
            this.pbSearchUser.TabStop = false;
            this.pbSearchUser.Click += new System.EventHandler(this.pbSearchUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By : ";
            // 
            // combItems
            // 
            this.combItems.FormattingEnabled = true;
            this.combItems.Items.AddRange(new object[] {
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
            this.combItems.Location = new System.Drawing.Point(80, 19);
            this.combItems.Name = "combItems";
            this.combItems.Size = new System.Drawing.Size(157, 21);
            this.combItems.TabIndex = 1;
            // 
            // PersonFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Name = "PersonFilter";
            this.Size = new System.Drawing.Size(626, 59);
            this.Load += new System.EventHandler(this.PersonFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.MaskedTextBox mtxtbFind;
        private System.Windows.Forms.PictureBox pbSearchUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combItems;
    }
}
