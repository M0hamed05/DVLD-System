namespace DVLD
{
    partial class PeopleForm
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
            this.people_dgv = new System.Windows.Forms.DataGridView();
            this.OptionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downBtnsPanel = new System.Windows.Forms.Panel();
            this.recordsLabel = new System.Windows.Forms.Label();
            this.fliterLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filter_txtbox = new System.Windows.Forms.TextBox();
            this.upperButtenPanels = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.manageLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.peoplePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.people_dgv)).BeginInit();
            this.OptionsContextMenuStrip.SuspendLayout();
            this.downBtnsPanel.SuspendLayout();
            this.upperButtenPanels.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // people_dgv
            // 
            this.people_dgv.AllowUserToAddRows = false;
            this.people_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.people_dgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.people_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.people_dgv.ContextMenuStrip = this.OptionsContextMenuStrip;
            this.people_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.people_dgv.GridColor = System.Drawing.Color.LightGray;
            this.people_dgv.Location = new System.Drawing.Point(0, 197);
            this.people_dgv.Name = "people_dgv";
            this.people_dgv.ReadOnly = true;
            this.people_dgv.RowHeadersVisible = false;
            this.people_dgv.RowHeadersWidth = 62;
            this.people_dgv.RowTemplate.Height = 28;
            this.people_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.people_dgv.Size = new System.Drawing.Size(1258, 401);
            this.people_dgv.TabIndex = 1;
            // 
            // OptionsContextMenuStrip
            // 
            this.OptionsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.OptionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetialsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.OptionsContextMenuStrip.Name = "OptionsContextMenuStrip";
            this.OptionsContextMenuStrip.Size = new System.Drawing.Size(237, 220);
            // 
            // showDetialsToolStripMenuItem
            // 
            this.showDetialsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.showDetialsToolStripMenuItem.Image = global::DVLD.Properties.Resources.details;
            this.showDetialsToolStripMenuItem.Name = "showDetialsToolStripMenuItem";
            this.showDetialsToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.showDetialsToolStripMenuItem.Text = "Show Detials";
            this.showDetialsToolStripMenuItem.Click += new System.EventHandler(this.showDetialsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addNewPersonToolStripMenuItem.Image = global::DVLD.Properties.Resources.adduser;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.useredit2;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.editToolStripMenuItem.Text = "Edit ";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.deleteuser;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.email;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.phone;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // downBtnsPanel
            // 
            this.downBtnsPanel.Controls.Add(this.recordsLabel);
            this.downBtnsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downBtnsPanel.Location = new System.Drawing.Point(0, 598);
            this.downBtnsPanel.Name = "downBtnsPanel";
            this.downBtnsPanel.Size = new System.Drawing.Size(1258, 66);
            this.downBtnsPanel.TabIndex = 2;
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
            this.filter_txtbox.Location = new System.Drawing.Point(365, 62);
            this.filter_txtbox.Name = "filter_txtbox";
            this.filter_txtbox.Size = new System.Drawing.Size(250, 35);
            this.filter_txtbox.TabIndex = 5;
            this.filter_txtbox.TextChanged += new System.EventHandler(this.filter_txtbox_TextChanged);
            this.filter_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filter_txtbox_KeyPress);
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
            this.upperButtenPanels.Size = new System.Drawing.Size(1258, 104);
            this.upperButtenPanels.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addBtn.Image = global::DVLD.Properties.Resources.adduser;
            this.addBtn.Location = new System.Drawing.Point(1105, 61);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(150, 40);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // manageLabel
            // 
            this.manageLabel.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.manageLabel.Location = new System.Drawing.Point(102, 39);
            this.manageLabel.Name = "manageLabel";
            this.manageLabel.Size = new System.Drawing.Size(352, 51);
            this.manageLabel.TabIndex = 0;
            this.manageLabel.Text = "Manage People ";
            this.manageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.peoplePictureBox);
            this.titlePanel.Controls.Add(this.manageLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1258, 93);
            this.titlePanel.TabIndex = 8;
            // 
            // peoplePictureBox
            // 
            this.peoplePictureBox.Image = global::DVLD.Properties.Resources.people;
            this.peoplePictureBox.Location = new System.Drawing.Point(3, 3);
            this.peoplePictureBox.Name = "peoplePictureBox";
            this.peoplePictureBox.Size = new System.Drawing.Size(93, 87);
            this.peoplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.peoplePictureBox.TabIndex = 7;
            this.peoplePictureBox.TabStop = false;
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.people_dgv);
            this.Controls.Add(this.upperButtenPanels);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.downBtnsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeopleForm";
            this.Text = "PeopleForm";
            this.Load += new System.EventHandler(this.PeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.people_dgv)).EndInit();
            this.OptionsContextMenuStrip.ResumeLayout(false);
            this.downBtnsPanel.ResumeLayout(false);
            this.downBtnsPanel.PerformLayout();
            this.upperButtenPanels.ResumeLayout(false);
            this.upperButtenPanels.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView people_dgv;
        private System.Windows.Forms.Panel downBtnsPanel;
        private System.Windows.Forms.Label recordsLabel;
        private System.Windows.Forms.Label fliterLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.TextBox filter_txtbox;
        private System.Windows.Forms.Panel upperButtenPanels;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label manageLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox peoplePictureBox;
        private System.Windows.Forms.ContextMenuStrip OptionsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showDetialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}