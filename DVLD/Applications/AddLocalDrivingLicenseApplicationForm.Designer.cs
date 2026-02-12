namespace DVLD
{
    partial class AddLocalDrivingLicenseApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLocalDrivingLicenseApplicationForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.nextBtnPanel = new System.Windows.Forms.Panel();
            this.nxtBtn = new System.Windows.Forms.Button();
            this.buttomPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.applicationInfoPanel = new System.Windows.Forms.Panel();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.feesTxtBox = new System.Windows.Forms.TextBox();
            this.dateTxtBox = new System.Windows.Forms.TextBox();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.applicationFeesLabel = new System.Windows.Forms.Label();
            this.licenseClassComboBox = new System.Windows.Forms.ComboBox();
            this.licenseClassLabel = new System.Windows.Forms.Label();
            this.applicationDateLabel = new System.Windows.Forms.Label();
            this.DLAppicationIdLabel = new System.Windows.Forms.Label();
            this.peersonInfoWithFilterUserControl1 = new DVLD.PeersonInfoWithFilterUserControl();
            this.nextBtnPanel.SuspendLayout();
            this.buttomPanel.SuspendLayout();
            this.applicationInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(5, 5);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1092, 54);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "New Local Driving License Applications ";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nextBtnPanel
            // 
            this.nextBtnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nextBtnPanel.Controls.Add(this.nxtBtn);
            this.nextBtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nextBtnPanel.Location = new System.Drawing.Point(5, 519);
            this.nextBtnPanel.Name = "nextBtnPanel";
            this.nextBtnPanel.Size = new System.Drawing.Size(1092, 60);
            this.nextBtnPanel.TabIndex = 5;
            // 
            // nxtBtn
            // 
            this.nxtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nxtBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxtBtn.Image = global::DVLD.Properties.Resources.next;
            this.nxtBtn.Location = new System.Drawing.Point(10, 6);
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.Size = new System.Drawing.Size(170, 45);
            this.nxtBtn.TabIndex = 27;
            this.nxtBtn.Text = "Next";
            this.nxtBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nxtBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.nxtBtn.UseVisualStyleBackColor = true;
            this.nxtBtn.Click += new System.EventHandler(this.nxtBtn_Click);
            // 
            // buttomPanel
            // 
            this.buttomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttomPanel.Controls.Add(this.closeBtn);
            this.buttomPanel.Controls.Add(this.saveBtn);
            this.buttomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttomPanel.Location = new System.Drawing.Point(5, 707);
            this.buttomPanel.Name = "buttomPanel";
            this.buttomPanel.Size = new System.Drawing.Size(1092, 62);
            this.buttomPanel.TabIndex = 6;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Image = global::DVLD.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(744, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(170, 45);
            this.closeBtn.TabIndex = 26;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Image = global::DVLD.Properties.Resources.save;
            this.saveBtn.Location = new System.Drawing.Point(920, 6);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(170, 45);
            this.saveBtn.TabIndex = 25;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // applicationInfoPanel
            // 
            this.applicationInfoPanel.Controls.Add(this.usernameTxtBox);
            this.applicationInfoPanel.Controls.Add(this.feesTxtBox);
            this.applicationInfoPanel.Controls.Add(this.dateTxtBox);
            this.applicationInfoPanel.Controls.Add(this.idTxtBox);
            this.applicationInfoPanel.Controls.Add(this.label1);
            this.applicationInfoPanel.Controls.Add(this.applicationFeesLabel);
            this.applicationInfoPanel.Controls.Add(this.licenseClassComboBox);
            this.applicationInfoPanel.Controls.Add(this.licenseClassLabel);
            this.applicationInfoPanel.Controls.Add(this.applicationDateLabel);
            this.applicationInfoPanel.Controls.Add(this.DLAppicationIdLabel);
            this.applicationInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.applicationInfoPanel.Location = new System.Drawing.Point(5, 579);
            this.applicationInfoPanel.Name = "applicationInfoPanel";
            this.applicationInfoPanel.Size = new System.Drawing.Size(1092, 128);
            this.applicationInfoPanel.TabIndex = 7;
            this.applicationInfoPanel.Visible = false;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(275, 86);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.ReadOnly = true;
            this.usernameTxtBox.Size = new System.Drawing.Size(215, 32);
            this.usernameTxtBox.TabIndex = 9;
            // 
            // feesTxtBox
            // 
            this.feesTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesTxtBox.Location = new System.Drawing.Point(745, 52);
            this.feesTxtBox.Name = "feesTxtBox";
            this.feesTxtBox.ReadOnly = true;
            this.feesTxtBox.Size = new System.Drawing.Size(100, 32);
            this.feesTxtBox.TabIndex = 8;
            this.feesTxtBox.Text = "15";
            // 
            // dateTxtBox
            // 
            this.dateTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTxtBox.Location = new System.Drawing.Point(275, 49);
            this.dateTxtBox.Name = "dateTxtBox";
            this.dateTxtBox.ReadOnly = true;
            this.dateTxtBox.Size = new System.Drawing.Size(215, 32);
            this.dateTxtBox.TabIndex = 7;
            // 
            // idTxtBox
            // 
            this.idTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtBox.Location = new System.Drawing.Point(275, 11);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.ReadOnly = true;
            this.idTxtBox.Size = new System.Drawing.Size(113, 32);
            this.idTxtBox.TabIndex = 6;
            this.idTxtBox.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::DVLD.Properties.Resources.nameuser;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Created By :                ";
            // 
            // applicationFeesLabel
            // 
            this.applicationFeesLabel.AutoSize = true;
            this.applicationFeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationFeesLabel.Image = global::DVLD.Properties.Resources.coin;
            this.applicationFeesLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.applicationFeesLabel.Location = new System.Drawing.Point(496, 52);
            this.applicationFeesLabel.Name = "applicationFeesLabel";
            this.applicationFeesLabel.Size = new System.Drawing.Size(245, 26);
            this.applicationFeesLabel.TabIndex = 4;
            this.applicationFeesLabel.Text = "Application Fees :      ";
            // 
            // licenseClassComboBox
            // 
            this.licenseClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.licenseClassComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseClassComboBox.FormattingEnabled = true;
            this.licenseClassComboBox.Location = new System.Drawing.Point(745, 9);
            this.licenseClassComboBox.Name = "licenseClassComboBox";
            this.licenseClassComboBox.Size = new System.Drawing.Size(344, 34);
            this.licenseClassComboBox.TabIndex = 3;
            // 
            // licenseClassLabel
            // 
            this.licenseClassLabel.AutoSize = true;
            this.licenseClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseClassLabel.Image = global::DVLD.Properties.Resources.driverslicense;
            this.licenseClassLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.licenseClassLabel.Location = new System.Drawing.Point(496, 14);
            this.licenseClassLabel.Name = "licenseClassLabel";
            this.licenseClassLabel.Size = new System.Drawing.Size(238, 26);
            this.licenseClassLabel.TabIndex = 2;
            this.licenseClassLabel.Text = "License Class :         ";
            // 
            // applicationDateLabel
            // 
            this.applicationDateLabel.AutoSize = true;
            this.applicationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationDateLabel.Image = global::DVLD.Properties.Resources.dataofbirth;
            this.applicationDateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.applicationDateLabel.Location = new System.Drawing.Point(12, 54);
            this.applicationDateLabel.Name = "applicationDateLabel";
            this.applicationDateLabel.Size = new System.Drawing.Size(257, 26);
            this.applicationDateLabel.TabIndex = 1;
            this.applicationDateLabel.Text = "Application Date :        ";
            // 
            // DLAppicationIdLabel
            // 
            this.DLAppicationIdLabel.AutoSize = true;
            this.DLAppicationIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLAppicationIdLabel.Image = global::DVLD.Properties.Resources.namecard;
            this.DLAppicationIdLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DLAppicationIdLabel.Location = new System.Drawing.Point(12, 14);
            this.DLAppicationIdLabel.Name = "DLAppicationIdLabel";
            this.DLAppicationIdLabel.Size = new System.Drawing.Size(261, 26);
            this.DLAppicationIdLabel.TabIndex = 0;
            this.DLAppicationIdLabel.Text = "D.L.Application ID :      ";
            // 
            // peersonInfoWithFilterUserControl1
            // 
            this.peersonInfoWithFilterUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.peersonInfoWithFilterUserControl1.Location = new System.Drawing.Point(5, 56);
            this.peersonInfoWithFilterUserControl1.Name = "peersonInfoWithFilterUserControl1";
            this.peersonInfoWithFilterUserControl1.Size = new System.Drawing.Size(1092, 463);
            this.peersonInfoWithFilterUserControl1.TabIndex = 0;
            // 
            // AddLocalDrivingLicenseApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 774);
            this.Controls.Add(this.peersonInfoWithFilterUserControl1);
            this.Controls.Add(this.nextBtnPanel);
            this.Controls.Add(this.applicationInfoPanel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.buttomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddLocalDrivingLicenseApplicationForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Local Driving License";
            this.Load += new System.EventHandler(this.AddLocalDrivingLicenseApplicationForm_Load);
            this.nextBtnPanel.ResumeLayout(false);
            this.buttomPanel.ResumeLayout(false);
            this.applicationInfoPanel.ResumeLayout(false);
            this.applicationInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PeersonInfoWithFilterUserControl peersonInfoWithFilterUserControl1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel nextBtnPanel;
        private System.Windows.Forms.Button nxtBtn;
        private System.Windows.Forms.Panel buttomPanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel applicationInfoPanel;
        private System.Windows.Forms.Label applicationDateLabel;
        private System.Windows.Forms.Label DLAppicationIdLabel;
        private System.Windows.Forms.Label licenseClassLabel;
        private System.Windows.Forms.ComboBox licenseClassComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label applicationFeesLabel;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.TextBox dateTxtBox;
        private System.Windows.Forms.TextBox feesTxtBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
    }
}