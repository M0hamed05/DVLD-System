namespace DVLD
{
    partial class UserInfoUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.personInfoUserControl1 = new DVLD.PersonInfoUserControl();
            this.loginInfoPanel = new System.Windows.Forms.Panel();
            this.userIDTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.isActiveTxtBox = new System.Windows.Forms.TextBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.loginInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // personInfoUserControl1
            // 
            this.personInfoUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.personInfoUserControl1.Location = new System.Drawing.Point(0, 0);
            this.personInfoUserControl1.Name = "personInfoUserControl1";
            this.personInfoUserControl1.Size = new System.Drawing.Size(1084, 408);
            this.personInfoUserControl1.TabIndex = 9;
            // 
            // loginInfoPanel
            // 
            this.loginInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginInfoPanel.Controls.Add(this.isActiveTxtBox);
            this.loginInfoPanel.Controls.Add(this.isActiveLabel);
            this.loginInfoPanel.Controls.Add(this.userIDTxtBox);
            this.loginInfoPanel.Controls.Add(this.usernameTxtBox);
            this.loginInfoPanel.Controls.Add(this.passwordLabel);
            this.loginInfoPanel.Controls.Add(this.usernameLabel);
            this.loginInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginInfoPanel.Location = new System.Drawing.Point(0, 414);
            this.loginInfoPanel.Name = "loginInfoPanel";
            this.loginInfoPanel.Padding = new System.Windows.Forms.Padding(3);
            this.loginInfoPanel.Size = new System.Drawing.Size(1084, 117);
            this.loginInfoPanel.TabIndex = 8;
            // 
            // userIDTxtBox
            // 
            this.userIDTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTxtBox.Location = new System.Drawing.Point(183, 38);
            this.userIDTxtBox.Name = "userIDTxtBox";
            this.userIDTxtBox.ReadOnly = true;
            this.userIDTxtBox.Size = new System.Drawing.Size(90, 33);
            this.userIDTxtBox.TabIndex = 15;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(493, 41);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.ReadOnly = true;
            this.usernameTxtBox.Size = new System.Drawing.Size(262, 33);
            this.usernameTxtBox.TabIndex = 14;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passwordLabel.Location = new System.Drawing.Point(67, 38);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(110, 29);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "User ID: ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Image = global::DVLD.Properties.Resources.nameuser;
            this.usernameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usernameLabel.Location = new System.Drawing.Point(313, 42);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(164, 29);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "UserName:    ";
            // 
            // isActiveTxtBox
            // 
            this.isActiveTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveTxtBox.Location = new System.Drawing.Point(937, 42);
            this.isActiveTxtBox.Name = "isActiveTxtBox";
            this.isActiveTxtBox.ReadOnly = true;
            this.isActiveTxtBox.Size = new System.Drawing.Size(90, 33);
            this.isActiveTxtBox.TabIndex = 17;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActiveLabel.Location = new System.Drawing.Point(807, 42);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(124, 29);
            this.isActiveLabel.TabIndex = 16;
            this.isActiveLabel.Text = "Is Active: ";
            // 
            // UserInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.personInfoUserControl1);
            this.Controls.Add(this.loginInfoPanel);
            this.Name = "UserInfoUserControl";
            this.Size = new System.Drawing.Size(1084, 531);
            this.Load += new System.EventHandler(this.UserInfoUserControl_Load);
            this.loginInfoPanel.ResumeLayout(false);
            this.loginInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInfoUserControl personInfoUserControl1;
        private System.Windows.Forms.Panel loginInfoPanel;
        private System.Windows.Forms.TextBox userIDTxtBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox isActiveTxtBox;
        private System.Windows.Forms.Label isActiveLabel;
    }
}
