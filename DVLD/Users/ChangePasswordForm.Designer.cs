namespace DVLD
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.loginInfoPanel = new System.Windows.Forms.Panel();
            this.passowrdTxtBox = new System.Windows.Forms.TextBox();
            this.oldpasswordTxtBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.confrimPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.buttomPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.userInfoUserControl1 = new DVLD.UserInfoUserControl();
            this.loginInfoPanel.SuspendLayout();
            this.buttomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // loginInfoPanel
            // 
            this.loginInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginInfoPanel.Controls.Add(this.passowrdTxtBox);
            this.loginInfoPanel.Controls.Add(this.oldpasswordTxtBox);
            this.loginInfoPanel.Controls.Add(this.confirmPasswordLabel);
            this.loginInfoPanel.Controls.Add(this.passwordLabel);
            this.loginInfoPanel.Controls.Add(this.oldPasswordLabel);
            this.loginInfoPanel.Controls.Add(this.confrimPasswordTxtBox);
            this.loginInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginInfoPanel.Location = new System.Drawing.Point(0, 534);
            this.loginInfoPanel.Name = "loginInfoPanel";
            this.loginInfoPanel.Padding = new System.Windows.Forms.Padding(3);
            this.loginInfoPanel.Size = new System.Drawing.Size(1109, 102);
            this.loginInfoPanel.TabIndex = 6;
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
            // oldpasswordTxtBox
            // 
            this.oldpasswordTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldpasswordTxtBox.Location = new System.Drawing.Point(8, 53);
            this.oldpasswordTxtBox.Name = "oldpasswordTxtBox";
            this.oldpasswordTxtBox.Size = new System.Drawing.Size(262, 33);
            this.oldpasswordTxtBox.TabIndex = 14;
            this.oldpasswordTxtBox.UseSystemPasswordChar = true;
            this.oldpasswordTxtBox.Leave += new System.EventHandler(this.oldPasswordTxtBox_Leave);
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
            this.passwordLabel.Location = new System.Drawing.Point(317, 24);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(224, 29);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "New Passowrd:     ";
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordLabel.Image = global::DVLD.Properties.Resources.passwordchange;
            this.oldPasswordLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.oldPasswordLabel.Location = new System.Drawing.Point(11, 24);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(201, 29);
            this.oldPasswordLabel.TabIndex = 9;
            this.oldPasswordLabel.Text = "Old Password    ";
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
            // buttomPanel
            // 
            this.buttomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttomPanel.Controls.Add(this.closeBtn);
            this.buttomPanel.Controls.Add(this.saveBtn);
            this.buttomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttomPanel.Location = new System.Drawing.Point(0, 636);
            this.buttomPanel.Name = "buttomPanel";
            this.buttomPanel.Size = new System.Drawing.Size(1109, 62);
            this.buttomPanel.TabIndex = 7;
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
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // userInfoUserControl1
            // 
            this.userInfoUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userInfoUserControl1.Location = new System.Drawing.Point(0, 0);
            this.userInfoUserControl1.Name = "userInfoUserControl1";
            this.userInfoUserControl1.Size = new System.Drawing.Size(1109, 532);
            this.userInfoUserControl1.TabIndex = 0;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 698);
            this.Controls.Add(this.loginInfoPanel);
            this.Controls.Add(this.userInfoUserControl1);
            this.Controls.Add(this.buttomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePasswordForm";
            this.Text = "Change User Password";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.loginInfoPanel.ResumeLayout(false);
            this.loginInfoPanel.PerformLayout();
            this.buttomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserInfoUserControl userInfoUserControl1;
        private System.Windows.Forms.Panel loginInfoPanel;
        private System.Windows.Forms.TextBox passowrdTxtBox;
        private System.Windows.Forms.TextBox oldpasswordTxtBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.TextBox confrimPasswordTxtBox;
        private System.Windows.Forms.Panel buttomPanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}