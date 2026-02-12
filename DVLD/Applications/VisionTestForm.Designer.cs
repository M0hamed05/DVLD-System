namespace DVLD.Applications
{
    partial class VisionTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisionTestForm));
            this.downBtnsPanel = new System.Windows.Forms.Panel();
            this.recordsLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.apptiontmentsLabel = new System.Windows.Forms.Label();
            this.appoitments_dgv = new System.Windows.Forms.DataGridView();
            this.OptionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.application_Info_UserControl1 = new DVLD.User_Controls.Application_Info_UserControl();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTestBtn = new System.Windows.Forms.Button();
            this.peoplePictureBox = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.downBtnsPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appoitments_dgv)).BeginInit();
            this.OptionsContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // downBtnsPanel
            // 
            this.downBtnsPanel.Controls.Add(this.closeBtn);
            this.downBtnsPanel.Controls.Add(this.recordsLabel);
            this.downBtnsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downBtnsPanel.Location = new System.Drawing.Point(3, 747);
            this.downBtnsPanel.Name = "downBtnsPanel";
            this.downBtnsPanel.Size = new System.Drawing.Size(997, 66);
            this.downBtnsPanel.TabIndex = 13;
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
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.peoplePictureBox);
            this.titlePanel.Controls.Add(this.headerLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(3, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(997, 76);
            this.titlePanel.TabIndex = 14;
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.headerLabel.Location = new System.Drawing.Point(94, 13);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(486, 51);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Vision Test Appointments";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // middlePanel
            // 
            this.middlePanel.Controls.Add(this.addTestBtn);
            this.middlePanel.Controls.Add(this.apptiontmentsLabel);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.middlePanel.Location = new System.Drawing.Point(3, 514);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(997, 66);
            this.middlePanel.TabIndex = 16;
            // 
            // apptiontmentsLabel
            // 
            this.apptiontmentsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.apptiontmentsLabel.AutoSize = true;
            this.apptiontmentsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptiontmentsLabel.Location = new System.Drawing.Point(12, 16);
            this.apptiontmentsLabel.Name = "apptiontmentsLabel";
            this.apptiontmentsLabel.Size = new System.Drawing.Size(160, 29);
            this.apptiontmentsLabel.TabIndex = 1;
            this.apptiontmentsLabel.Text = "Appoitments";
            // 
            // appoitments_dgv
            // 
            this.appoitments_dgv.AllowUserToAddRows = false;
            this.appoitments_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appoitments_dgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.appoitments_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appoitments_dgv.ContextMenuStrip = this.OptionsContextMenuStrip;
            this.appoitments_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appoitments_dgv.GridColor = System.Drawing.Color.LightGray;
            this.appoitments_dgv.Location = new System.Drawing.Point(3, 580);
            this.appoitments_dgv.Name = "appoitments_dgv";
            this.appoitments_dgv.ReadOnly = true;
            this.appoitments_dgv.RowHeadersVisible = false;
            this.appoitments_dgv.RowHeadersWidth = 62;
            this.appoitments_dgv.RowTemplate.Height = 28;
            this.appoitments_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appoitments_dgv.Size = new System.Drawing.Size(997, 167);
            this.appoitments_dgv.TabIndex = 17;
            // 
            // OptionsContextMenuStrip
            // 
            this.OptionsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.OptionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.OptionsContextMenuStrip.Name = "OptionsContextMenuStrip";
            this.OptionsContextMenuStrip.Size = new System.Drawing.Size(162, 68);
            // 
            // application_Info_UserControl1
            // 
            this.application_Info_UserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.application_Info_UserControl1.Location = new System.Drawing.Point(3, 79);
            this.application_Info_UserControl1.Name = "application_Info_UserControl1";
            this.application_Info_UserControl1.Size = new System.Drawing.Size(997, 435);
            this.application_Info_UserControl1.TabIndex = 15;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.editTest;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.test1;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // addTestBtn
            // 
            this.addTestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addTestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTestBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTestBtn.Image = global::DVLD.Properties.Resources.managetest;
            this.addTestBtn.Location = new System.Drawing.Point(825, 6);
            this.addTestBtn.Name = "addTestBtn";
            this.addTestBtn.Size = new System.Drawing.Size(160, 51);
            this.addTestBtn.TabIndex = 25;
            this.addTestBtn.Text = "Add";
            this.addTestBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addTestBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addTestBtn.UseVisualStyleBackColor = true;
            this.addTestBtn.Click += new System.EventHandler(this.addTestBtn_Click);
            // 
            // peoplePictureBox
            // 
            this.peoplePictureBox.Image = global::DVLD.Properties.Resources.eye;
            this.peoplePictureBox.Location = new System.Drawing.Point(3, 3);
            this.peoplePictureBox.Name = "peoplePictureBox";
            this.peoplePictureBox.Size = new System.Drawing.Size(85, 71);
            this.peoplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.peoplePictureBox.TabIndex = 7;
            this.peoplePictureBox.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Image = global::DVLD.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(815, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(170, 45);
            this.closeBtn.TabIndex = 25;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // VisionTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 816);
            this.Controls.Add(this.appoitments_dgv);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.application_Info_UserControl1);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.downBtnsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VisionTestForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visison Test";
            this.Load += new System.EventHandler(this.VisionTestForm_Load);
            this.downBtnsPanel.ResumeLayout(false);
            this.downBtnsPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.middlePanel.ResumeLayout(false);
            this.middlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appoitments_dgv)).EndInit();
            this.OptionsContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel downBtnsPanel;
        private System.Windows.Forms.Label recordsLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox peoplePictureBox;
        private System.Windows.Forms.Label headerLabel;
        private User_Controls.Application_Info_UserControl application_Info_UserControl1;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Button addTestBtn;
        private System.Windows.Forms.Label apptiontmentsLabel;
        private System.Windows.Forms.DataGridView appoitments_dgv;
        private System.Windows.Forms.ContextMenuStrip OptionsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}