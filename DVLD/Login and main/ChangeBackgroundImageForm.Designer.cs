namespace DVLD.Login_and_main
{
    partial class ChangeBackgroundImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeBackgroundImageForm));
            this.setImageBtn = new System.Windows.Forms.Button();
            this.removeImageBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.viewPictureBox = new System.Windows.Forms.PictureBox();
            this.previewLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // setImageBtn
            // 
            this.setImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setImageBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setImageBtn.Image = global::DVLD.Properties.Resources.image;
            this.setImageBtn.Location = new System.Drawing.Point(514, 12);
            this.setImageBtn.Name = "setImageBtn";
            this.setImageBtn.Size = new System.Drawing.Size(183, 50);
            this.setImageBtn.TabIndex = 23;
            this.setImageBtn.Text = "Set Image";
            this.setImageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.setImageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.setImageBtn.UseVisualStyleBackColor = true;
            this.setImageBtn.Click += new System.EventHandler(this.setImageBtn_Click);
            // 
            // removeImageBtn
            // 
            this.removeImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeImageBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeImageBtn.Image = global::DVLD.Properties.Resources.deleteimage;
            this.removeImageBtn.Location = new System.Drawing.Point(514, 79);
            this.removeImageBtn.Name = "removeImageBtn";
            this.removeImageBtn.Size = new System.Drawing.Size(183, 55);
            this.removeImageBtn.TabIndex = 31;
            this.removeImageBtn.Text = "Remove Image";
            this.removeImageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeImageBtn.UseVisualStyleBackColor = true;
            this.removeImageBtn.Visible = false;
            this.removeImageBtn.Click += new System.EventHandler(this.removeImageBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Image = global::DVLD.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(514, 220);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(183, 45);
            this.closeBtn.TabIndex = 32;
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
            this.saveBtn.Location = new System.Drawing.Point(514, 169);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(183, 45);
            this.saveBtn.TabIndex = 33;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // viewPictureBox
            // 
            this.viewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewPictureBox.Location = new System.Drawing.Point(12, 36);
            this.viewPictureBox.Name = "viewPictureBox";
            this.viewPictureBox.Size = new System.Drawing.Size(442, 229);
            this.viewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewPictureBox.TabIndex = 34;
            this.viewPictureBox.TabStop = false;
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewLabel.Location = new System.Drawing.Point(12, 7);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(87, 26);
            this.previewLabel.TabIndex = 35;
            this.previewLabel.Text = "preview";
            // 
            // ChangeBackgroundImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 280);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.viewPictureBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.removeImageBtn);
            this.Controls.Add(this.setImageBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangeBackgroundImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Background Image";
            this.Load += new System.EventHandler(this.ChangeBackgroundImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setImageBtn;
        private System.Windows.Forms.Button removeImageBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox viewPictureBox;
        private System.Windows.Forms.Label previewLabel;
    }
}