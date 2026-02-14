namespace DVLD.Applications
{
    partial class ManageDriversForm
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
            this.downBtnsPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.peoplePictureBox = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filter_txtbox = new System.Windows.Forms.TextBox();
            this.fliterLabel = new System.Windows.Forms.Label();
            this.upperButtenPanels = new System.Windows.Forms.Panel();
            this.drivers_dgv = new System.Windows.Forms.DataGridView();
            this.optionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDriverLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downBtnsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.upperButtenPanels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivers_dgv)).BeginInit();
            this.optionsContextMenuStrip.SuspendLayout();
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
            // downBtnsPanel
            // 
            this.downBtnsPanel.Controls.Add(this.recordsLabel);
            this.downBtnsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downBtnsPanel.Location = new System.Drawing.Point(0, 511);
            this.downBtnsPanel.Name = "downBtnsPanel";
            this.downBtnsPanel.Size = new System.Drawing.Size(1216, 66);
            this.downBtnsPanel.TabIndex = 16;
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.headerLabel.Location = new System.Drawing.Point(102, 39);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(419, 51);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Manage Drivers";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // peoplePictureBox
            // 
            this.peoplePictureBox.Image = global::DVLD.Properties.Resources.driving;
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
            this.titlePanel.Size = new System.Drawing.Size(1216, 93);
            this.titlePanel.TabIndex = 13;
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
            // upperButtenPanels
            // 
            this.upperButtenPanels.Controls.Add(this.fliterLabel);
            this.upperButtenPanels.Controls.Add(this.filter_txtbox);
            this.upperButtenPanels.Controls.Add(this.filterComboBox);
            this.upperButtenPanels.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperButtenPanels.Location = new System.Drawing.Point(0, 93);
            this.upperButtenPanels.Name = "upperButtenPanels";
            this.upperButtenPanels.Size = new System.Drawing.Size(1216, 104);
            this.upperButtenPanels.TabIndex = 14;
            // 
            // drivers_dgv
            // 
            this.drivers_dgv.AllowUserToAddRows = false;
            this.drivers_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drivers_dgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.drivers_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drivers_dgv.ContextMenuStrip = this.optionsContextMenuStrip;
            this.drivers_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drivers_dgv.GridColor = System.Drawing.Color.LightGray;
            this.drivers_dgv.Location = new System.Drawing.Point(0, 197);
            this.drivers_dgv.Name = "drivers_dgv";
            this.drivers_dgv.ReadOnly = true;
            this.drivers_dgv.RowHeadersVisible = false;
            this.drivers_dgv.RowHeadersWidth = 62;
            this.drivers_dgv.RowTemplate.Height = 28;
            this.drivers_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drivers_dgv.Size = new System.Drawing.Size(1216, 314);
            this.drivers_dgv.TabIndex = 15;
            // 
            // optionsContextMenuStrip
            // 
            this.optionsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.optionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDriverLicenseHistoryToolStripMenuItem});
            this.optionsContextMenuStrip.Name = "optionsContextMenuStrip";
            this.optionsContextMenuStrip.Size = new System.Drawing.Size(391, 75);
            // 
            // showDriverLicenseHistoryToolStripMenuItem
            // 
            this.showDriverLicenseHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.showDriverLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.driverslicense;
            this.showDriverLicenseHistoryToolStripMenuItem.Name = "showDriverLicenseHistoryToolStripMenuItem";
            this.showDriverLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(390, 38);
            this.showDriverLicenseHistoryToolStripMenuItem.Text = "Show Driver License History";
            this.showDriverLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showDriverLicenseHistoryToolStripMenuItem_Click);
            // 
            // ManageDriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 577);
            this.Controls.Add(this.drivers_dgv);
            this.Controls.Add(this.upperButtenPanels);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.downBtnsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageDriversForm";
            this.Text = "ManageDriversForm";
            this.Load += new System.EventHandler(this.ManageDriversForm_Load);
            this.downBtnsPanel.ResumeLayout(false);
            this.downBtnsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.upperButtenPanels.ResumeLayout(false);
            this.upperButtenPanels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivers_dgv)).EndInit();
            this.optionsContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label recordsLabel;
        private System.Windows.Forms.Panel downBtnsPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox peoplePictureBox;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.TextBox filter_txtbox;
        private System.Windows.Forms.Label fliterLabel;
        private System.Windows.Forms.Panel upperButtenPanels;
        private System.Windows.Forms.DataGridView drivers_dgv;
        private System.Windows.Forms.ContextMenuStrip optionsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showDriverLicenseHistoryToolStripMenuItem;
    }
}