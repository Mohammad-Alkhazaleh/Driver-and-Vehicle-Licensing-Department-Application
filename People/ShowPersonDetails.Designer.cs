namespace NewDVLD_Project.People
{
    partial class ShowPersonDetails
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
            this.ucPersonInformation1 = new NewDVLD_Project.People.ucPersonInformation();
            this.lblAdd_EditPerson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ucPersonInformation1
            // 
            this.ucPersonInformation1.Location = new System.Drawing.Point(3, 57);
            this.ucPersonInformation1.Name = "ucPersonInformation1";
            this.ucPersonInformation1.Size = new System.Drawing.Size(621, 220);
            this.ucPersonInformation1.TabIndex = 0;
            this.ucPersonInformation1.Load += new System.EventHandler(this.ucPersonInformation1_Load);
            // 
            // lblAdd_EditPerson
            // 
            this.lblAdd_EditPerson.AutoSize = true;
            this.lblAdd_EditPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd_EditPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdd_EditPerson.Location = new System.Drawing.Point(209, 17);
            this.lblAdd_EditPerson.Name = "lblAdd_EditPerson";
            this.lblAdd_EditPerson.Size = new System.Drawing.Size(205, 31);
            this.lblAdd_EditPerson.TabIndex = 68;
            this.lblAdd_EditPerson.Text = "Person Details";
            // 
            // ShowPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 278);
            this.Controls.Add(this.lblAdd_EditPerson);
            this.Controls.Add(this.ucPersonInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowPersonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPersonDetails";
            this.Load += new System.EventHandler(this.ShowPersonDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucPersonInformation ucPersonInformation1;
        private System.Windows.Forms.Label lblAdd_EditPerson;
    }
}