namespace DVLD.User_Controls
{
    partial class DrvierLicenseInfo_WithFilterUserControl
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
            this.driverLicenseInfoUserCiontrol1 = new DVLD.User_Controls.DriverLicenseInfoUserCiontrol();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.licensesComboBox = new System.Windows.Forms.ComboBox();
            this.LicenseIDLabel = new System.Windows.Forms.Label();
            this.FilterPanel.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // driverLicenseInfoUserCiontrol1
            // 
            this.driverLicenseInfoUserCiontrol1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.driverLicenseInfoUserCiontrol1.Location = new System.Drawing.Point(0, 83);
            this.driverLicenseInfoUserCiontrol1.Name = "driverLicenseInfoUserCiontrol1";
            this.driverLicenseInfoUserCiontrol1.Padding = new System.Windows.Forms.Padding(5);
            this.driverLicenseInfoUserCiontrol1.Size = new System.Drawing.Size(1057, 541);
            this.driverLicenseInfoUserCiontrol1.TabIndex = 0;
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.filterGroupBox);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(1057, 77);
            this.FilterPanel.TabIndex = 2;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.addBtn);
            this.filterGroupBox.Controls.Add(this.licensesComboBox);
            this.filterGroupBox.Controls.Add(this.LicenseIDLabel);
            this.filterGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterGroupBox.Location = new System.Drawing.Point(0, 0);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.filterGroupBox.Size = new System.Drawing.Size(1057, 77);
            this.filterGroupBox.TabIndex = 0;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filter";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.Image = global::DVLD.Properties.Resources.namecard;
            this.addBtn.Location = new System.Drawing.Point(655, 32);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(128, 36);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = " Add";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // licensesComboBox
            // 
            this.licensesComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.licensesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.licensesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensesComboBox.FormattingEnabled = true;
            this.licensesComboBox.Location = new System.Drawing.Point(362, 32);
            this.licensesComboBox.Name = "licensesComboBox";
            this.licensesComboBox.Size = new System.Drawing.Size(287, 34);
            this.licensesComboBox.TabIndex = 1;
            // 
            // LicenseIDLabel
            // 
            this.LicenseIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LicenseIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseIDLabel.Location = new System.Drawing.Point(233, 35);
            this.LicenseIDLabel.Name = "LicenseIDLabel";
            this.LicenseIDLabel.Size = new System.Drawing.Size(133, 26);
            this.LicenseIDLabel.TabIndex = 0;
            this.LicenseIDLabel.Text = "License ID : ";
            this.LicenseIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DrvierLicenseInfo_WithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.driverLicenseInfoUserCiontrol1);
            this.Name = "DrvierLicenseInfo_WithFilter";
            this.Size = new System.Drawing.Size(1057, 624);
            this.Load += new System.EventHandler(this.DrvierLicenseInfo_WithFilter_Load);
            this.FilterPanel.ResumeLayout(false);
            this.filterGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DriverLicenseInfoUserCiontrol driverLicenseInfoUserCiontrol1;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.Label LicenseIDLabel;
        private System.Windows.Forms.ComboBox licensesComboBox;
        private System.Windows.Forms.Button addBtn;
    }
}
