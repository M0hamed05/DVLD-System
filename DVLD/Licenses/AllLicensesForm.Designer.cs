namespace DVLD.Licenses
{
    partial class AllLicensesForm
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
            this.downBtnsPanel = new System.Windows.Forms.Panel();
            this.recordsLabel = new System.Windows.Forms.Label();
            this.peoplePictureBox = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.fliterLabel = new System.Windows.Forms.Label();
            this.filter_txtbox = new System.Windows.Forms.TextBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.AllLicenses_dgv = new System.Windows.Forms.DataGridView();
            this.upperButtenPanels = new System.Windows.Forms.Panel();
            this.isActiveFilterComboBox = new System.Windows.Forms.ComboBox();
            this.optionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalradioButton = new System.Windows.Forms.RadioButton();
            this.InternationalradioButton = new System.Windows.Forms.RadioButton();
            this.showDriverHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.downBtnsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).BeginInit();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllLicenses_dgv)).BeginInit();
            this.upperButtenPanels.SuspendLayout();
            this.optionsContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // downBtnsPanel
            // 
            this.downBtnsPanel.Controls.Add(this.recordsLabel);
            this.downBtnsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downBtnsPanel.Location = new System.Drawing.Point(0, 525);
            this.downBtnsPanel.Name = "downBtnsPanel";
            this.downBtnsPanel.Size = new System.Drawing.Size(1123, 66);
            this.downBtnsPanel.TabIndex = 24;
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
            // peoplePictureBox
            // 
            this.peoplePictureBox.Image = global::DVLD.Properties.Resources.driverlicenses;
            this.peoplePictureBox.Location = new System.Drawing.Point(3, 3);
            this.peoplePictureBox.Name = "peoplePictureBox";
            this.peoplePictureBox.Size = new System.Drawing.Size(93, 87);
            this.peoplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.peoplePictureBox.TabIndex = 7;
            this.peoplePictureBox.TabStop = false;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.peoplePictureBox);
            this.titlePanel.Controls.Add(this.headerLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1123, 93);
            this.titlePanel.TabIndex = 21;
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
            this.headerLabel.Text = "All Licenses";
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
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // AllLicenses_dgv
            // 
            this.AllLicenses_dgv.AllowUserToAddRows = false;
            this.AllLicenses_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllLicenses_dgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.AllLicenses_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllLicenses_dgv.ContextMenuStrip = this.optionsContextMenuStrip;
            this.AllLicenses_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllLicenses_dgv.GridColor = System.Drawing.Color.LightGray;
            this.AllLicenses_dgv.Location = new System.Drawing.Point(0, 197);
            this.AllLicenses_dgv.Name = "AllLicenses_dgv";
            this.AllLicenses_dgv.ReadOnly = true;
            this.AllLicenses_dgv.RowHeadersVisible = false;
            this.AllLicenses_dgv.RowHeadersWidth = 62;
            this.AllLicenses_dgv.RowTemplate.Height = 28;
            this.AllLicenses_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllLicenses_dgv.Size = new System.Drawing.Size(1123, 328);
            this.AllLicenses_dgv.TabIndex = 23;
            // 
            // upperButtenPanels
            // 
            this.upperButtenPanels.Controls.Add(this.InternationalradioButton);
            this.upperButtenPanels.Controls.Add(this.LocalradioButton);
            this.upperButtenPanels.Controls.Add(this.isActiveFilterComboBox);
            this.upperButtenPanels.Controls.Add(this.fliterLabel);
            this.upperButtenPanels.Controls.Add(this.filter_txtbox);
            this.upperButtenPanels.Controls.Add(this.filterComboBox);
            this.upperButtenPanels.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperButtenPanels.Location = new System.Drawing.Point(0, 93);
            this.upperButtenPanels.Name = "upperButtenPanels";
            this.upperButtenPanels.Size = new System.Drawing.Size(1123, 104);
            this.upperButtenPanels.TabIndex = 22;
            // 
            // isActiveFilterComboBox
            // 
            this.isActiveFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isActiveFilterComboBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveFilterComboBox.FormattingEnabled = true;
            this.isActiveFilterComboBox.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.isActiveFilterComboBox.Location = new System.Drawing.Point(368, 62);
            this.isActiveFilterComboBox.Name = "isActiveFilterComboBox";
            this.isActiveFilterComboBox.Size = new System.Drawing.Size(125, 34);
            this.isActiveFilterComboBox.TabIndex = 6;
            this.isActiveFilterComboBox.Visible = false;
            this.isActiveFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.isActiveFilterComboBox_SelectedIndexChanged);
            // 
            // optionsContextMenuStrip
            // 
            this.optionsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.optionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator1,
            this.showDriverHistoryToolStripMenuItem});
            this.optionsContextMenuStrip.Name = "contextMenuStrip1";
            this.optionsContextMenuStrip.Size = new System.Drawing.Size(287, 115);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.showLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.driverlicenses;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(286, 36);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // LocalradioButton
            // 
            this.LocalradioButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LocalradioButton.AutoSize = true;
            this.LocalradioButton.Checked = true;
            this.LocalradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalradioButton.Location = new System.Drawing.Point(833, 61);
            this.LocalradioButton.Name = "LocalradioButton";
            this.LocalradioButton.Size = new System.Drawing.Size(89, 30);
            this.LocalradioButton.TabIndex = 7;
            this.LocalradioButton.TabStop = true;
            this.LocalradioButton.Text = "Local";
            this.LocalradioButton.UseVisualStyleBackColor = true;
            // 
            // InternationalradioButton
            // 
            this.InternationalradioButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InternationalradioButton.AutoSize = true;
            this.InternationalradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternationalradioButton.Location = new System.Drawing.Point(928, 60);
            this.InternationalradioButton.Name = "InternationalradioButton";
            this.InternationalradioButton.Size = new System.Drawing.Size(169, 33);
            this.InternationalradioButton.TabIndex = 8;
            this.InternationalradioButton.Text = "International";
            this.InternationalradioButton.UseVisualStyleBackColor = true;
            // 
            // showDriverHistoryToolStripMenuItem
            // 
            this.showDriverHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.showDriverHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.personhisory;
            this.showDriverHistoryToolStripMenuItem.Name = "showDriverHistoryToolStripMenuItem";
            this.showDriverHistoryToolStripMenuItem.Size = new System.Drawing.Size(286, 36);
            this.showDriverHistoryToolStripMenuItem.Text = "Show Driver History";
            this.showDriverHistoryToolStripMenuItem.Click += new System.EventHandler(this.showDriverHistoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(283, 6);
            // 
            // AllLicensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 591);
            this.Controls.Add(this.AllLicenses_dgv);
            this.Controls.Add(this.downBtnsPanel);
            this.Controls.Add(this.upperButtenPanels);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllLicensesForm";
            this.Text = "AllLicensesForm";
            this.Load += new System.EventHandler(this.AllLicensesForm_Load);
            this.downBtnsPanel.ResumeLayout(false);
            this.downBtnsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).EndInit();
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllLicenses_dgv)).EndInit();
            this.upperButtenPanels.ResumeLayout(false);
            this.upperButtenPanels.PerformLayout();
            this.optionsContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel downBtnsPanel;
        private System.Windows.Forms.Label recordsLabel;
        private System.Windows.Forms.PictureBox peoplePictureBox;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label fliterLabel;
        private System.Windows.Forms.TextBox filter_txtbox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.DataGridView AllLicenses_dgv;
        private System.Windows.Forms.Panel upperButtenPanels;
        private System.Windows.Forms.ComboBox isActiveFilterComboBox;
        private System.Windows.Forms.ContextMenuStrip optionsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.RadioButton InternationalradioButton;
        private System.Windows.Forms.RadioButton LocalradioButton;
        private System.Windows.Forms.ToolStripMenuItem showDriverHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}