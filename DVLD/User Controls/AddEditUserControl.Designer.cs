namespace DVLD
{
    partial class AddEditUserControl
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
            this.components = new System.ComponentModel.Container();
            this.personGroupBox = new System.Windows.Forms.GroupBox();
            this.removeImageBtn = new System.Windows.Forms.Button();
            this.l_label = new System.Windows.Forms.Label();
            this.t_label = new System.Windows.Forms.Label();
            this.s_label = new System.Windows.Forms.Label();
            this.f_label = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.setImageBtn = new System.Windows.Forms.Button();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.personDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.thirdNameTxtBox = new System.Windows.Forms.TextBox();
            this.secondNameTxtBox = new System.Windows.Forms.TextBox();
            this.nationalNoTxtBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.NationalIDLabel = new System.Windows.Forms.Label();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.personGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // personGroupBox
            // 
            this.personGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.personGroupBox.Controls.Add(this.removeImageBtn);
            this.personGroupBox.Controls.Add(this.l_label);
            this.personGroupBox.Controls.Add(this.t_label);
            this.personGroupBox.Controls.Add(this.s_label);
            this.personGroupBox.Controls.Add(this.f_label);
            this.personGroupBox.Controls.Add(this.closeBtn);
            this.personGroupBox.Controls.Add(this.saveBtn);
            this.personGroupBox.Controls.Add(this.setImageBtn);
            this.personGroupBox.Controls.Add(this.userPicture);
            this.personGroupBox.Controls.Add(this.countryComboBox);
            this.personGroupBox.Controls.Add(this.countryLabel);
            this.personGroupBox.Controls.Add(this.addressTxtBox);
            this.personGroupBox.Controls.Add(this.emailTxtBox);
            this.personGroupBox.Controls.Add(this.phoneTxtBox);
            this.personGroupBox.Controls.Add(this.phoneLabel);
            this.personGroupBox.Controls.Add(this.lastNameTxtBox);
            this.personGroupBox.Controls.Add(this.personDateTimePicker);
            this.personGroupBox.Controls.Add(this.femaleRadioButton);
            this.personGroupBox.Controls.Add(this.maleRadioButton);
            this.personGroupBox.Controls.Add(this.dateOfBirthLabel);
            this.personGroupBox.Controls.Add(this.thirdNameTxtBox);
            this.personGroupBox.Controls.Add(this.secondNameTxtBox);
            this.personGroupBox.Controls.Add(this.nationalNoTxtBox);
            this.personGroupBox.Controls.Add(this.addressLabel);
            this.personGroupBox.Controls.Add(this.emailLabel);
            this.personGroupBox.Controls.Add(this.genderLabel);
            this.personGroupBox.Controls.Add(this.NationalIDLabel);
            this.personGroupBox.Controls.Add(this.firstNameTxtBox);
            this.personGroupBox.Controls.Add(this.namelabel);
            this.personGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.personGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personGroupBox.Location = new System.Drawing.Point(0, 70);
            this.personGroupBox.Name = "personGroupBox";
            this.personGroupBox.Size = new System.Drawing.Size(1080, 440);
            this.personGroupBox.TabIndex = 0;
            this.personGroupBox.TabStop = false;
            this.personGroupBox.Text = "Person ID :  N/A";
            // 
            // removeImageBtn
            // 
            this.removeImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeImageBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeImageBtn.Image = global::DVLD.Properties.Resources.deleteimage;
            this.removeImageBtn.Location = new System.Drawing.Point(889, 337);
            this.removeImageBtn.Name = "removeImageBtn";
            this.removeImageBtn.Size = new System.Drawing.Size(183, 55);
            this.removeImageBtn.TabIndex = 30;
            this.removeImageBtn.Text = "Remove Image";
            this.removeImageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeImageBtn.UseVisualStyleBackColor = true;
            this.removeImageBtn.Visible = false;
            this.removeImageBtn.Click += new System.EventHandler(this.removeImageBtn_Click);
            // 
            // l_label
            // 
            this.l_label.AutoSize = true;
            this.l_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.l_label.Location = new System.Drawing.Point(945, 24);
            this.l_label.Name = "l_label";
            this.l_label.Size = new System.Drawing.Size(48, 23);
            this.l_label.TabIndex = 28;
            this.l_label.Text = "Last";
            this.l_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_label
            // 
            this.t_label.AutoSize = true;
            this.t_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.t_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.t_label.Location = new System.Drawing.Point(740, 24);
            this.t_label.Name = "t_label";
            this.t_label.Size = new System.Drawing.Size(54, 23);
            this.t_label.TabIndex = 27;
            this.t_label.Text = "Third";
            this.t_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // s_label
            // 
            this.s_label.AutoSize = true;
            this.s_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.s_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.s_label.Location = new System.Drawing.Point(523, 24);
            this.s_label.Name = "s_label";
            this.s_label.Size = new System.Drawing.Size(76, 23);
            this.s_label.TabIndex = 26;
            this.s_label.Text = "Second";
            this.s_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f_label
            // 
            this.f_label.AutoSize = true;
            this.f_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.f_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.f_label.Location = new System.Drawing.Point(298, 24);
            this.f_label.Name = "f_label";
            this.f_label.Size = new System.Drawing.Size(49, 23);
            this.f_label.TabIndex = 25;
            this.f_label.Text = "First";
            this.f_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Image = global::DVLD.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(527, 386);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(170, 45);
            this.closeBtn.TabIndex = 24;
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
            this.saveBtn.Location = new System.Drawing.Point(703, 386);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(170, 45);
            this.saveBtn.TabIndex = 23;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // setImageBtn
            // 
            this.setImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setImageBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setImageBtn.Image = global::DVLD.Properties.Resources.image;
            this.setImageBtn.Location = new System.Drawing.Point(889, 281);
            this.setImageBtn.Name = "setImageBtn";
            this.setImageBtn.Size = new System.Drawing.Size(183, 50);
            this.setImageBtn.TabIndex = 22;
            this.setImageBtn.Text = "Set Image";
            this.setImageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.setImageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.setImageBtn.UseVisualStyleBackColor = true;
            this.setImageBtn.Click += new System.EventHandler(this.setImageBtn_Click);
            // 
            // userPicture
            // 
            this.userPicture.Image = global::DVLD.Properties.Resources.defaultuser;
            this.userPicture.Location = new System.Drawing.Point(889, 102);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(170, 158);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 21;
            this.userPicture.TabStop = false;
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(673, 225);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(200, 35);
            this.countryComboBox.TabIndex = 20;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.countryLabel.Image = global::DVLD.Properties.Resources.maps__1_;
            this.countryLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.countryLabel.Location = new System.Drawing.Point(452, 228);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(215, 32);
            this.countryLabel.TabIndex = 19;
            this.countryLabel.Text = "Country:            ";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxtBox.Location = new System.Drawing.Point(239, 281);
            this.addressTxtBox.MaxLength = 500;
            this.addressTxtBox.Multiline = true;
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(634, 99);
            this.addressTxtBox.TabIndex = 18;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtBox.Location = new System.Drawing.Point(239, 227);
            this.emailTxtBox.MaxLength = 50;
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(200, 33);
            this.emailTxtBox.TabIndex = 17;
            this.emailTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailTxtBox_KeyPress);
            this.emailTxtBox.Leave += new System.EventHandler(this.emailTxtBox_Leave);
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxtBox.Location = new System.Drawing.Point(673, 166);
            this.phoneTxtBox.MaxLength = 20;
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(200, 33);
            this.phoneTxtBox.TabIndex = 16;
            this.phoneTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTxtBox_KeyPress);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoneLabel.Image = global::DVLD.Properties.Resources.phone;
            this.phoneLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.phoneLabel.Location = new System.Drawing.Point(452, 169);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(215, 32);
            this.phoneLabel.TabIndex = 15;
            this.phoneLabel.Text = "Phone:              ";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTxtBox.Location = new System.Drawing.Point(889, 50);
            this.lastNameTxtBox.MaxLength = 20;
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(170, 33);
            this.lastNameTxtBox.TabIndex = 14;
            this.lastNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxtBox_KeyPress);
            // 
            // personDateTimePicker
            // 
            this.personDateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.personDateTimePicker.Location = new System.Drawing.Point(673, 102);
            this.personDateTimePicker.Name = "personDateTimePicker";
            this.personDateTimePicker.Size = new System.Drawing.Size(200, 35);
            this.personDateTimePicker.TabIndex = 13;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.Location = new System.Drawing.Point(322, 169);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(117, 31);
            this.femaleRadioButton.TabIndex = 12;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.femaleRadioButton_CheckedChanged);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioButton.Location = new System.Drawing.Point(239, 169);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(88, 31);
            this.maleRadioButton.TabIndex = 11;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.maleRadioButton_CheckedChanged);
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateOfBirthLabel.Image = global::DVLD.Properties.Resources.dataofbirth;
            this.dateOfBirthLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(451, 105);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(216, 32);
            this.dateOfBirthLabel.TabIndex = 10;
            this.dateOfBirthLabel.Text = "Date of Birth:     ";
            this.dateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdNameTxtBox
            // 
            this.thirdNameTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdNameTxtBox.Location = new System.Drawing.Point(673, 50);
            this.thirdNameTxtBox.MaxLength = 20;
            this.thirdNameTxtBox.Name = "thirdNameTxtBox";
            this.thirdNameTxtBox.Size = new System.Drawing.Size(200, 33);
            this.thirdNameTxtBox.TabIndex = 8;
            this.thirdNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxtBox_KeyPress);
            // 
            // secondNameTxtBox
            // 
            this.secondNameTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNameTxtBox.Location = new System.Drawing.Point(457, 50);
            this.secondNameTxtBox.MaxLength = 20;
            this.secondNameTxtBox.Name = "secondNameTxtBox";
            this.secondNameTxtBox.Size = new System.Drawing.Size(200, 33);
            this.secondNameTxtBox.TabIndex = 7;
            this.secondNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxtBox_KeyPress);
            // 
            // nationalNoTxtBox
            // 
            this.nationalNoTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalNoTxtBox.Location = new System.Drawing.Point(239, 108);
            this.nationalNoTxtBox.MaxLength = 20;
            this.nationalNoTxtBox.Name = "nationalNoTxtBox";
            this.nationalNoTxtBox.Size = new System.Drawing.Size(200, 33);
            this.nationalNoTxtBox.TabIndex = 6;
            this.nationalNoTxtBox.Leave += new System.EventHandler(this.nationalNoTxtBox_Leave);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addressLabel.Image = global::DVLD.Properties.Resources.address;
            this.addressLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addressLabel.Location = new System.Drawing.Point(14, 279);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(215, 31);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Address:              ";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailLabel.Image = global::DVLD.Properties.Resources.email;
            this.emailLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailLabel.Location = new System.Drawing.Point(10, 225);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(219, 31);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:                   ";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genderLabel.Image = global::DVLD.Properties.Resources.male_and_female;
            this.genderLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.genderLabel.Location = new System.Drawing.Point(10, 166);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(219, 32);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Gender:             ";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NationalIDLabel
            // 
            this.NationalIDLabel.AutoSize = true;
            this.NationalIDLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalIDLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NationalIDLabel.Image = global::DVLD.Properties.Resources.namecard;
            this.NationalIDLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NationalIDLabel.Location = new System.Drawing.Point(10, 108);
            this.NationalIDLabel.Name = "NationalIDLabel";
            this.NationalIDLabel.Size = new System.Drawing.Size(222, 32);
            this.NationalIDLabel.TabIndex = 2;
            this.NationalIDLabel.Text = "National No:       ";
            this.NationalIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxtBox.Location = new System.Drawing.Point(239, 50);
            this.firstNameTxtBox.MaxLength = 20;
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(200, 33);
            this.firstNameTxtBox.TabIndex = 1;
            this.firstNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxtBox_KeyPress);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.namelabel.Image = global::DVLD.Properties.Resources.nameuser;
            this.namelabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.namelabel.Location = new System.Drawing.Point(10, 52);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(223, 31);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Name:                   ";
            this.namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderLabel.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(1080, 51);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "Add New Person";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddEditUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.personGroupBox);
            this.Name = "AddEditUserControl";
            this.Size = new System.Drawing.Size(1080, 510);
            this.Load += new System.EventHandler(this.AddEditUserControl_Load);
            this.personGroupBox.ResumeLayout(false);
            this.personGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personGroupBox;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label NationalIDLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox thirdNameTxtBox;
        private System.Windows.Forms.TextBox secondNameTxtBox;
        private System.Windows.Forms.TextBox nationalNoTxtBox;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.DateTimePicker personDateTimePicker;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Button setImageBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label s_label;
        private System.Windows.Forms.Label f_label;
        private System.Windows.Forms.Label l_label;
        private System.Windows.Forms.Label t_label;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button removeImageBtn;
    }
}
