namespace DVLD.User_Controls
{
    partial class Application_Info_UserControl
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
            this.DrivingLicenseApplicationInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowLicenseBtn = new System.Windows.Forms.Button();
            this.passedTxtBox = new System.Windows.Forms.TextBox();
            this.passedTestLabel = new System.Windows.Forms.Label();
            this.appliedForLicenseTxtBox = new System.Windows.Forms.TextBox();
            this.appliedForLicenseLabel = new System.Windows.Forms.Label();
            this.LDLA_IDtxtBox = new System.Windows.Forms.TextBox();
            this.DLA_ID_Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.applicantTxtBox = new System.Windows.Forms.TextBox();
            this.applicantLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.createdByLabel = new System.Windows.Forms.Label();
            this.startDateTxtBox = new System.Windows.Forms.TextBox();
            this.statusDateLabel = new System.Windows.Forms.Label();
            this.typeTxtBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.FessTxtBox = new System.Windows.Forms.TextBox();
            this.FeesLabel = new System.Windows.Forms.Label();
            this.statusTxtBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.DateTxtBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.applicationIDtxtBox = new System.Windows.Forms.TextBox();
            this.ApplicationID = new System.Windows.Forms.Label();
            this.DrivingLicenseApplicationInfoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrivingLicenseApplicationInfoGroupBox
            // 
            this.DrivingLicenseApplicationInfoGroupBox.Controls.Add(this.ShowLicenseBtn);
            this.DrivingLicenseApplicationInfoGroupBox.Controls.Add(this.passedTxtBox);
            this.DrivingLicenseApplicationInfoGroupBox.Controls.Add(this.passedTestLabel);
            this.DrivingLicenseApplicationInfoGroupBox.Controls.Add(this.appliedForLicenseTxtBox);
            this.DrivingLicenseApplicationInfoGroupBox.Controls.Add(this.appliedForLicenseLabel);
            this.DrivingLicenseApplicationInfoGroupBox.Controls.Add(this.LDLA_IDtxtBox);
            this.DrivingLicenseApplicationInfoGroupBox.Controls.Add(this.DLA_ID_Label);
            this.DrivingLicenseApplicationInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DrivingLicenseApplicationInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrivingLicenseApplicationInfoGroupBox.Location = new System.Drawing.Point(0, 0);
            this.DrivingLicenseApplicationInfoGroupBox.Name = "DrivingLicenseApplicationInfoGroupBox";
            this.DrivingLicenseApplicationInfoGroupBox.Size = new System.Drawing.Size(1014, 139);
            this.DrivingLicenseApplicationInfoGroupBox.TabIndex = 0;
            this.DrivingLicenseApplicationInfoGroupBox.TabStop = false;
            this.DrivingLicenseApplicationInfoGroupBox.Text = "Driving License Application Info";
            // 
            // ShowLicenseBtn
            // 
            this.ShowLicenseBtn.Enabled = false;
            this.ShowLicenseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicenseBtn.Image = global::DVLD.Properties.Resources.driverslicense;
            this.ShowLicenseBtn.Location = new System.Drawing.Point(24, 81);
            this.ShowLicenseBtn.Name = "ShowLicenseBtn";
            this.ShowLicenseBtn.Size = new System.Drawing.Size(271, 39);
            this.ShowLicenseBtn.TabIndex = 6;
            this.ShowLicenseBtn.Text = "Show License Info";
            this.ShowLicenseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowLicenseBtn.UseVisualStyleBackColor = true;
            this.ShowLicenseBtn.Click += new System.EventHandler(this.ShowLicenseBtn_Click);
            // 
            // passedTxtBox
            // 
            this.passedTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passedTxtBox.Location = new System.Drawing.Point(587, 81);
            this.passedTxtBox.Name = "passedTxtBox";
            this.passedTxtBox.ReadOnly = true;
            this.passedTxtBox.Size = new System.Drawing.Size(100, 32);
            this.passedTxtBox.TabIndex = 5;
            // 
            // passedTestLabel
            // 
            this.passedTestLabel.AutoSize = true;
            this.passedTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passedTestLabel.Image = global::DVLD.Properties.Resources.test;
            this.passedTestLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passedTestLabel.Location = new System.Drawing.Point(373, 81);
            this.passedTestLabel.Name = "passedTestLabel";
            this.passedTestLabel.Size = new System.Drawing.Size(208, 29);
            this.passedTestLabel.TabIndex = 4;
            this.passedTestLabel.Text = "Passed Tests  :     ";
            // 
            // appliedForLicenseTxtBox
            // 
            this.appliedForLicenseTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appliedForLicenseTxtBox.Location = new System.Drawing.Point(587, 43);
            this.appliedForLicenseTxtBox.Name = "appliedForLicenseTxtBox";
            this.appliedForLicenseTxtBox.ReadOnly = true;
            this.appliedForLicenseTxtBox.Size = new System.Drawing.Size(392, 32);
            this.appliedForLicenseTxtBox.TabIndex = 3;
            // 
            // appliedForLicenseLabel
            // 
            this.appliedForLicenseLabel.AutoSize = true;
            this.appliedForLicenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appliedForLicenseLabel.Image = global::DVLD.Properties.Resources.license;
            this.appliedForLicenseLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appliedForLicenseLabel.Location = new System.Drawing.Point(326, 43);
            this.appliedForLicenseLabel.Name = "appliedForLicenseLabel";
            this.appliedForLicenseLabel.Size = new System.Drawing.Size(255, 29);
            this.appliedForLicenseLabel.TabIndex = 2;
            this.appliedForLicenseLabel.Text = "Applied for license :     ";
            // 
            // LDLA_IDtxtBox
            // 
            this.LDLA_IDtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDLA_IDtxtBox.Location = new System.Drawing.Point(195, 43);
            this.LDLA_IDtxtBox.Name = "LDLA_IDtxtBox";
            this.LDLA_IDtxtBox.ReadOnly = true;
            this.LDLA_IDtxtBox.Size = new System.Drawing.Size(100, 32);
            this.LDLA_IDtxtBox.TabIndex = 1;
            // 
            // DLA_ID_Label
            // 
            this.DLA_ID_Label.AutoSize = true;
            this.DLA_ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLA_ID_Label.Image = global::DVLD.Properties.Resources.namecard;
            this.DLA_ID_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DLA_ID_Label.Location = new System.Drawing.Point(14, 43);
            this.DLA_ID_Label.Name = "DLA_ID_Label";
            this.DLA_ID_Label.Size = new System.Drawing.Size(175, 29);
            this.DLA_ID_Label.TabIndex = 0;
            this.DLA_ID_Label.Text = "D.L App ID :      ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.applicantTxtBox);
            this.groupBox1.Controls.Add(this.applicantLinkedLabel);
            this.groupBox1.Controls.Add(this.userTxtBox);
            this.groupBox1.Controls.Add(this.createdByLabel);
            this.groupBox1.Controls.Add(this.startDateTxtBox);
            this.groupBox1.Controls.Add(this.statusDateLabel);
            this.groupBox1.Controls.Add(this.typeTxtBox);
            this.groupBox1.Controls.Add(this.typeLabel);
            this.groupBox1.Controls.Add(this.FessTxtBox);
            this.groupBox1.Controls.Add(this.FeesLabel);
            this.groupBox1.Controls.Add(this.statusTxtBox);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.DateTxtBox);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.applicationIDtxtBox);
            this.groupBox1.Controls.Add(this.ApplicationID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 283);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Basic Info";
            // 
            // applicantTxtBox
            // 
            this.applicantTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicantTxtBox.Location = new System.Drawing.Point(141, 237);
            this.applicantTxtBox.Name = "applicantTxtBox";
            this.applicantTxtBox.ReadOnly = true;
            this.applicantTxtBox.Size = new System.Drawing.Size(392, 32);
            this.applicantTxtBox.TabIndex = 17;
            // 
            // applicantLinkedLabel
            // 
            this.applicantLinkedLabel.AutoSize = true;
            this.applicantLinkedLabel.Location = new System.Drawing.Point(19, 238);
            this.applicantLinkedLabel.Name = "applicantLinkedLabel";
            this.applicantLinkedLabel.Size = new System.Drawing.Size(121, 29);
            this.applicantLinkedLabel.TabIndex = 16;
            this.applicantLinkedLabel.TabStop = true;
            this.applicantLinkedLabel.Text = "Applicant";
            this.applicantLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.applicantLinkedLabel_LinkClicked);
            // 
            // userTxtBox
            // 
            this.userTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxtBox.Location = new System.Drawing.Point(815, 139);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.ReadOnly = true;
            this.userTxtBox.Size = new System.Drawing.Size(164, 32);
            this.userTxtBox.TabIndex = 15;
            // 
            // createdByLabel
            // 
            this.createdByLabel.AutoSize = true;
            this.createdByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByLabel.Image = global::DVLD.Properties.Resources.nameuser;
            this.createdByLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createdByLabel.Location = new System.Drawing.Point(637, 142);
            this.createdByLabel.Name = "createdByLabel";
            this.createdByLabel.Size = new System.Drawing.Size(172, 29);
            this.createdByLabel.TabIndex = 14;
            this.createdByLabel.Text = "Created by :     ";
            // 
            // startDateTxtBox
            // 
            this.startDateTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTxtBox.Location = new System.Drawing.Point(815, 93);
            this.startDateTxtBox.Name = "startDateTxtBox";
            this.startDateTxtBox.ReadOnly = true;
            this.startDateTxtBox.Size = new System.Drawing.Size(164, 32);
            this.startDateTxtBox.TabIndex = 13;
            // 
            // statusDateLabel
            // 
            this.statusDateLabel.AutoSize = true;
            this.statusDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDateLabel.Image = global::DVLD.Properties.Resources.dataofbirth;
            this.statusDateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusDateLabel.Location = new System.Drawing.Point(626, 93);
            this.statusDateLabel.Name = "statusDateLabel";
            this.statusDateLabel.Size = new System.Drawing.Size(183, 29);
            this.statusDateLabel.TabIndex = 12;
            this.statusDateLabel.Text = "Status Date :      ";
            // 
            // typeTxtBox
            // 
            this.typeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTxtBox.Location = new System.Drawing.Point(142, 188);
            this.typeTxtBox.Name = "typeTxtBox";
            this.typeTxtBox.ReadOnly = true;
            this.typeTxtBox.Size = new System.Drawing.Size(392, 32);
            this.typeTxtBox.TabIndex = 11;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Image = global::DVLD.Properties.Resources.license;
            this.typeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.typeLabel.Location = new System.Drawing.Point(14, 188);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(122, 29);
            this.typeLabel.TabIndex = 10;
            this.typeLabel.Text = "Type :       ";
            // 
            // FessTxtBox
            // 
            this.FessTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FessTxtBox.Location = new System.Drawing.Point(142, 140);
            this.FessTxtBox.Name = "FessTxtBox";
            this.FessTxtBox.ReadOnly = true;
            this.FessTxtBox.Size = new System.Drawing.Size(99, 32);
            this.FessTxtBox.TabIndex = 9;
            // 
            // FeesLabel
            // 
            this.FeesLabel.AutoSize = true;
            this.FeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesLabel.Image = global::DVLD.Properties.Resources.coin;
            this.FeesLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FeesLabel.Location = new System.Drawing.Point(14, 140);
            this.FeesLabel.Name = "FeesLabel";
            this.FeesLabel.Size = new System.Drawing.Size(122, 29);
            this.FeesLabel.TabIndex = 8;
            this.FeesLabel.Text = "Fees :       ";
            // 
            // statusTxtBox
            // 
            this.statusTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTxtBox.Location = new System.Drawing.Point(141, 90);
            this.statusTxtBox.Name = "statusTxtBox";
            this.statusTxtBox.ReadOnly = true;
            this.statusTxtBox.Size = new System.Drawing.Size(175, 32);
            this.statusTxtBox.TabIndex = 7;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Image = global::DVLD.Properties.Resources.status;
            this.statusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusLabel.Location = new System.Drawing.Point(14, 90);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(121, 29);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status :     ";
            // 
            // DateTxtBox
            // 
            this.DateTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTxtBox.Location = new System.Drawing.Point(815, 40);
            this.DateTxtBox.Name = "DateTxtBox";
            this.DateTxtBox.ReadOnly = true;
            this.DateTxtBox.Size = new System.Drawing.Size(164, 32);
            this.DateTxtBox.TabIndex = 3;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Image = global::DVLD.Properties.Resources.dataofbirth;
            this.dateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateLabel.Location = new System.Drawing.Point(698, 46);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(111, 29);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date :      ";
            // 
            // applicationIDtxtBox
            // 
            this.applicationIDtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationIDtxtBox.Location = new System.Drawing.Point(141, 42);
            this.applicationIDtxtBox.Name = "applicationIDtxtBox";
            this.applicationIDtxtBox.ReadOnly = true;
            this.applicationIDtxtBox.Size = new System.Drawing.Size(100, 32);
            this.applicationIDtxtBox.TabIndex = 1;
            // 
            // ApplicationID
            // 
            this.ApplicationID.AutoSize = true;
            this.ApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationID.Image = global::DVLD.Properties.Resources.namecard;
            this.ApplicationID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ApplicationID.Location = new System.Drawing.Point(14, 43);
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.Size = new System.Drawing.Size(120, 29);
            this.ApplicationID.TabIndex = 0;
            this.ApplicationID.Text = "ID :            ";
            // 
            // Application_Info_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DrivingLicenseApplicationInfoGroupBox);
            this.Name = "Application_Info_UserControl";
            this.Size = new System.Drawing.Size(1014, 435);
            this.Load += new System.EventHandler(this.Application_Info_UserControl_Load);
            this.DrivingLicenseApplicationInfoGroupBox.ResumeLayout(false);
            this.DrivingLicenseApplicationInfoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DrivingLicenseApplicationInfoGroupBox;
        private System.Windows.Forms.Label DLA_ID_Label;
        private System.Windows.Forms.TextBox LDLA_IDtxtBox;
        private System.Windows.Forms.TextBox appliedForLicenseTxtBox;
        private System.Windows.Forms.Label appliedForLicenseLabel;
        private System.Windows.Forms.TextBox passedTxtBox;
        private System.Windows.Forms.Label passedTestLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DateTxtBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox applicationIDtxtBox;
        private System.Windows.Forms.Label ApplicationID;
        private System.Windows.Forms.TextBox statusTxtBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox typeTxtBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox FessTxtBox;
        private System.Windows.Forms.Label FeesLabel;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.TextBox startDateTxtBox;
        private System.Windows.Forms.Label statusDateLabel;
        private System.Windows.Forms.TextBox applicantTxtBox;
        private System.Windows.Forms.LinkLabel applicantLinkedLabel;
        private System.Windows.Forms.Button ShowLicenseBtn;
    }
}
