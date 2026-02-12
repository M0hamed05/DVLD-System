namespace DVLD
{
    partial class PersonDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonDetailsForm));
            this.personInfoUserControl1 = new DVLD.PersonInfoUserControl();
            this.SuspendLayout();
            // 
            // personInfoUserControl1
            // 
            this.personInfoUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personInfoUserControl1.Location = new System.Drawing.Point(0, 0);
            this.personInfoUserControl1.Name = "personInfoUserControl1";
            this.personInfoUserControl1.Padding = new System.Windows.Forms.Padding(5);
            this.personInfoUserControl1.Size = new System.Drawing.Size(1078, 394);
            this.personInfoUserControl1.TabIndex = 0;
            // 
            // PersonDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 394);
            this.Controls.Add(this.personInfoUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Infromation";
            this.Load += new System.EventHandler(this.PersonDetailsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInfoUserControl personInfoUserControl1;
    }
}