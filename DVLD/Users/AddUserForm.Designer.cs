namespace DVLD
{
    partial class AddEditUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditUserForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.buttomPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.allUsersComboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.fliterLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.nextBtnPanel = new System.Windows.Forms.Panel();
            this.nxtBtn = new System.Windows.Forms.Button();
            this.loginInfoPanel = new System.Windows.Forms.Panel();
            this.passowrdTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.isActiveCheckButton = new System.Windows.Forms.CheckBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.confrimPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.personInfoUserControl1 = new DVLD.PersonInfoUserControl();
            this.HeaderPanel.SuspendLayout();
            this.buttomPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.nextBtnPanel.SuspendLayout();
            this.loginInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.headerLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(5, 5);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1091, 60);
            this.HeaderPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1091, 54);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Add New User";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttomPanel
            // 
            this.buttomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttomPanel.Controls.Add(this.closeBtn);
            this.buttomPanel.Controls.Add(this.saveBtn);
            this.buttomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttomPanel.Location = new System.Drawing.Point(5, 677);
            this.buttomPanel.Name = "buttomPanel";
            this.buttomPanel.Size = new System.Drawing.Size(1091, 62);
            this.buttomPanel.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Image = global::DVLD.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(744, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(170, 45);
            this.closeBtn.TabIndex = 26;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Image = global::DVLD.Properties.Resources.save;
            this.saveBtn.Location = new System.Drawing.Point(920, 6);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(170, 45);
            this.saveBtn.TabIndex = 25;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // filterPanel
            // 
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.addPersonButton);
            this.filterPanel.Controls.Add(this.allUsersComboBox);
            this.filterPanel.Controls.Add(this.addBtn);
            this.filterPanel.Controls.Add(this.fliterLabel);
            this.filterPanel.Controls.Add(this.filterComboBox);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filterPanel.Location = new System.Drawing.Point(5, 62);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Padding = new System.Windows.Forms.Padding(3);
            this.filterPanel.Size = new System.Drawing.Size(1091, 59);
            this.filterPanel.TabIndex = 3;
            // 
            // addPersonButton
            // 
            this.addPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPersonButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPersonButton.Image = global::DVLD.Properties.Resources.adduserBlack;
            this.addPersonButton.Location = new System.Drawing.Point(763, 9);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(178, 36);
            this.addPersonButton.TabIndex = 28;
            this.addPersonButton.Text = "Add Person";
            this.addPersonButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPersonButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // allUsersComboBox
            // 
            this.allUsersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allUsersComboBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUsersComboBox.FormattingEnabled = true;
            this.allUsersComboBox.Location = new System.Drawing.Point(353, 10);
            this.allUsersComboBox.Name = "allUsersComboBox";
            this.allUsersComboBox.Size = new System.Drawing.Size(220, 34);
            this.allUsersComboBox.TabIndex = 27;
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Image = global::DVLD.Properties.Resources.adduserBlack;
            this.addBtn.Location = new System.Drawing.Point(579, 9);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(178, 36);
            this.addBtn.TabIndex = 26;
            this.addBtn.Text = "Add";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // fliterLabel
            // 
            this.fliterLabel.AutoSize = true;
            this.fliterLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fliterLabel.Location = new System.Drawing.Point(5, 10);
            this.fliterLabel.Name = "fliterLabel";
            this.fliterLabel.Size = new System.Drawing.Size(116, 29);
            this.fliterLabel.TabIndex = 6;
            this.fliterLabel.Text = "Fliter By:";
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(127, 9);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(220, 34);
            this.filterComboBox.TabIndex = 7;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // nextBtnPanel
            // 
            this.nextBtnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nextBtnPanel.Controls.Add(this.nxtBtn);
            this.nextBtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nextBtnPanel.Location = new System.Drawing.Point(5, 515);
            this.nextBtnPanel.Name = "nextBtnPanel";
            this.nextBtnPanel.Size = new System.Drawing.Size(1091, 60);
            this.nextBtnPanel.TabIndex = 4;
            // 
            // nxtBtn
            // 
            this.nxtBtn.Enabled = false;
            this.nxtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nxtBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxtBtn.Image = global::DVLD.Properties.Resources.next;
            this.nxtBtn.Location = new System.Drawing.Point(10, 6);
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.Size = new System.Drawing.Size(170, 45);
            this.nxtBtn.TabIndex = 27;
            this.nxtBtn.Text = "Next";
            this.nxtBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nxtBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.nxtBtn.UseVisualStyleBackColor = true;
            this.nxtBtn.Click += new System.EventHandler(this.nxtBtn_Click);
            // 
            // loginInfoPanel
            // 
            this.loginInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginInfoPanel.Controls.Add(this.passowrdTxtBox);
            this.loginInfoPanel.Controls.Add(this.usernameTxtBox);
            this.loginInfoPanel.Controls.Add(this.isActiveCheckButton);
            this.loginInfoPanel.Controls.Add(this.confirmPasswordLabel);
            this.loginInfoPanel.Controls.Add(this.passwordLabel);
            this.loginInfoPanel.Controls.Add(this.usernameLabel);
            this.loginInfoPanel.Controls.Add(this.confrimPasswordTxtBox);
            this.loginInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginInfoPanel.Location = new System.Drawing.Point(5, 575);
            this.loginInfoPanel.Name = "loginInfoPanel";
            this.loginInfoPanel.Padding = new System.Windows.Forms.Padding(3);
            this.loginInfoPanel.Size = new System.Drawing.Size(1091, 102);
            this.loginInfoPanel.TabIndex = 5;
            this.loginInfoPanel.Visible = false;
            // 
            // passowrdTxtBox
            // 
            this.passowrdTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passowrdTxtBox.Location = new System.Drawing.Point(322, 52);
            this.passowrdTxtBox.Name = "passowrdTxtBox";
            this.passowrdTxtBox.Size = new System.Drawing.Size(262, 33);
            this.passowrdTxtBox.TabIndex = 15;
            this.passowrdTxtBox.UseSystemPasswordChar = true;
            this.passowrdTxtBox.Leave += new System.EventHandler(this.passowrdTxtBox_Leave);
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(8, 53);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(262, 33);
            this.usernameTxtBox.TabIndex = 14;
            this.usernameTxtBox.Leave += new System.EventHandler(this.usernameTxtBox_Leave);
            // 
            // isActiveCheckButton
            // 
            this.isActiveCheckButton.AutoSize = true;
            this.isActiveCheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveCheckButton.Location = new System.Drawing.Point(926, 55);
            this.isActiveCheckButton.Name = "isActiveCheckButton";
            this.isActiveCheckButton.Size = new System.Drawing.Size(144, 34);
            this.isActiveCheckButton.TabIndex = 13;
            this.isActiveCheckButton.Text = "Is Actvie";
            this.isActiveCheckButton.UseVisualStyleBackColor = true;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Image = global::DVLD.Properties.Resources.passwordchange;
            this.confirmPasswordLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(627, 24);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(267, 29);
            this.confirmPasswordLabel.TabIndex = 11;
            this.confirmPasswordLabel.Text = "Confrim Passowrd:     ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Image = global::DVLD.Properties.Resources.passwordchange;
            this.passwordLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passwordLabel.Location = new System.Drawing.Point(320, 24);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(168, 29);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Passowrd:     ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Image = global::DVLD.Properties.Resources.nameuser;
            this.usernameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usernameLabel.Location = new System.Drawing.Point(11, 24);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(164, 29);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "UserName:    ";
            // 
            // confrimPasswordTxtBox
            // 
            this.confrimPasswordTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrimPasswordTxtBox.Location = new System.Drawing.Point(629, 53);
            this.confrimPasswordTxtBox.Name = "confrimPasswordTxtBox";
            this.confrimPasswordTxtBox.Size = new System.Drawing.Size(262, 33);
            this.confrimPasswordTxtBox.TabIndex = 8;
            this.confrimPasswordTxtBox.UseSystemPasswordChar = true;
            this.confrimPasswordTxtBox.Leave += new System.EventHandler(this.confrimPasswordTxtBox_Leave);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // personInfoUserControl1
            // 
            this.personInfoUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.personInfoUserControl1.Location = new System.Drawing.Point(5, 121);
            this.personInfoUserControl1.Name = "personInfoUserControl1";
            this.personInfoUserControl1.Size = new System.Drawing.Size(1091, 394);
            this.personInfoUserControl1.TabIndex = 2;
            // 
            // AddEditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 744);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.personInfoUserControl1);
            this.Controls.Add(this.nextBtnPanel);
            this.Controls.Add(this.loginInfoPanel);
            this.Controls.Add(this.buttomPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEditUserForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.buttomPanel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.nextBtnPanel.ResumeLayout(false);
            this.loginInfoPanel.ResumeLayout(false);
            this.loginInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel buttomPanel;
        private PersonInfoUserControl personInfoUserControl1;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label fliterLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Panel nextBtnPanel;
        private System.Windows.Forms.Button nxtBtn;
        private System.Windows.Forms.Panel loginInfoPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox confrimPasswordTxtBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passowrdTxtBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.CheckBox isActiveCheckButton;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox allUsersComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button addPersonButton;
    }
}