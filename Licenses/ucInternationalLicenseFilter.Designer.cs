namespace NewDVLD_Project.Licenses
{
    partial class ucInternationalLicenseFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucInternationalLicenseFilter));
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.mtxtbFind = new System.Windows.Forms.MaskedTextBox();
            this.pbSearchLicense = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.mtxtbFind);
            this.gbFilter.Controls.Add(this.pbSearchLicense);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Location = new System.Drawing.Point(2, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(665, 53);
            this.gbFilter.TabIndex = 80;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // mtxtbFind
            // 
            this.mtxtbFind.Location = new System.Drawing.Point(198, 19);
            this.mtxtbFind.Mask = "00000";
            this.mtxtbFind.Name = "mtxtbFind";
            this.mtxtbFind.Size = new System.Drawing.Size(168, 20);
            this.mtxtbFind.TabIndex = 5;
            this.mtxtbFind.ValidatingType = typeof(int);
            // 
            // pbSearchLicense
            // 
            this.pbSearchLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSearchLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchLicense.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchLicense.Image")));
            this.pbSearchLicense.Location = new System.Drawing.Point(410, 13);
            this.pbSearchLicense.Name = "pbSearchLicense";
            this.pbSearchLicense.Size = new System.Drawing.Size(31, 31);
            this.pbSearchLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchLicense.TabIndex = 4;
            this.pbSearchLicense.TabStop = false;
            this.pbSearchLicense.Click += new System.EventHandler(this.pbSearchLicense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID : ";
            // 
            // ucInternationalLicenseFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Name = "ucInternationalLicenseFilter";
            this.Size = new System.Drawing.Size(670, 61);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchLicense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.MaskedTextBox mtxtbFind;
        private System.Windows.Forms.PictureBox pbSearchLicense;
        private System.Windows.Forms.Label label1;
    }
}
