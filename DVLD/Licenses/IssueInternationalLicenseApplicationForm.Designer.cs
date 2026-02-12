namespace DVLD.Applications
{
    partial class IssueInternationalLicenseApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueInternationalLicenseApplicationForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.applicationGroupBox = new System.Windows.Forms.GroupBox();
            this.createdByTxtBox = new System.Windows.Forms.TextBox();
            this.LocalLicenseIDTxtBox = new System.Windows.Forms.TextBox();
            this.ExpirationDateTxtBox = new System.Windows.Forms.TextBox();
            this.internationalLicenseIDTxtBox = new System.Windows.Forms.TextBox();
            this.feesTxtBox = new System.Windows.Forms.TextBox();
            this.issueDateTxtBox = new System.Windows.Forms.TextBox();
            this.applicationDateTxtBox = new System.Windows.Forms.TextBox();
            this.ApplicationIDTxtBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.ExpirationDateLabel = new System.Windows.Forms.Label();
            this.localLicenseIDLabel = new System.Windows.Forms.Label();
            this.feesLabel = new System.Windows.Forms.Label();
            this.issueDateLabel = new System.Windows.Forms.Label();
            this.applicationDateLabel = new System.Windows.Forms.Label();
            this.interantionalIDLabel = new System.Windows.Forms.Label();
            this.applicationIDLabel = new System.Windows.Forms.Label();
            this.buttomPanel = new System.Windows.Forms.Panel();
            this.ShowLicenseInfoBtn = new System.Windows.Forms.Button();
            this.showLicenseHistoryBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.issueBtn = new System.Windows.Forms.Button();
            this.drvierLicenseInfo_WithFilter1 = new DVLD.User_Controls.DrvierLicenseInfo_WithFilterUserControl();
            this.applicationGroupBox.SuspendLayout();
            this.buttomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(5, 5);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1055, 47);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "International License Application";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // applicationGroupBox
            // 
            this.applicationGroupBox.Controls.Add(this.createdByTxtBox);
            this.applicationGroupBox.Controls.Add(this.LocalLicenseIDTxtBox);
            this.applicationGroupBox.Controls.Add(this.ExpirationDateTxtBox);
            this.applicationGroupBox.Controls.Add(this.internationalLicenseIDTxtBox);
            this.applicationGroupBox.Controls.Add(this.feesTxtBox);
            this.applicationGroupBox.Controls.Add(this.issueDateTxtBox);
            this.applicationGroupBox.Controls.Add(this.applicationDateTxtBox);
            this.applicationGroupBox.Controls.Add(this.ApplicationIDTxtBox);
            this.applicationGroupBox.Controls.Add(this.userLabel);
            this.applicationGroupBox.Controls.Add(this.ExpirationDateLabel);
            this.applicationGroupBox.Controls.Add(this.localLicenseIDLabel);
            this.applicationGroupBox.Controls.Add(this.feesLabel);
            this.applicationGroupBox.Controls.Add(this.issueDateLabel);
            this.applicationGroupBox.Controls.Add(this.applicationDateLabel);
            this.applicationGroupBox.Controls.Add(this.interantionalIDLabel);
            this.applicationGroupBox.Controls.Add(this.applicationIDLabel);
            this.applicationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.applicationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationGroupBox.Location = new System.Drawing.Point(5, 667);
            this.applicationGroupBox.Name = "applicationGroupBox";
            this.applicationGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.applicationGroupBox.Size = new System.Drawing.Size(1055, 180);
            this.applicationGroupBox.TabIndex = 2;
            this.applicationGroupBox.TabStop = false;
            this.applicationGroupBox.Text = "Application Info";
            // 
            // createdByTxtBox
            // 
            this.createdByTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByTxtBox.Location = new System.Drawing.Point(928, 91);
            this.createdByTxtBox.Name = "createdByTxtBox";
            this.createdByTxtBox.ReadOnly = true;
            this.createdByTxtBox.Size = new System.Drawing.Size(121, 30);
            this.createdByTxtBox.TabIndex = 15;
            // 
            // LocalLicenseIDTxtBox
            // 
            this.LocalLicenseIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalLicenseIDTxtBox.Location = new System.Drawing.Point(942, 48);
            this.LocalLicenseIDTxtBox.Name = "LocalLicenseIDTxtBox";
            this.LocalLicenseIDTxtBox.ReadOnly = true;
            this.LocalLicenseIDTxtBox.Size = new System.Drawing.Size(107, 30);
            this.LocalLicenseIDTxtBox.TabIndex = 14;
            this.LocalLicenseIDTxtBox.Text = "N/A";
            // 
            // ExpirationDateTxtBox
            // 
            this.ExpirationDateTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDateTxtBox.Location = new System.Drawing.Point(712, 135);
            this.ExpirationDateTxtBox.Name = "ExpirationDateTxtBox";
            this.ExpirationDateTxtBox.ReadOnly = true;
            this.ExpirationDateTxtBox.Size = new System.Drawing.Size(203, 30);
            this.ExpirationDateTxtBox.TabIndex = 13;
            // 
            // internationalLicenseIDTxtBox
            // 
            this.internationalLicenseIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internationalLicenseIDTxtBox.Location = new System.Drawing.Point(621, 46);
            this.internationalLicenseIDTxtBox.Name = "internationalLicenseIDTxtBox";
            this.internationalLicenseIDTxtBox.ReadOnly = true;
            this.internationalLicenseIDTxtBox.Size = new System.Drawing.Size(85, 30);
            this.internationalLicenseIDTxtBox.TabIndex = 12;
            this.internationalLicenseIDTxtBox.Text = "N/A";
            // 
            // feesTxtBox
            // 
            this.feesTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesTxtBox.Location = new System.Drawing.Point(621, 93);
            this.feesTxtBox.Name = "feesTxtBox";
            this.feesTxtBox.ReadOnly = true;
            this.feesTxtBox.Size = new System.Drawing.Size(107, 30);
            this.feesTxtBox.TabIndex = 11;
            // 
            // issueDateTxtBox
            // 
            this.issueDateTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDateTxtBox.Location = new System.Drawing.Point(262, 137);
            this.issueDateTxtBox.Name = "issueDateTxtBox";
            this.issueDateTxtBox.ReadOnly = true;
            this.issueDateTxtBox.Size = new System.Drawing.Size(203, 30);
            this.issueDateTxtBox.TabIndex = 10;
            // 
            // applicationDateTxtBox
            // 
            this.applicationDateTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationDateTxtBox.Location = new System.Drawing.Point(262, 93);
            this.applicationDateTxtBox.Name = "applicationDateTxtBox";
            this.applicationDateTxtBox.ReadOnly = true;
            this.applicationDateTxtBox.Size = new System.Drawing.Size(203, 30);
            this.applicationDateTxtBox.TabIndex = 9;
            // 
            // ApplicationIDTxtBox
            // 
            this.ApplicationIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationIDTxtBox.Location = new System.Drawing.Point(262, 50);
            this.ApplicationIDTxtBox.Name = "ApplicationIDTxtBox";
            this.ApplicationIDTxtBox.ReadOnly = true;
            this.ApplicationIDTxtBox.Size = new System.Drawing.Size(107, 30);
            this.ApplicationIDTxtBox.TabIndex = 8;
            this.ApplicationIDTxtBox.Text = "N/A";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Image = global::DVLD.Properties.Resources.nameuser;
            this.userLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userLabel.Location = new System.Drawing.Point(740, 95);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(184, 26);
            this.userLabel.TabIndex = 7;
            this.userLabel.Text = "Created by  :        ";
            // 
            // ExpirationDateLabel
            // 
            this.ExpirationDateLabel.AutoSize = true;
            this.ExpirationDateLabel.Image = global::DVLD.Properties.Resources.dataofbirth;
            this.ExpirationDateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExpirationDateLabel.Location = new System.Drawing.Point(479, 137);
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            this.ExpirationDateLabel.Size = new System.Drawing.Size(227, 26);
            this.ExpirationDateLabel.TabIndex = 6;
            this.ExpirationDateLabel.Text = "Expiration Date  :        ";
            // 
            // localLicenseIDLabel
            // 
            this.localLicenseIDLabel.AutoSize = true;
            this.localLicenseIDLabel.Image = global::DVLD.Properties.Resources.namecard;
            this.localLicenseIDLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.localLicenseIDLabel.Location = new System.Drawing.Point(709, 48);
            this.localLicenseIDLabel.Name = "localLicenseIDLabel";
            this.localLicenseIDLabel.Size = new System.Drawing.Size(227, 26);
            this.localLicenseIDLabel.TabIndex = 5;
            this.localLicenseIDLabel.Text = "Local License ID :       ";
            // 
            // feesLabel
            // 
            this.feesLabel.AutoSize = true;
            this.feesLabel.Image = global::DVLD.Properties.Resources.coin;
            this.feesLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.feesLabel.Location = new System.Drawing.Point(479, 97);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(138, 26);
            this.feesLabel.TabIndex = 4;
            this.feesLabel.Text = "Fees  :          ";
            // 
            // issueDateLabel
            // 
            this.issueDateLabel.AutoSize = true;
            this.issueDateLabel.Image = global::DVLD.Properties.Resources.dataofbirth;
            this.issueDateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.issueDateLabel.Location = new System.Drawing.Point(25, 141);
            this.issueDateLabel.Name = "issueDateLabel";
            this.issueDateLabel.Size = new System.Drawing.Size(230, 26);
            this.issueDateLabel.TabIndex = 3;
            this.issueDateLabel.Text = "Issue Date  :                ";
            // 
            // applicationDateLabel
            // 
            this.applicationDateLabel.AutoSize = true;
            this.applicationDateLabel.Image = global::DVLD.Properties.Resources.dataofbirth;
            this.applicationDateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.applicationDateLabel.Location = new System.Drawing.Point(27, 99);
            this.applicationDateLabel.Name = "applicationDateLabel";
            this.applicationDateLabel.Size = new System.Drawing.Size(231, 26);
            this.applicationDateLabel.TabIndex = 2;
            this.applicationDateLabel.Text = "Application Date  :       ";
            // 
            // interantionalIDLabel
            // 
            this.interantionalIDLabel.AutoSize = true;
            this.interantionalIDLabel.Image = global::DVLD.Properties.Resources.internationalLicense;
            this.interantionalIDLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.interantionalIDLabel.Location = new System.Drawing.Point(388, 50);
            this.interantionalIDLabel.Name = "interantionalIDLabel";
            this.interantionalIDLabel.Size = new System.Drawing.Size(229, 26);
            this.interantionalIDLabel.TabIndex = 1;
            this.interantionalIDLabel.Text = "I.L  License ID :           ";
            // 
            // applicationIDLabel
            // 
            this.applicationIDLabel.AutoSize = true;
            this.applicationIDLabel.Image = global::DVLD.Properties.Resources.namecard;
            this.applicationIDLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.applicationIDLabel.Location = new System.Drawing.Point(27, 50);
            this.applicationIDLabel.Name = "applicationIDLabel";
            this.applicationIDLabel.Size = new System.Drawing.Size(231, 26);
            this.applicationIDLabel.TabIndex = 0;
            this.applicationIDLabel.Text = "I.L Application ID :       ";
            // 
            // buttomPanel
            // 
            this.buttomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttomPanel.Controls.Add(this.ShowLicenseInfoBtn);
            this.buttomPanel.Controls.Add(this.showLicenseHistoryBtn);
            this.buttomPanel.Controls.Add(this.closeBtn);
            this.buttomPanel.Controls.Add(this.issueBtn);
            this.buttomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttomPanel.Location = new System.Drawing.Point(5, 847);
            this.buttomPanel.Name = "buttomPanel";
            this.buttomPanel.Size = new System.Drawing.Size(1055, 64);
            this.buttomPanel.TabIndex = 3;
            // 
            // ShowLicenseInfoBtn
            // 
            this.ShowLicenseInfoBtn.Enabled = false;
            this.ShowLicenseInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLicenseInfoBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicenseInfoBtn.Image = global::DVLD.Properties.Resources.namecard;
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
            this.closeBtn.Location = new System.Drawing.Point(702, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(170, 45);
            this.closeBtn.TabIndex = 26;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // issueBtn
            // 
            this.issueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBtn.Image = global::DVLD.Properties.Resources.maps__1_;
            this.issueBtn.Location = new System.Drawing.Point(878, 6);
            this.issueBtn.Name = "issueBtn";
            this.issueBtn.Size = new System.Drawing.Size(170, 45);
            this.issueBtn.TabIndex = 25;
            this.issueBtn.Text = "Issue";
            this.issueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.issueBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.issueBtn.UseVisualStyleBackColor = true;
            this.issueBtn.Click += new System.EventHandler(this.issueBtn_Click);
            // 
            // drvierLicenseInfo_WithFilter1
            // 
            this.drvierLicenseInfo_WithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.drvierLicenseInfo_WithFilter1.Location = new System.Drawing.Point(5, 52);
            this.drvierLicenseInfo_WithFilter1.Name = "drvierLicenseInfo_WithFilter1";
            this.drvierLicenseInfo_WithFilter1.Size = new System.Drawing.Size(1055, 615);
            this.drvierLicenseInfo_WithFilter1.TabIndex = 0;
            // 
            // InternationalLicenseApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 905);
            this.Controls.Add(this.buttomPanel);
            this.Controls.Add(this.applicationGroupBox);
            this.Controls.Add(this.drvierLicenseInfo_WithFilter1);
            this.Controls.Add(this.headerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InternationalLicenseApplicationForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International License Application";
            this.Load += new System.EventHandler(this.InternationalLicenseApplicationForm_Load);
            this.applicationGroupBox.ResumeLayout(false);
            this.applicationGroupBox.PerformLayout();
            this.buttomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.DrvierLicenseInfo_WithFilterUserControl drvierLicenseInfo_WithFilter1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox applicationGroupBox;
        private System.Windows.Forms.Label applicationIDLabel;
        private System.Windows.Forms.Label localLicenseIDLabel;
        private System.Windows.Forms.Label feesLabel;
        private System.Windows.Forms.Label issueDateLabel;
        private System.Windows.Forms.Label applicationDateLabel;
        private System.Windows.Forms.Label interantionalIDLabel;
        private System.Windows.Forms.Label ExpirationDateLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox ApplicationIDTxtBox;
        private System.Windows.Forms.TextBox feesTxtBox;
        private System.Windows.Forms.TextBox issueDateTxtBox;
        private System.Windows.Forms.TextBox applicationDateTxtBox;
        private System.Windows.Forms.TextBox createdByTxtBox;
        private System.Windows.Forms.TextBox LocalLicenseIDTxtBox;
        private System.Windows.Forms.TextBox ExpirationDateTxtBox;
        private System.Windows.Forms.TextBox internationalLicenseIDTxtBox;
        private System.Windows.Forms.Panel buttomPanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button issueBtn;
        private System.Windows.Forms.Button ShowLicenseInfoBtn;
        private System.Windows.Forms.Button showLicenseHistoryBtn;
    }
}