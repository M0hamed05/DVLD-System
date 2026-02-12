namespace DVLD
{
    partial class AddEditPersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditPersonForm));
            this.addEditUserControl1 = new DVLD.AddEditUserControl();
            this.SuspendLayout();
            // 
            // addEditUserControl1
            // 
            this.addEditUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEditUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addEditUserControl1.Name = "addEditUserControl1";
            this.addEditUserControl1.Padding = new System.Windows.Forms.Padding(3);
            this.addEditUserControl1.saved = false;
            this.addEditUserControl1.Size = new System.Drawing.Size(1078, 519);
            this.addEditUserControl1.TabIndex = 0;
            // 
            // AddEditPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 519);
            this.Controls.Add(this.addEditUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEditPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Person";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditPersonForm_FormClosing);
            this.Load += new System.EventHandler(this.AddPersonForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AddEditUserControl addEditUserControl1;
    }
}