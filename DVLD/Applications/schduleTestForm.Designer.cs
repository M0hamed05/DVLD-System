namespace DVLD.Applications
{
    partial class schduleTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schduleTestForm));
            this.picturePanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.FeesTxtBox = new System.Windows.Forms.TextBox();
            this.trialTxtBox = new System.Windows.Forms.TextBox();
            this.TestdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.LicenseTxtBox = new System.Windows.Forms.TextBox();
            this.applicationIDtxtBox = new System.Windows.Forms.TextBox();
            this.retakeInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.totalFeesTxtBox = new System.Windows.Forms.TextBox();
            this.r_appFeesTxtBox = new System.Windows.Forms.TextBox();
            this.retakeAppIDTxtBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.totalFees = new System.Windows.Forms.Label();
            this.r_appFeesLabel = new System.Windows.Forms.Label();
            this.retakeIDLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.FeesLabel = new System.Windows.Forms.Label();
            this.trialLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.LicenseLabel = new System.Windows.Forms.Label();
            this.ApplicationID = new System.Windows.Forms.Label();
            this.topicPictureBox = new System.Windows.Forms.PictureBox();
            this.picturePanel.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.retakeInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePanel
            // 
            this.picturePanel.Controls.Add(this.topicPictureBox);
            this.picturePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.picturePanel.Location = new System.Drawing.Point(0, 0);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(496, 100);
            this.picturePanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(0, 100);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Padding = new System.Windows.Forms.Padding(3);
            this.headerLabel.Size = new System.Drawing.Size(496, 41);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Schedule Test";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.FeesTxtBox);
            this.infoGroupBox.Controls.Add(this.FeesLabel);
            this.infoGroupBox.Controls.Add(this.trialTxtBox);
            this.infoGroupBox.Controls.Add(this.trialLabel);
            this.infoGroupBox.Controls.Add(this.TestdateTimePicker);
            this.infoGroupBox.Controls.Add(this.dateLabel);
            this.infoGroupBox.Controls.Add(this.nameLabel);
            this.infoGroupBox.Controls.Add(this.nameTxtBox);
            this.infoGroupBox.Controls.Add(this.LicenseTxtBox);
            this.infoGroupBox.Controls.Add(this.LicenseLabel);
            this.infoGroupBox.Controls.Add(this.applicationIDtxtBox);
            this.infoGroupBox.Controls.Add(this.ApplicationID);
            this.infoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGroupBox.Location = new System.Drawing.Point(0, 141);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(496, 338);
            this.infoGroupBox.TabIndex = 2;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Vision Test";
            // 
            // FeesTxtBox
            // 
            this.FeesTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesTxtBox.Location = new System.Drawing.Point(157, 287);
            this.FeesTxtBox.Name = "FeesTxtBox";
            this.FeesTxtBox.ReadOnly = true;
            this.FeesTxtBox.Size = new System.Drawing.Size(99, 32);
            this.FeesTxtBox.TabIndex = 26;
            // 
            // trialTxtBox
            // 
            this.trialTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trialTxtBox.Location = new System.Drawing.Point(157, 191);
            this.trialTxtBox.Name = "trialTxtBox";
            this.trialTxtBox.ReadOnly = true;
            this.trialTxtBox.Size = new System.Drawing.Size(100, 32);
            this.trialTxtBox.TabIndex = 24;
            // 
            // TestdateTimePicker
            // 
            this.TestdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TestdateTimePicker.Location = new System.Drawing.Point(157, 241);
            this.TestdateTimePicker.MinDate = new System.DateTime(2026, 2, 5, 0, 0, 0, 0);
            this.TestdateTimePicker.Name = "TestdateTimePicker";
            this.TestdateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.TestdateTimePicker.TabIndex = 22;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.Location = new System.Drawing.Point(157, 145);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.ReadOnly = true;
            this.nameTxtBox.Size = new System.Drawing.Size(317, 32);
            this.nameTxtBox.TabIndex = 19;
            // 
            // LicenseTxtBox
            // 
            this.LicenseTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseTxtBox.Location = new System.Drawing.Point(157, 97);
            this.LicenseTxtBox.Name = "LicenseTxtBox";
            this.LicenseTxtBox.ReadOnly = true;
            this.LicenseTxtBox.Size = new System.Drawing.Size(317, 32);
            this.LicenseTxtBox.TabIndex = 5;
            // 
            // applicationIDtxtBox
            // 
            this.applicationIDtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationIDtxtBox.Location = new System.Drawing.Point(194, 38);
            this.applicationIDtxtBox.Name = "applicationIDtxtBox";
            this.applicationIDtxtBox.ReadOnly = true;
            this.applicationIDtxtBox.Size = new System.Drawing.Size(100, 32);
            this.applicationIDtxtBox.TabIndex = 3;
            // 
            // retakeInfoGroupBox
            // 
            this.retakeInfoGroupBox.Controls.Add(this.totalFeesTxtBox);
            this.retakeInfoGroupBox.Controls.Add(this.totalFees);
            this.retakeInfoGroupBox.Controls.Add(this.r_appFeesTxtBox);
            this.retakeInfoGroupBox.Controls.Add(this.r_appFeesLabel);
            this.retakeInfoGroupBox.Controls.Add(this.retakeAppIDTxtBox);
            this.retakeInfoGroupBox.Controls.Add(this.retakeIDLabel);
            this.retakeInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.retakeInfoGroupBox.Enabled = false;
            this.retakeInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retakeInfoGroupBox.Location = new System.Drawing.Point(0, 479);
            this.retakeInfoGroupBox.Name = "retakeInfoGroupBox";
            this.retakeInfoGroupBox.Size = new System.Drawing.Size(496, 188);
            this.retakeInfoGroupBox.TabIndex = 3;
            this.retakeInfoGroupBox.TabStop = false;
            this.retakeInfoGroupBox.Text = "Retake test info";
            // 
            // totalFeesTxtBox
            // 
            this.totalFeesTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFeesTxtBox.Location = new System.Drawing.Point(235, 133);
            this.totalFeesTxtBox.Name = "totalFeesTxtBox";
            this.totalFeesTxtBox.ReadOnly = true;
            this.totalFeesTxtBox.Size = new System.Drawing.Size(99, 32);
            this.totalFeesTxtBox.TabIndex = 30;
            // 
            // r_appFeesTxtBox
            // 
            this.r_appFeesTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_appFeesTxtBox.Location = new System.Drawing.Point(235, 87);
            this.r_appFeesTxtBox.Name = "r_appFeesTxtBox";
            this.r_appFeesTxtBox.ReadOnly = true;
            this.r_appFeesTxtBox.Size = new System.Drawing.Size(99, 32);
            this.r_appFeesTxtBox.TabIndex = 28;
            // 
            // retakeAppIDTxtBox
            // 
            this.retakeAppIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retakeAppIDTxtBox.Location = new System.Drawing.Point(235, 38);
            this.retakeAppIDTxtBox.Name = "retakeAppIDTxtBox";
            this.retakeAppIDTxtBox.ReadOnly = true;
            this.retakeAppIDTxtBox.Size = new System.Drawing.Size(100, 32);
            this.retakeAppIDTxtBox.TabIndex = 3;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Image = global::DVLD.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(138, 673);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(170, 45);
            this.closeBtn.TabIndex = 32;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // totalFees
            // 
            this.totalFees.AutoSize = true;
            this.totalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFees.Image = global::DVLD.Properties.Resources.coin;
            this.totalFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalFees.Location = new System.Drawing.Point(13, 136);
            this.totalFees.Name = "totalFees";
            this.totalFees.Size = new System.Drawing.Size(219, 29);
            this.totalFees.TabIndex = 29;
            this.totalFees.Text = "Total Fees :             ";
            // 
            // r_appFeesLabel
            // 
            this.r_appFeesLabel.AutoSize = true;
            this.r_appFeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_appFeesLabel.Image = global::DVLD.Properties.Resources.coin;
            this.r_appFeesLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.r_appFeesLabel.Location = new System.Drawing.Point(13, 90);
            this.r_appFeesLabel.Name = "r_appFeesLabel";
            this.r_appFeesLabel.Size = new System.Drawing.Size(218, 29);
            this.r_appFeesLabel.TabIndex = 27;
            this.r_appFeesLabel.Text = "R. App Fees :          ";
            // 
            // retakeIDLabel
            // 
            this.retakeIDLabel.AutoSize = true;
            this.retakeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retakeIDLabel.Image = global::DVLD.Properties.Resources.namecard;
            this.retakeIDLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.retakeIDLabel.Location = new System.Drawing.Point(13, 39);
            this.retakeIDLabel.Name = "retakeIDLabel";
            this.retakeIDLabel.Size = new System.Drawing.Size(216, 29);
            this.retakeIDLabel.TabIndex = 2;
            this.retakeIDLabel.Text = "R.Test App ID  :      ";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Image = global::DVLD.Properties.Resources.save;
            this.saveBtn.Location = new System.Drawing.Point(314, 673);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(170, 45);
            this.saveBtn.TabIndex = 31;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // FeesLabel
            // 
            this.FeesLabel.AutoSize = true;
            this.FeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesLabel.Image = global::DVLD.Properties.Resources.coin;
            this.FeesLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FeesLabel.Location = new System.Drawing.Point(13, 290);
            this.FeesLabel.Name = "FeesLabel";
            this.FeesLabel.Size = new System.Drawing.Size(140, 29);
            this.FeesLabel.TabIndex = 25;
            this.FeesLabel.Text = "Fees :          ";
            // 
            // trialLabel
            // 
            this.trialLabel.AutoSize = true;
            this.trialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trialLabel.Image = global::DVLD.Properties.Resources.counter;
            this.trialLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trialLabel.Location = new System.Drawing.Point(13, 192);
            this.trialLabel.Name = "trialLabel";
            this.trialLabel.Size = new System.Drawing.Size(134, 29);
            this.trialLabel.TabIndex = 23;
            this.trialLabel.Text = "Trial :          ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Image = global::DVLD.Properties.Resources.dataofbirth;
            this.dateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateLabel.Location = new System.Drawing.Point(13, 239);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(135, 29);
            this.dateLabel.TabIndex = 21;
            this.dateLabel.Text = "Date :          ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Image = global::DVLD.Properties.Resources.nameuser;
            this.nameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nameLabel.Location = new System.Drawing.Point(13, 146);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(132, 29);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Name :       ";
            // 
            // LicenseLabel
            // 
            this.LicenseLabel.AutoSize = true;
            this.LicenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseLabel.Image = global::DVLD.Properties.Resources.license;
            this.LicenseLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LicenseLabel.Location = new System.Drawing.Point(12, 97);
            this.LicenseLabel.Name = "LicenseLabel";
            this.LicenseLabel.Size = new System.Drawing.Size(138, 29);
            this.LicenseLabel.TabIndex = 4;
            this.LicenseLabel.Text = "D.Class :     ";
            // 
            // ApplicationID
            // 
            this.ApplicationID.AutoSize = true;
            this.ApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationID.Image = global::DVLD.Properties.Resources.namecard;
            this.ApplicationID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ApplicationID.Location = new System.Drawing.Point(13, 39);
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.Size = new System.Drawing.Size(175, 29);
            this.ApplicationID.TabIndex = 2;
            this.ApplicationID.Text = "D.L App ID :      ";
            // 
            // topicPictureBox
            // 
            this.topicPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicPictureBox.Image = global::DVLD.Properties.Resources.eye;
            this.topicPictureBox.Location = new System.Drawing.Point(0, 0);
            this.topicPictureBox.Name = "topicPictureBox";
            this.topicPictureBox.Size = new System.Drawing.Size(496, 100);
            this.topicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topicPictureBox.TabIndex = 0;
            this.topicPictureBox.TabStop = false;
            // 
            // schduleTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 730);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.retakeInfoGroupBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.picturePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "schduleTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "schedule Test";
            this.picturePanel.ResumeLayout(false);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.retakeInfoGroupBox.ResumeLayout(false);
            this.retakeInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.PictureBox topicPictureBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.TextBox applicationIDtxtBox;
        private System.Windows.Forms.Label ApplicationID;
        private System.Windows.Forms.TextBox LicenseTxtBox;
        private System.Windows.Forms.Label LicenseLabel;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DateTimePicker TestdateTimePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox trialTxtBox;
        private System.Windows.Forms.Label trialLabel;
        private System.Windows.Forms.TextBox FeesTxtBox;
        private System.Windows.Forms.Label FeesLabel;
        private System.Windows.Forms.GroupBox retakeInfoGroupBox;
        private System.Windows.Forms.TextBox retakeAppIDTxtBox;
        private System.Windows.Forms.Label retakeIDLabel;
        private System.Windows.Forms.TextBox totalFeesTxtBox;
        private System.Windows.Forms.Label totalFees;
        private System.Windows.Forms.TextBox r_appFeesTxtBox;
        private System.Windows.Forms.Label r_appFeesLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}