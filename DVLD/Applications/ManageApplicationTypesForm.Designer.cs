namespace DVLD.Resources
{
    partial class ManageApplicationTypesForm
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.peoplePictureBox = new System.Windows.Forms.PictureBox();
            this.manageLabel = new System.Windows.Forms.Label();
            this.applicationsTypes_dgv = new System.Windows.Forms.DataGridView();
            this.OptionscontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downBtnsPanel = new System.Windows.Forms.Panel();
            this.recordsLabel = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsTypes_dgv)).BeginInit();
            this.OptionscontextMenuStrip.SuspendLayout();
            this.downBtnsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.peoplePictureBox);
            this.titlePanel.Controls.Add(this.manageLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1258, 93);
            this.titlePanel.TabIndex = 9;
            // 
            // peoplePictureBox
            // 
            this.peoplePictureBox.Image = global::DVLD.Properties.Resources.manageapplication2;
            this.peoplePictureBox.Location = new System.Drawing.Point(3, 3);
            this.peoplePictureBox.Name = "peoplePictureBox";
            this.peoplePictureBox.Size = new System.Drawing.Size(93, 87);
            this.peoplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.peoplePictureBox.TabIndex = 7;
            this.peoplePictureBox.TabStop = false;
            // 
            // manageLabel
            // 
            this.manageLabel.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.manageLabel.Location = new System.Drawing.Point(102, 39);
            this.manageLabel.Name = "manageLabel";
            this.manageLabel.Size = new System.Drawing.Size(562, 51);
            this.manageLabel.TabIndex = 0;
            this.manageLabel.Text = "Manage Applicaion Types";
            this.manageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // applicationsTypes_dgv
            // 
            this.applicationsTypes_dgv.AllowUserToAddRows = false;
            this.applicationsTypes_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.applicationsTypes_dgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.applicationsTypes_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicationsTypes_dgv.ContextMenuStrip = this.OptionscontextMenuStrip;
            this.applicationsTypes_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationsTypes_dgv.GridColor = System.Drawing.Color.LightGray;
            this.applicationsTypes_dgv.Location = new System.Drawing.Point(0, 93);
            this.applicationsTypes_dgv.Name = "applicationsTypes_dgv";
            this.applicationsTypes_dgv.ReadOnly = true;
            this.applicationsTypes_dgv.RowHeadersVisible = false;
            this.applicationsTypes_dgv.RowHeadersWidth = 62;
            this.applicationsTypes_dgv.RowTemplate.Height = 28;
            this.applicationsTypes_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.applicationsTypes_dgv.Size = new System.Drawing.Size(1258, 571);
            this.applicationsTypes_dgv.TabIndex = 10;
            // 
            // OptionscontextMenuStrip
            // 
            this.OptionscontextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.OptionscontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editApplicationTypeToolStripMenuItem});
            this.OptionscontextMenuStrip.Name = "contextMenuStrip1";
            this.OptionscontextMenuStrip.Size = new System.Drawing.Size(320, 42);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            this.editApplicationTypeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editApplicationTypeToolStripMenuItem.Image = global::DVLD.Properties.Resources.manageApplications;
            this.editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            this.editApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(319, 38);
            this.editApplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            this.editApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.editApplicationTypeToolStripMenuItem_Click);
            // 
            // downBtnsPanel
            // 
            this.downBtnsPanel.Controls.Add(this.recordsLabel);
            this.downBtnsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downBtnsPanel.Location = new System.Drawing.Point(0, 598);
            this.downBtnsPanel.Name = "downBtnsPanel";
            this.downBtnsPanel.Size = new System.Drawing.Size(1258, 66);
            this.downBtnsPanel.TabIndex = 11;
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
            // ManageApplicationTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.downBtnsPanel);
            this.Controls.Add(this.applicationsTypes_dgv);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageApplicationTypesForm";
            this.Text = "ManageApplicationTypesForm";
            this.Load += new System.EventHandler(this.ManageApplicationTypesForm_Load);
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsTypes_dgv)).EndInit();
            this.OptionscontextMenuStrip.ResumeLayout(false);
            this.downBtnsPanel.ResumeLayout(false);
            this.downBtnsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox peoplePictureBox;
        private System.Windows.Forms.Label manageLabel;
        private System.Windows.Forms.DataGridView applicationsTypes_dgv;
        private System.Windows.Forms.Panel downBtnsPanel;
        private System.Windows.Forms.Label recordsLabel;
        private System.Windows.Forms.ContextMenuStrip OptionscontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editApplicationTypeToolStripMenuItem;
    }
}