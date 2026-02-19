namespace DVLD
{
    partial class PeersonInfoWithFilterUserControl
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
            this.filterPanel = new System.Windows.Forms.Panel();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.allUsersComboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.fliterLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.personInfoUserControl1 = new DVLD.PersonInfoUserControl();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.addPersonButton);
            this.filterPanel.Controls.Add(this.allUsersComboBox);
            this.filterPanel.Controls.Add(this.addBtn);
            this.filterPanel.Controls.Add(this.fliterLabel);
            this.filterPanel.Controls.Add(this.filterComboBox);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Padding = new System.Windows.Forms.Padding(3);
            this.filterPanel.Size = new System.Drawing.Size(1101, 59);
            this.filterPanel.TabIndex = 4;
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
            this.allUsersComboBox.Location = new System.Drawing.Point(353, 9);
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
            // personInfoUserControl1
            // 
            this.personInfoUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.personInfoUserControl1.Location = new System.Drawing.Point(0, 69);
            this.personInfoUserControl1.Name = "personInfoUserControl1";
            this.personInfoUserControl1.Size = new System.Drawing.Size(1101, 394);
            this.personInfoUserControl1.TabIndex = 3;
            // 
            // PeersonInfoWithFilterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.personInfoUserControl1);
            this.Name = "PeersonInfoWithFilterUserControl";
            this.Size = new System.Drawing.Size(1101, 463);
            this.Load += new System.EventHandler(this.PeersonInfoWithFilterUserControl_Load);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInfoUserControl personInfoUserControl1;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.ComboBox allUsersComboBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label fliterLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
    }
}
