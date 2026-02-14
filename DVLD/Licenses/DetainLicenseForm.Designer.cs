namespace DVLD.Licenses
{
    partial class DetainLicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetainLicenseForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.drvierLicenseInfo_WithFilterUserControl1 = new DVLD.User_Controls.DrvierLicenseInfo_WithFilterUserControl();
            this.RenewApplicationInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.FineFeesTxtBox = new System.Windows.Forms.TextBox();
            this.ApplicationDateTxtBox = new System.Windows.Forms.TextBox();
            this.createdByTxtBox = new System.Windows.Forms.TextBox();
            this.LicenseIDTxtBox = new System.Windows.Forms.TextBox();
            this.detainIDTxtBox = new System.Windows.Forms.TextBox();
            this.buttomPanel = new System.Windows.Forms.Panel();
            this.ShowLicenseInfoBtn = new System.Windows.Forms.Button();
            this.showLicenseHistoryBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.DetainBtn = new System.Windows.Forms.Button();
            this.FineFeesLabel = new System.Windows.Forms.Label();
            this.createdByLabel = new System.Windows.Forms.Label();
            this.DetainDateLabel = new System.Windows.Forms.Label();
            this.LicenseIDLabel = new System.Windows.Forms.Label();
            this.detainIDLabel = new System.Windows.Forms.Label();
            this.RenewApplicationInfoGroupBox.SuspendLayout();
            this.buttomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(3, 3);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1054, 43);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Detain License";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drvierLicenseInfo_WithFilterUserControl1
            // 
            this.drvierLicenseInfo_WithFilterUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.drvierLicenseInfo_WithFilterUserControl1.Location = new System.Drawing.Point(3, 46);
            this.drvierLicenseInfo_WithFilterUserControl1.Name = "drvierLicenseInfo_WithFilterUserControl1";
            this.drvierLicenseInfo_WithFilterUserControl1.Size = new System.Drawing.Size(1054, 624);
            this.drvierLicenseInfo_WithFilterUserControl1.TabIndex = 2;
            // 
            // RenewApplicationInfoGroupBox
            // 
            this.RenewApplicationInfoGroupBox.Controls.Add(this.FineFeesTxtBox);
            this.RenewApplicationInfoGroupBox.Controls.Add(this.ApplicationDateTxtBox);
            this.RenewApplicationInfoGroupBox.Controls.Add(this.createdByTxtBox);
            this.RenewApplicationInfoGroupBox.Controls.Add(this.FineFeesLabel);
            this.RenewApplicationInfoGroupBox.Controls.Add(this.createdByLabel);
            this.RenewApplicationInfoGroupBox.Controls.Add(this.DetainDateLabel);
            this.RenewApplicationInfoGroupBox.Controls.Add(this.LicenseIDTxtBox);
            this.RenewApplicationInfoGroupBox.Controls.Add(this.detainIDTxtBox);
            this.RenewApplicationInfoGroupBox.Controls.Add(this.LicenseIDLabel);
            this.RenewApplicationInfoGroupBox.Controls.Add(this.detainIDLabel);
            this.RenewApplicationInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RenewApplicationInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenewApplicationInfoGroupBox.Location = new System.Drawing.Point(3, 670);
            this.RenewApplicationInfoGroupBox.Name = "RenewApplicationInfoGroupBox";
            this.RenewApplicationInfoGroupBox.Size = new System.Drawing.Size(1054, 134);
            this.RenewApplicationInfoGroupBox.TabIndex = 4;
            this.RenewApplicationInfoGroupBox.TabStop = false;
            this.RenewApplicationInfoGroupBox.Text = "Detain Info";
            // 
            // FineFeesTxtBox
            // 
            this.FineFeesTxtBox.Location = new System.Drawing.Point(547, 87);
            this.FineFeesTxtBox.Name = "FineFeesTxtBox";
            this.FineFeesTxtBox.Size = new System.Drawing.Size(124, 32);
            this.FineFeesTxtBox.TabIndex = 17;
            this.FineFeesTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FineFeesTxtBox_KeyPress);
            // 
            // ApplicationDateTxtBox
            // 
            this.ApplicationDateTxtBox.Location = new System.Drawing.Point(205, 84);
            this.ApplicationDateTxtBox.Name = "ApplicationDateTxtBox";
            this.ApplicationDateTxtBox.ReadOnly = true;
            this.ApplicationDateTxtBox.Size = new System.Drawing.Size(148, 32);
            this.ApplicationDateTxtBox.TabIndex = 11;
            // 
            // createdByTxtBox
            // 
            this.createdByTxtBox.Location = new System.Drawing.Point(891, 34);
            this.createdByTxtBox.Name = "createdByTxtBox";
            this.createdByTxtBox.ReadOnly = true;
            this.createdByTxtBox.Size = new System.Drawing.Size(145, 32);
            this.createdByTxtBox.TabIndex = 10;
            // 
            // LicenseIDTxtBox
            // 
            this.LicenseIDTxtBox.Location = new System.Drawing.Point(547, 34);
            this.LicenseIDTxtBox.Name = "LicenseIDTxtBox";
            this.LicenseIDTxtBox.ReadOnly = true;
            this.LicenseIDTxtBox.Size = new System.Drawing.Size(124, 32);
            this.LicenseIDTxtBox.TabIndex = 3;
            this.LicenseIDTxtBox.Text = "N/A";
            // 
            // detainIDTxtBox
            // 
            this.detainIDTxtBox.Location = new System.Drawing.Point(205, 38);
            this.detainIDTxtBox.Name = "detainIDTxtBox";
            this.detainIDTxtBox.ReadOnly = true;
            this.detainIDTxtBox.Size = new System.Drawing.Size(100, 32);
            this.detainIDTxtBox.TabIndex = 2;
            this.detainIDTxtBox.Text = "N/A";
            // 
            // buttomPanel
            // 
            this.buttomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttomPanel.Controls.Add(this.ShowLicenseInfoBtn);
            this.buttomPanel.Controls.Add(this.showLicenseHistoryBtn);
            this.buttomPanel.Controls.Add(this.closeBtn);
            this.buttomPanel.Controls.Add(this.DetainBtn);
            this.buttomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttomPanel.Location = new System.Drawing.Point(3, 804);
            this.buttomPanel.Name = "buttomPanel";
            this.buttomPanel.Size = new System.Drawing.Size(1054, 64);
            this.buttomPanel.TabIndex = 6;
            // 
            // ShowLicenseInfoBtn
            // 
            this.ShowLicenseInfoBtn.Enabled = false;
            this.ShowLicenseInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLicenseInfoBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicenseInfoBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowLicenseInfoBtn.Image")));
            this.ShowLicenseInfoBtn.Location = new System.Drawing.Point(261, 6);
            this.ShowLicenseInfoBtn.Name = "ShowLicenseInfoBtn";
            this.ShowLicenseInfoBtn.Size = new System.Drawing.Size(237, 45);
            this.ShowLicenseInfoBtn.TabIndex = 28;
            this.ShowLicenseInfoBtn.Text = "Show license info";
            this.ShowLicenseInfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowLicenseInfoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowLicenseInfoBtn.UseVisualStyleBackColor = true;
            this.ShowLicenseInfoBtn.Click += new System.EventHandler(this.ShowLicenseInfoBtn_Click);
            // 
            // showLicenseHistoryBtn
            // 
            this.showLicenseHistoryBtn.Enabled = false;
            this.showLicenseHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showLicenseHistoryBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLicenseHistoryBtn.Image = global::DVLD.Properties.Resources.personhisory;
            this.showLicenseHistoryBtn.Location = new System.Drawing.Point(6, 6);
            this.showLicenseHistoryBtn.Name = "showLicenseHistoryBtn";
            this.showLicenseHistoryBtn.Size = new System.Drawing.Size(248, 45);
            this.showLicenseHistoryBtn.TabIndex = 27;
            this.showLicenseHistoryBtn.Text = "Show license Hisoty";
            this.showLicenseHistoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showLicenseHistoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.showLicenseHistoryBtn.UseVisualStyleBackColor = true;
            this.showLicenseHistoryBtn.Click += new System.EventHandler(this.showLicenseHistoryBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Image = global::DVLD.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(714, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(170, 45);
            this.closeBtn.TabIndex = 26;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // DetainBtn
            // 
            this.DetainBtn.Enabled = false;
            this.DetainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetainBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetainBtn.Image = global::DVLD.Properties.Resources.detainCardBlack;
            this.DetainBtn.Location = new System.Drawing.Point(890, 6);
            this.DetainBtn.Name = "DetainBtn";
            this.DetainBtn.Size = new System.Drawing.Size(158, 45);
            this.DetainBtn.TabIndex = 25;
            this.DetainBtn.Text = "Detain";
            this.DetainBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DetainBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DetainBtn.UseVisualStyleBackColor = true;
            this.DetainBtn.Click += new System.EventHandler(this.DetainBtn_Click);
            // 
            // FineFeesLabel
            // 
            this.FineFeesLabel.AutoSize = true;
            this.FineFeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FineFeesLabel.Image = ((System.Drawing.Image)(resources.GetObject("FineFeesLabel.Image")));
            this.FineFeesLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FineFeesLabel.Location = new System.Drawing.Point(378, 90);
            this.FineFeesLabel.Name = "FineFeesLabel";
            this.FineFeesLabel.Size = new System.Drawing.Size(162, 26);
            this.FineFeesLabel.TabIndex = 9;
            this.FineFeesLabel.Text = "Fine Fees :       ";
            // 
            // createdByLabel
            // 
            this.createdByLabel.AutoSize = true;
            this.createdByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByLabel.Image = ((System.Drawing.Image)(resources.GetObject("createdByLabel.Image")));
            this.createdByLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createdByLabel.Location = new System.Drawing.Point(728, 37);
            this.createdByLabel.Name = "createdByLabel";
            this.createdByLabel.Size = new System.Drawing.Size(157, 26);
            this.createdByLabel.TabIndex = 8;
            this.createdByLabel.Text = "Created By:     ";
            // 
            // DetainDateLabel
            // 
            this.DetainDateLabel.AutoSize = true;
            this.DetainDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetainDateLabel.Image = ((System.Drawing.Image)(resources.GetObject("DetainDateLabel.Image")));
            this.DetainDateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DetainDateLabel.Location = new System.Drawing.Point(12, 87);
            this.DetainDateLabel.Name = "DetainDateLabel";
            this.DetainDateLabel.Size = new System.Drawing.Size(187, 26);
            this.DetainDateLabel.TabIndex = 4;
            this.DetainDateLabel.Text = "Detain Date  :       ";
            // 
            // LicenseIDLabel
            // 
            this.LicenseIDLabel.AutoSize = true;
            this.LicenseIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseIDLabel.Image = ((System.Drawing.Image)(resources.GetObject("LicenseIDLabel.Image")));
            this.LicenseIDLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LicenseIDLabel.Location = new System.Drawing.Point(376, 37);
            this.LicenseIDLabel.Name = "LicenseIDLabel";
            this.LicenseIDLabel.Size = new System.Drawing.Size(165, 25);
            this.LicenseIDLabel.TabIndex = 1;
            this.LicenseIDLabel.Text = "License ID :          ";
            // 
            // detainIDLabel
            // 
            this.detainIDLabel.AutoSize = true;
            this.detainIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detainIDLabel.Image = ((System.Drawing.Image)(resources.GetObject("detainIDLabel.Image")));
            this.detainIDLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.detainIDLabel.Location = new System.Drawing.Point(12, 44);
            this.detainIDLabel.Name = "detainIDLabel";
            this.detainIDLabel.Size = new System.Drawing.Size(187, 26);
            this.detainIDLabel.TabIndex = 0;
            this.detainIDLabel.Text = "Detain ID :            ";
            // 
            // DetainLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 874);
            this.Controls.Add(this.buttomPanel);
            this.Controls.Add(this.RenewApplicationInfoGroupBox);
            this.Controls.Add(this.drvierLicenseInfo_WithFilterUserControl1);
            this.Controls.Add(this.headerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetainLicenseForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detain License";
            this.Load += new System.EventHandler(this.DetainLicenseForm_Load);
            this.RenewApplicationInfoGroupBox.ResumeLayout(false);
            this.RenewApplicationInfoGroupBox.PerformLayout();
            this.buttomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private User_Controls.DrvierLicenseInfo_WithFilterUserControl drvierLicenseInfo_WithFilterUserControl1;
        private System.Windows.Forms.GroupBox RenewApplicationInfoGroupBox;
        private System.Windows.Forms.TextBox FineFeesTxtBox;
        private System.Windows.Forms.TextBox ApplicationDateTxtBox;
        private System.Windows.Forms.TextBox createdByTxtBox;
        private System.Windows.Forms.Label FineFeesLabel;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.Label DetainDateLabel;
        private System.Windows.Forms.TextBox LicenseIDTxtBox;
        private System.Windows.Forms.TextBox detainIDTxtBox;
        private System.Windows.Forms.Label LicenseIDLabel;
        private System.Windows.Forms.Label detainIDLabel;
        private System.Windows.Forms.Panel buttomPanel;
        private System.Windows.Forms.Button ShowLicenseInfoBtn;
        private System.Windows.Forms.Button showLicenseHistoryBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button DetainBtn;
    }
}