namespace DVLD.Applications
{
    partial class PersonLicenseHistoryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonLicenseHistoryForm));
            this.historyPictureBox = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.LicenseGroupBox = new System.Windows.Forms.GroupBox();
            this.DriverLicense_dgv = new System.Windows.Forms.DataGridView();
            this.optionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.localToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downBtnsPanel = new System.Windows.Forms.Panel();
            this.recordsLabel = new System.Windows.Forms.Label();
            this.personInfoUserControl1 = new DVLD.PersonInfoUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.historyPictureBox)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.LicenseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriverLicense_dgv)).BeginInit();
            this.optionsContextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.downBtnsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyPictureBox
            // 
            this.historyPictureBox.Image = global::DVLD.Properties.Resources.LicenseHistory;
            this.historyPictureBox.Location = new System.Drawing.Point(8, 62);
            this.historyPictureBox.Name = "historyPictureBox";
            this.historyPictureBox.Padding = new System.Windows.Forms.Padding(3);
            this.historyPictureBox.Size = new System.Drawing.Size(142, 165);
            this.historyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.historyPictureBox.TabIndex = 0;
            this.historyPictureBox.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(3, 3);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1248, 51);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "License History";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.closeBtn);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(3, 798);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1248, 57);
            this.buttonPanel.TabIndex = 3;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Image = global::DVLD.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(1066, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(170, 45);
            this.closeBtn.TabIndex = 33;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // LicenseGroupBox
            // 
            this.LicenseGroupBox.Controls.Add(this.DriverLicense_dgv);
            this.LicenseGroupBox.Controls.Add(this.menuStrip1);
            this.LicenseGroupBox.Controls.Add(this.downBtnsPanel);
            this.LicenseGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LicenseGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseGroupBox.Location = new System.Drawing.Point(3, 463);
            this.LicenseGroupBox.Name = "LicenseGroupBox";
            this.LicenseGroupBox.Size = new System.Drawing.Size(1248, 335);
            this.LicenseGroupBox.TabIndex = 4;
            this.LicenseGroupBox.TabStop = false;
            this.LicenseGroupBox.Text = "Driver License";
            // 
            // DriverLicense_dgv
            // 
            this.DriverLicense_dgv.AllowUserToAddRows = false;
            this.DriverLicense_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DriverLicense_dgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.DriverLicense_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverLicense_dgv.ContextMenuStrip = this.optionsContextMenuStrip;
            this.DriverLicense_dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DriverLicense_dgv.GridColor = System.Drawing.Color.LightGray;
            this.DriverLicense_dgv.Location = new System.Drawing.Point(3, 72);
            this.DriverLicense_dgv.Name = "DriverLicense_dgv";
            this.DriverLicense_dgv.ReadOnly = true;
            this.DriverLicense_dgv.RowHeadersVisible = false;
            this.DriverLicense_dgv.RowHeadersWidth = 62;
            this.DriverLicense_dgv.RowTemplate.Height = 28;
            this.DriverLicense_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DriverLicense_dgv.Size = new System.Drawing.Size(1242, 207);
            this.DriverLicense_dgv.TabIndex = 12;
            // 
            // optionsContextMenuStrip
            // 
            this.optionsContextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.optionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.optionsContextMenuStrip.Name = "optionsContextMenuStrip";
            this.optionsContextMenuStrip.Size = new System.Drawing.Size(289, 42);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.driverslicense;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localToolStripMenuItem,
            this.internationalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 31);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1242, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // localToolStripMenuItem
            // 
            this.localToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.localToolStripMenuItem.Name = "localToolStripMenuItem";
            this.localToolStripMenuItem.Size = new System.Drawing.Size(78, 34);
            this.localToolStripMenuItem.Text = "Local";
            this.localToolStripMenuItem.Click += new System.EventHandler(this.localToolStripMenuItem_Click);
            // 
            // internationalToolStripMenuItem
            // 
            this.internationalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.internationalToolStripMenuItem.Name = "internationalToolStripMenuItem";
            this.internationalToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.internationalToolStripMenuItem.Text = "International";
            this.internationalToolStripMenuItem.Click += new System.EventHandler(this.internationalToolStripMenuItem_Click);
            // 
            // downBtnsPanel
            // 
            this.downBtnsPanel.Controls.Add(this.recordsLabel);
            this.downBtnsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downBtnsPanel.Location = new System.Drawing.Point(3, 279);
            this.downBtnsPanel.Name = "downBtnsPanel";
            this.downBtnsPanel.Size = new System.Drawing.Size(1242, 53);
            this.downBtnsPanel.TabIndex = 13;
            // 
            // recordsLabel
            // 
            this.recordsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.recordsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsLabel.Location = new System.Drawing.Point(0, 0);
            this.recordsLabel.Name = "recordsLabel";
            this.recordsLabel.Size = new System.Drawing.Size(161, 53);
            this.recordsLabel.TabIndex = 1;
            this.recordsLabel.Text = "Records: 0";
            this.recordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // personInfoUserControl1
            // 
            this.personInfoUserControl1.Location = new System.Drawing.Point(162, 62);
            this.personInfoUserControl1.Name = "personInfoUserControl1";
            this.personInfoUserControl1.Size = new System.Drawing.Size(1070, 395);
            this.personInfoUserControl1.TabIndex = 1;
            // 
            // PersonLicenseHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 858);
            this.Controls.Add(this.LicenseGroupBox);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.personInfoUserControl1);
            this.Controls.Add(this.historyPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PersonLicenseHistoryForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person License History";
            this.Load += new System.EventHandler(this.PersonLicenseHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyPictureBox)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.LicenseGroupBox.ResumeLayout(false);
            this.LicenseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriverLicense_dgv)).EndInit();
            this.optionsContextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.downBtnsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox historyPictureBox;
        private PersonInfoUserControl personInfoUserControl1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox LicenseGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem localToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalToolStripMenuItem;
        private System.Windows.Forms.DataGridView DriverLicense_dgv;
        private System.Windows.Forms.Panel downBtnsPanel;
        private System.Windows.Forms.Label recordsLabel;
        private System.Windows.Forms.ContextMenuStrip optionsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}