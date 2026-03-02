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
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // application_Info_UserControl1
            // 
            this.application_Info_UserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.application_Info_UserControl1.Location = new System.Drawing.Point(0, 54);
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
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Image = global::DVLD.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(811, 519);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(170, 45);
            this.closeBtn.TabIndex = 43;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ShowApplicationDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(993, 571);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.application_Info_UserControl1);
            this.Controls.Add(this.headerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShowApplicationDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Details";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.Application_Info_UserControl application_Info_UserControl1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button closeBtn;
    }
}