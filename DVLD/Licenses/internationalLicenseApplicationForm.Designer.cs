namespace DVLD.Licenses
{
    partial class internationalLicenseApplicationForm
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
            this.recordsLabel = new System.Windows.Forms.Label();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonDetialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.applications_dgv = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.fliterLabel = new System.Windows.Forms.Label();
            this.filter_txtbox = new System.Windows.Forms.TextBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.upperButtenPanels = new System.Windows.Forms.Panel();
            this.peoplePictureBox = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.downBtnsPanel = new System.Windows.Forms.Panel();
            this.optionsContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applications_dgv)).BeginInit();
            this.upperButtenPanels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.downBtnsPanel.SuspendLayout();
            this.SuspendLayout();
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
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.personhisory;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(397, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(394, 6);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(394, 6);
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
            // optionsContextMenuStrip
            // 
            this.optionsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.optionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetialsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showLicenseDetailsToolStripMenuItem,
            this.toolStripSeparator5,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.optionsContextMenuStrip.Name = "optionsContextMenuStrip";
            this.optionsContextMenuStrip.Size = new System.Drawing.Size(398, 130);
            // 
            // applications_dgv
            // 
            this.applications_dgv.AllowUserToAddRows = false;
            this.applications_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.applications_dgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.applications_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applications_dgv.ContextMenuStrip = this.optionsContextMenuStrip;
            this.applications_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applications_dgv.GridColor = System.Drawing.Color.LightGray;
            this.applications_dgv.Location = new System.Drawing.Point(0, 197);
            this.applications_dgv.Name = "applications_dgv";
            this.applications_dgv.ReadOnly = true;
            this.applications_dgv.RowHeadersVisible = false;
            this.applications_dgv.RowHeadersWidth = 62;
            this.applications_dgv.RowTemplate.Height = 28;
            this.applications_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.applications_dgv.Size = new System.Drawing.Size(1236, 345);
            this.applications_dgv.TabIndex = 15;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addBtn.Image = global::DVLD.Properties.Resources.addcard;
            this.addBtn.Location = new System.Drawing.Point(1083, 61);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(150, 40);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
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
            this.upperButtenPanels.Controls.Add(this.addBtn);
            this.upperButtenPanels.Controls.Add(this.fliterLabel);
            this.upperButtenPanels.Controls.Add(this.filter_txtbox);
            this.upperButtenPanels.Controls.Add(this.filterComboBox);
            this.upperButtenPanels.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperButtenPanels.Location = new System.Drawing.Point(0, 93);
            this.upperButtenPanels.Name = "upperButtenPanels";
            this.upperButtenPanels.Size = new System.Drawing.Size(1236, 104);
            this.upperButtenPanels.TabIndex = 14;
            // 
            // peoplePictureBox
            // 
            this.peoplePictureBox.Image = global::DVLD.Properties.Resources.driverlicense;
            this.peoplePictureBox.Location = new System.Drawing.Point(3, 3);
            this.peoplePictureBox.Name = "peoplePictureBox";
            this.peoplePictureBox.Size = new System.Drawing.Size(93, 87);
            this.peoplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.peoplePictureBox.TabIndex = 7;
            this.peoplePictureBox.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.headerLabel.Location = new System.Drawing.Point(102, 39);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(759, 51);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "International License Applications";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.peoplePictureBox);
            this.titlePanel.Controls.Add(this.headerLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1236, 93);
            this.titlePanel.TabIndex = 13;
            // 
            // downBtnsPanel
            // 
            this.downBtnsPanel.Controls.Add(this.recordsLabel);
            this.downBtnsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downBtnsPanel.Location = new System.Drawing.Point(0, 542);
            this.downBtnsPanel.Name = "downBtnsPanel";
            this.downBtnsPanel.Size = new System.Drawing.Size(1236, 66);
            this.downBtnsPanel.TabIndex = 16;
            // 
            // internationalLicenseApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 608);
            this.Controls.Add(this.applications_dgv);
            this.Controls.Add(this.upperButtenPanels);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.downBtnsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "internationalLicenseApplicationForm";
            this.Text = "internationalLicenseApplicationForm";
            this.Load += new System.EventHandler(this.internationalLicenseApplicationForm_Load);
            this.optionsContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applications_dgv)).EndInit();
            this.upperButtenPanels.ResumeLayout(false);
            this.upperButtenPanels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.downBtnsPanel.ResumeLayout(false);
            this.downBtnsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label recordsLabel;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetialsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip optionsContextMenuStrip;
        private System.Windows.Forms.DataGridView applications_dgv;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label fliterLabel;
        private System.Windows.Forms.TextBox filter_txtbox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Panel upperButtenPanels;
        private System.Windows.Forms.PictureBox peoplePictureBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel downBtnsPanel;
    }
}