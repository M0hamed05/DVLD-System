namespace DVLD
{
    partial class ManageTestTypeForm
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
            this.manageLabel = new System.Windows.Forms.Label();
            this.peoplePictureBox = new System.Windows.Forms.PictureBox();
            this.TestTypes_dgv = new System.Windows.Forms.DataGridView();
            this.downBtnsPanel = new System.Windows.Forms.Panel();
            this.recordsLabel = new System.Windows.Forms.Label();
            this.optionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTextTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestTypes_dgv)).BeginInit();
            this.downBtnsPanel.SuspendLayout();
            this.optionsContextMenuStrip.SuspendLayout();
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
            this.titlePanel.TabIndex = 10;
            // 
            // manageLabel
            // 
            this.manageLabel.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.manageLabel.Location = new System.Drawing.Point(102, 39);
            this.manageLabel.Name = "manageLabel";
            this.manageLabel.Size = new System.Drawing.Size(425, 51);
            this.manageLabel.TabIndex = 0;
            this.manageLabel.Text = "Manage Test Types";
            this.manageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // peoplePictureBox
            // 
            this.peoplePictureBox.Image = global::DVLD.Properties.Resources.editTest;
            this.peoplePictureBox.Location = new System.Drawing.Point(3, 3);
            this.peoplePictureBox.Name = "peoplePictureBox";
            this.peoplePictureBox.Size = new System.Drawing.Size(93, 87);
            this.peoplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.peoplePictureBox.TabIndex = 7;
            this.peoplePictureBox.TabStop = false;
            // 
            // TestTypes_dgv
            // 
            this.TestTypes_dgv.AllowUserToAddRows = false;
            this.TestTypes_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TestTypes_dgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.TestTypes_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestTypes_dgv.ContextMenuStrip = this.optionsContextMenuStrip;
            this.TestTypes_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestTypes_dgv.GridColor = System.Drawing.Color.LightGray;
            this.TestTypes_dgv.Location = new System.Drawing.Point(0, 93);
            this.TestTypes_dgv.Name = "TestTypes_dgv";
            this.TestTypes_dgv.ReadOnly = true;
            this.TestTypes_dgv.RowHeadersVisible = false;
            this.TestTypes_dgv.RowHeadersWidth = 62;
            this.TestTypes_dgv.RowTemplate.Height = 28;
            this.TestTypes_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TestTypes_dgv.Size = new System.Drawing.Size(1258, 571);
            this.TestTypes_dgv.TabIndex = 11;
            // 
            // downBtnsPanel
            // 
            this.downBtnsPanel.Controls.Add(this.recordsLabel);
            this.downBtnsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downBtnsPanel.Location = new System.Drawing.Point(0, 598);
            this.downBtnsPanel.Name = "downBtnsPanel";
            this.downBtnsPanel.Size = new System.Drawing.Size(1258, 66);
            this.downBtnsPanel.TabIndex = 12;
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
            // optionsContextMenuStrip
            // 
            this.optionsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.optionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTextTypeToolStripMenuItem});
            this.optionsContextMenuStrip.Name = "optionsContextMenuStrip";
            this.optionsContextMenuStrip.Size = new System.Drawing.Size(249, 75);
            // 
            // editTextTypeToolStripMenuItem
            // 
            this.editTextTypeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editTextTypeToolStripMenuItem.Image = global::DVLD.Properties.Resources.editTest;
            this.editTextTypeToolStripMenuItem.Name = "editTextTypeToolStripMenuItem";
            this.editTextTypeToolStripMenuItem.Size = new System.Drawing.Size(248, 38);
            this.editTextTypeToolStripMenuItem.Text = "Edit Test Type";
            this.editTextTypeToolStripMenuItem.Click += new System.EventHandler(this.editTextTypeToolStripMenuItem_Click);
            // 
            // ManageTestTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.downBtnsPanel);
            this.Controls.Add(this.TestTypes_dgv);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageTestTypeForm";
            this.Text = "ManageTestTypeForm";
            this.Load += new System.EventHandler(this.ManageTestTypeForm_Load);
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestTypes_dgv)).EndInit();
            this.downBtnsPanel.ResumeLayout(false);
            this.downBtnsPanel.PerformLayout();
            this.optionsContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox peoplePictureBox;
        private System.Windows.Forms.Label manageLabel;
        private System.Windows.Forms.DataGridView TestTypes_dgv;
        private System.Windows.Forms.Panel downBtnsPanel;
        private System.Windows.Forms.Label recordsLabel;
        private System.Windows.Forms.ContextMenuStrip optionsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editTextTypeToolStripMenuItem;
    }
}