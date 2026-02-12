namespace DVLD.Applications
{
    partial class IssueDrivingLicenseApplicaionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueDrivingLicenseApplicaionForm));
            this.application_Info_UserControl1 = new DVLD.User_Controls.Application_Info_UserControl();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTxtBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.IssueBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // application_Info_UserControl1
            // 
            this.application_Info_UserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.application_Info_UserControl1.Location = new System.Drawing.Point(3, 50);
            this.application_Info_UserControl1.Name = "application_Info_UserControl1";
            this.application_Info_UserControl1.Size = new System.Drawing.Size(994, 435);
            this.application_Info_UserControl1.TabIndex = 0;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Image = global::DVLD.Properties.Resources.notes;
            this.notesLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.notesLabel.Location = new System.Drawing.Point(7, 492);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(131, 29);
            this.notesLabel.TabIndex = 1;
            this.notesLabel.Text = "Notes :       ";
            // 
            // notesTxtBox
            // 
            this.notesTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTxtBox.Location = new System.Drawing.Point(144, 491);
            this.notesTxtBox.Multiline = true;
            this.notesTxtBox.Name = "notesTxtBox";
            this.notesTxtBox.Size = new System.Drawing.Size(837, 114);
            this.notesTxtBox.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Image = global::DVLD.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(625, 618);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(170, 45);
            this.closeBtn.TabIndex = 44;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // IssueBtn
            // 
            this.IssueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IssueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBtn.Image = global::DVLD.Properties.Resources.namecard;
            this.IssueBtn.Location = new System.Drawing.Point(812, 618);
            this.IssueBtn.Name = "IssueBtn";
            this.IssueBtn.Size = new System.Drawing.Size(170, 45);
            this.IssueBtn.TabIndex = 43;
            this.IssueBtn.Text = " Issue";
            this.IssueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IssueBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IssueBtn.UseVisualStyleBackColor = true;
            this.IssueBtn.Click += new System.EventHandler(this.IssueBtn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(994, 47);
            this.label1.TabIndex = 45;
            this.label1.Text = "Issue New Driving License";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IssueDrivingLicenseApplicaionForm1cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 669);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.IssueBtn);
            this.Controls.Add(this.notesTxtBox);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.application_Info_UserControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IssueDrivingLicenseApplicaionForm1cs";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driving License Applicaion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.Application_Info_UserControl application_Info_UserControl1;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesTxtBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button IssueBtn;
        private System.Windows.Forms.Label label1;
    }
}