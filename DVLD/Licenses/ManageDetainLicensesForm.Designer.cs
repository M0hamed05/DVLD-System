namespace DVLD.Licenses
{
    partial class ManageDetainLicensesForm
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
            this.detainLicense_dgv = new System.Windows.Forms.DataGridView();
            this.optionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerLabel = new System.Windows.Forms.Label();
            this.fliterLabel = new System.Windows.Forms.Label();
            this.filter_txtbox = new System.Windows.Forms.TextBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.upperButtenPanels = new System.Windows.Forms.Panel();
            this.detainButton = new System.Windows.Forms.Button();
            this.ReleaseBtn = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.peoplePictureBox = new System.Windows.Forms.PictureBox();
            this.recordsLabel = new System.Windows.Forms.Label();
            this.downBtnsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.detainLicense_dgv)).BeginInit();
            this.optionsContextMenuStrip.SuspendLayout();
            this.upperButtenPanels.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).BeginInit();
            this.downBtnsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // detainLicense_dgv
            // 
            this.detainLicense_dgv.AllowUserToAddRows = false;
            this.detainLicense_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detainLicense_dgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.detainLicense_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detainLicense_dgv.ContextMenuStrip = this.optionsContextMenuStrip;
            this.detainLicense_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detainLicense_dgv.GridColor = System.Drawing.Color.LightGray;
            this.detainLicense_dgv.Location = new System.Drawing.Point(0, 197);
            this.detainLicense_dgv.Name = "detainLicense_dgv";
            this.detainLicense_dgv.ReadOnly = true;
            this.detainLicense_dgv.RowHeadersVisible = false;
            this.detainLicense_dgv.RowHeadersWidth = 62;
            this.detainLicense_dgv.RowTemplate.Height = 28;
            this.detainLicense_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detainLicense_dgv.Size = new System.Drawing.Size(1250, 360);
            this.detainLicense_dgv.TabIndex = 19;
            // 
            // optionsContextMenuStrip
            // 
            this.optionsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.optionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetialsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showLicenseDetailsToolStripMenuItem,
            this.toolStripSeparator5,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.releaseDetainLicenseToolStripMenuItem});
            this.optionsContextMenuStrip.Name = "optionsContextMenuStrip";
            this.optionsContextMenuStrip.Size = new System.Drawing.Size(398, 201);
            this.optionsContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.optionsContextMenuStrip_Opening);
            // 
            // showPersonDetialsToolStripMenuItem
            // 
            this.showPersonDetialsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.showPersonDetialsToolStripMenuItem.Image = global::DVLD.Properties.Resources.details;
            this.showPersonDetialsToolStripMenuItem.Name = "showPersonDetialsToolStripMenuItem";
            this.showPersonDetialsToolStripMenuItem.Size = new System.Drawing.Size(397, 38);
            this.showPersonDetialsToolStripMenuItem.Text = "Show Person Detials";
            this.showPersonDetialsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetialsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(394, 6);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.showLicenseDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.driverslicense;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(397, 38);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Detais";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(394, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.personhisory;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(397, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // releaseDetainLicenseToolStripMenuItem
            // 
            this.releaseDetainLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.releaseDetainLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.addcard;
            this.releaseDetainLicenseToolStripMenuItem.Name = "releaseDetainLicenseToolStripMenuItem";
            this.releaseDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(397, 38);
            this.releaseDetainLicenseToolStripMenuItem.Text = "Release Detain License";
            this.releaseDetainLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainLicenseToolStripMenuItem_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.headerLabel.Location = new System.Drawing.Point(102, 3);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(759, 87);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "List Detained License ";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fliterLabel
            // 
            this.fliterLabel.AutoSize = true;
            this.fliterLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fliterLabel.Location = new System.Drawing.Point(3, 63);
            this.fliterLabel.Name = "fliterLabel";
            this.fliterLabel.Size = new System.Drawing.Size(129, 30);
            this.fliterLabel.TabIndex = 3;
            this.fliterLabel.Text = "Fliter By:";
            // 
            // filter_txtbox
            // 
            this.filter_txtbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_txtbox.Location = new System.Drawing.Point(368, 61);
            this.filter_txtbox.Name = "filter_txtbox";
            this.filter_txtbox.Size = new System.Drawing.Size(250, 35);
            this.filter_txtbox.TabIndex = 5;
            this.filter_txtbox.TextChanged += new System.EventHandler(this.filter_txtbox_TextChanged);
            this.filter_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filter_txtbox_KeyPress);
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(138, 62);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(220, 34);
            this.filterComboBox.TabIndex = 4;
            // 
            // upperButtenPanels
            // 
            this.upperButtenPanels.Controls.Add(this.detainButton);
            this.upperButtenPanels.Controls.Add(this.ReleaseBtn);
            this.upperButtenPanels.Controls.Add(this.fliterLabel);
            this.upperButtenPanels.Controls.Add(this.filter_txtbox);
            this.upperButtenPanels.Controls.Add(this.filterComboBox);
            this.upperButtenPanels.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperButtenPanels.Location = new System.Drawing.Point(0, 93);
            this.upperButtenPanels.Name = "upperButtenPanels";
            this.upperButtenPanels.Size = new System.Drawing.Size(1250, 104);
            this.upperButtenPanels.TabIndex = 18;
            // 
            // detainButton
            // 
            this.detainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.detainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.detainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.detainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detainButton.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detainButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.detainButton.Image = global::DVLD.Properties.Resources.deleteLicense;
            this.detainButton.Location = new System.Drawing.Point(941, 63);
            this.detainButton.Name = "detainButton";
            this.detainButton.Size = new System.Drawing.Size(150, 40);
            this.detainButton.TabIndex = 7;
            this.detainButton.Text = "Detain";
            this.detainButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.detainButton.UseVisualStyleBackColor = true;
            this.detainButton.Click += new System.EventHandler(this.detainButton_Click);
            // 
            // ReleaseBtn
            // 
            this.ReleaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReleaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReleaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReleaseBtn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ReleaseBtn.Image = global::DVLD.Properties.Resources.addcard;
            this.ReleaseBtn.Location = new System.Drawing.Point(1097, 61);
            this.ReleaseBtn.Name = "ReleaseBtn";
            this.ReleaseBtn.Size = new System.Drawing.Size(150, 40);
            this.ReleaseBtn.TabIndex = 6;
            this.ReleaseBtn.Text = "Release";
            this.ReleaseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReleaseBtn.UseVisualStyleBackColor = true;
            this.ReleaseBtn.Click += new System.EventHandler(this.ReleaseBtn_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.peoplePictureBox);
            this.titlePanel.Controls.Add(this.headerLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1250, 93);
            this.titlePanel.TabIndex = 17;
            // 
            // peoplePictureBox
            // 
            this.peoplePictureBox.Image = global::DVLD.Properties.Resources.detainCard2;
            this.peoplePictureBox.Location = new System.Drawing.Point(3, 3);
            this.peoplePictureBox.Name = "peoplePictureBox";
            this.peoplePictureBox.Size = new System.Drawing.Size(93, 87);
            this.peoplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.peoplePictureBox.TabIndex = 7;
            this.peoplePictureBox.TabStop = false;
            // 
            // recordsLabel
            // 
            this.recordsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.recordsLabel.AutoSize = true;
            this.recordsLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsLabel.Location = new System.Drawing.Point(3, 16);
            this.recordsLabel.Name = "recordsLabel";
            this.recordsLabel.Size = new System.Drawing.Size(161, 33);
            this.recordsLabel.TabIndex = 1;
            this.recordsLabel.Text = "Records: 0";
            // 
            // downBtnsPanel
            // 
            this.downBtnsPanel.Controls.Add(this.recordsLabel);
            this.downBtnsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downBtnsPanel.Location = new System.Drawing.Point(0, 557);
            this.downBtnsPanel.Name = "downBtnsPanel";
            this.downBtnsPanel.Size = new System.Drawing.Size(1250, 66);
            this.downBtnsPanel.TabIndex = 20;
            // 
            // ManageDetainLicensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 623);
            this.Controls.Add(this.detainLicense_dgv);
            this.Controls.Add(this.upperButtenPanels);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.downBtnsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageDetainLicensesForm";
            this.Text = "ManageDetainLicensesForm";
            this.Load += new System.EventHandler(this.ManageDetainLicensesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detainLicense_dgv)).EndInit();
            this.optionsContextMenuStrip.ResumeLayout(false);
            this.upperButtenPanels.ResumeLayout(false);
            this.upperButtenPanels.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).EndInit();
            this.downBtnsPanel.ResumeLayout(false);
            this.downBtnsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView detainLicense_dgv;
        private System.Windows.Forms.ContextMenuStrip optionsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.PictureBox peoplePictureBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button ReleaseBtn;
        private System.Windows.Forms.Label fliterLabel;
        private System.Windows.Forms.TextBox filter_txtbox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Panel upperButtenPanels;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label recordsLabel;
        private System.Windows.Forms.Panel downBtnsPanel;
        private System.Windows.Forms.Button detainButton;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainLicenseToolStripMenuItem;
    }
}