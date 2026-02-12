namespace DVLD.Applications
{
    partial class ShowApplicationDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowApplicationDetailsForm));
            this.application_Info_UserControl1 = new DVLD.User_Controls.Application_Info_UserControl();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // application_Info_UserControl1
            // 
            this.application_Info_UserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.application_Info_UserControl1.Location = new System.Drawing.Point(0, 57);
            this.application_Info_UserControl1.Name = "application_Info_UserControl1";
            this.application_Info_UserControl1.Padding = new System.Windows.Forms.Padding(3);
            this.application_Info_UserControl1.Size = new System.Drawing.Size(993, 459);
            this.application_Info_UserControl1.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Padding = new System.Windows.Forms.Padding(2);
            this.headerLabel.Size = new System.Drawing.Size(993, 54);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Application Details";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowApplicationDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 516);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.application_Info_UserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShowApplicationDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Details";
            this.Load += new System.EventHandler(this.ApplicationInfoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.Application_Info_UserControl application_Info_UserControl1;
        private System.Windows.Forms.Label headerLabel;
    }
}