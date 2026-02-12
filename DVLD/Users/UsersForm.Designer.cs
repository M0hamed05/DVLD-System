namespace DVLD
{
    partial class UsersForm
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
            this.upperButtenPanels = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.fliterLabel = new System.Windows.Forms.Label();
            this.filter_txtbox = new System.Windows.Forms.TextBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.users_dgv = new System.Windows.Forms.DataGridView();
            this.optionsCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downBtnsPanel = new System.Windows.Forms.Panel();
            this.recordsLabel = new System.Windows.Forms.Label();
            this.activeCasesComboBox = new System.Windows.Forms.ComboBox();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).BeginInit();
            this.upperButtenPanels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_dgv)).BeginInit();
            this.optionsCMS.SuspendLayout();
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
            this.peoplePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.peoplePictureBox.Image = global::DVLD.Properties.Resources.users1;
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
            this.manageLabel.Size = new System.Drawing.Size(352, 51);
            this.manageLabel.TabIndex = 0;
            this.manageLabel.Text = "Manage Users ";
            this.manageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upperButtenPanels
            // 
            this.upperButtenPanels.Controls.Add(this.activeCasesComboBox);
            this.upperButtenPanels.Controls.Add(this.addBtn);
            this.upperButtenPanels.Controls.Add(this.fliterLabel);
            this.upperButtenPanels.Controls.Add(this.filter_txtbox);
            this.upperButtenPanels.Controls.Add(this.filterComboBox);
            this.upperButtenPanels.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperButtenPanels.Location = new System.Drawing.Point(0, 93);
            this.upperButtenPanels.Name = "upperButtenPanels";
            this.upperButtenPanels.Size = new System.Drawing.Size(1258, 104);
            this.upperButtenPanels.TabIndex = 10;
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
            this.filter_txtbox.Location = new System.Drawing.Point(364, 62);
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
            this.filterComboBox.Location = new System.Drawing.Point(138, 63);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(220, 34);
            this.filterComboBox.TabIndex = 4;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // users_dgv
            // 
            this.users_dgv.AllowUserToAddRows = false;
            this.users_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.users_dgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.users_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_dgv.ContextMenuStrip = this.optionsCMS;
            this.users_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users_dgv.GridColor = System.Drawing.Color.LightGray;
            this.users_dgv.Location = new System.Drawing.Point(0, 197);
            this.users_dgv.Name = "users_dgv";
            this.users_dgv.ReadOnly = true;
            this.users_dgv.RowHeadersVisible = false;
            this.users_dgv.RowHeadersWidth = 62;
            this.users_dgv.RowTemplate.Height = 28;
            this.users_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.users_dgv.Size = new System.Drawing.Size(1258, 467);
            this.users_dgv.TabIndex = 11;
            // 
            // optionsCMS
            // 
            this.optionsCMS.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.optionsCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.deleteUserStripMenuItem1,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.optionsCMS.Name = "optionsCMS";
            this.optionsCMS.Size = new System.Drawing.Size(249, 287);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.details;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addNewUserToolStripMenuItem.Image = global::DVLD.Properties.Resources.adduserBlack;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editUserToolStripMenuItem.Image = global::DVLD.Properties.Resources.useredit2;
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // deleteUserStripMenuItem1
            // 
            this.deleteUserStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteUserStripMenuItem1.Image = global::DVLD.Properties.Resources.deleteuser;
            this.deleteUserStripMenuItem1.Name = "deleteUserStripMenuItem1";
            this.deleteUserStripMenuItem1.Size = new System.Drawing.Size(244, 34);
            this.deleteUserStripMenuItem1.Text = "Delete User";
            this.deleteUserStripMenuItem1.Click += new System.EventHandler(this.deleteUserStripMenuItem1_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.changePasswordToolStripMenuItem.Image = global::DVLD.Properties.Resources.passwordchange;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(241, 6);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sendToolStripMenuItem.Image = global::DVLD.Properties.Resources.email;
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
            this.sendToolStripMenuItem.Text = "Send Email";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.phone;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
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
            // activeCasesComboBox
            // 
            this.activeCasesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activeCasesComboBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeCasesComboBox.FormattingEnabled = true;
            this.activeCasesComboBox.Items.AddRange(new object[] {
            "All",
            "No",
            "Yes"});
            this.activeCasesComboBox.Location = new System.Drawing.Point(364, 61);
            this.activeCasesComboBox.Name = "activeCasesComboBox";
            this.activeCasesComboBox.Size = new System.Drawing.Size(117, 34);
            this.activeCasesComboBox.TabIndex = 7;
            this.activeCasesComboBox.Visible = false;
            this.activeCasesComboBox.SelectedIndexChanged += new System.EventHandler(this.activeCasesComboBox_SelectedIndexChanged);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.downBtnsPanel);
            this.Controls.Add(this.users_dgv);
            this.Controls.Add(this.upperButtenPanels);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peoplePictureBox)).EndInit();
            this.upperButtenPanels.ResumeLayout(false);
            this.upperButtenPanels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_dgv)).EndInit();
            this.optionsCMS.ResumeLayout(false);
            this.downBtnsPanel.ResumeLayout(false);
            this.downBtnsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox peoplePictureBox;
        private System.Windows.Forms.Label manageLabel;
        private System.Windows.Forms.Panel upperButtenPanels;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label fliterLabel;
        private System.Windows.Forms.TextBox filter_txtbox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.DataGridView users_dgv;
        private System.Windows.Forms.Panel downBtnsPanel;
        private System.Windows.Forms.Label recordsLabel;
        private System.Windows.Forms.ContextMenuStrip optionsCMS;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteUserStripMenuItem1;
        private System.Windows.Forms.ComboBox activeCasesComboBox;
    }
}