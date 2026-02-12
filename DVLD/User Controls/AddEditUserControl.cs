using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class AddEditUserControl : UserControl
    {
        public AddEditUserControl()
        {
            InitializeComponent();
        }

        public bool saved { get; set; } = false;
        private bool editmode = false;
        private int personID = -1;
        private bool PersonalImage = false;
        private DVLDShared.stPerson personData;

        private bool change_happend()
        {

            string current_image_name = Path.GetFileName(userPicture.ImageLocation??"");
            string db_image_name = "";
            if (!File.Exists(personData.ImagePath))
            {

            }
            else
            {
                db_image_name = Path.GetFileName(Convert.ToString(personData.ImagePath));
            }
            if (firstNameTxtBox.Text != Convert.ToString(personData.FirstName)) return true;
            if (secondNameTxtBox.Text != Convert.ToString(personData.SecondName)) return true;
            if(thirdNameTxtBox.Text != (Convert.ToString(personData.ThirdName)??"")) return true;
            if (lastNameTxtBox.Text != Convert.ToString(personData.LastName)) return true;
            if (nationalNoTxtBox.Text != Convert.ToString(personData.NationalNo)) return true;
            if (personDateTimePicker.Value.Date.ToShortDateString() != Convert.ToDateTime(Convert.ToString(personData.DateOfBirth)).ToShortDateString()) return true;
            if ((Convert.ToByte(personData.Gender) == 1 && maleRadioButton.Checked)) return true;
            if ((Convert.ToByte(personData.Gender) == 0 && femaleRadioButton.Checked)) return true;
            if (addressTxtBox.Text != Convert.ToString(personData.Address)) return true;
            if (phoneTxtBox.Text != Convert.ToString(personData.Phone)) return true;
            if (emailTxtBox.Text != (Convert.ToString(personData.Email) ?? "")) return true;
            if (countryComboBox.SelectedIndex != Convert.ToInt16(personData.NationaltityCountryID)) return true;
            if (current_image_name != db_image_name) return true;
            else return false;

        }

        private string get_image_path()
        {
            return (removeImageBtn.Visible) ? userPicture.ImageLocation : null;
        }

        public DVLDShared.stPerson save_data_to_struct()
        {
            DVLDShared.stPerson person = new DVLDShared.stPerson();
            person.personID = Convert.ToInt32(personID);
            person.NationalNo = Convert.ToString(nationalNoTxtBox.Text);
            person.FirstName = Convert.ToString(firstNameTxtBox.Text);
            person.SecondName = Convert.ToString(secondNameTxtBox.Text);
            person.ThirdName = Convert.ToString(thirdNameTxtBox.Text) ?? "";
            person.LastName = Convert.ToString(lastNameTxtBox.Text);
            person.DateOfBirth = Convert.ToDateTime(personDateTimePicker.Value);
            person.Gender = (maleRadioButton.Checked ? 0 : 1);
            person.Email = Convert.ToString(emailTxtBox.Text) ?? "";
            person.Address = Convert.ToString(addressTxtBox.Text);
            person.Phone = Convert.ToString(phoneTxtBox.Text);
            person.NationaltityCountryID = Convert.ToInt16(countryComboBox.SelectedIndex);
            person.ImagePath = get_image_path();
            
            return person;

        }
       
        public void load_person_data(int personID)
        {
            editmode = true;
            countryComboBox.DataSource = DVLDShared.countries;
            this.personID = personID;
            if(personID != -1)
            {
                personData = DVLD_BL.People.get_person_data_for_edit(personID);
                HeaderLabel.Text = "Update Person";
                personGroupBox.Text = $"Person ID : {personID}";
                firstNameTxtBox.Text = Convert.ToString(personData.FirstName);
                secondNameTxtBox.Text = Convert.ToString(personData.SecondName) ;
                thirdNameTxtBox.Text = Convert.ToString(personData.ThirdName) ;
                lastNameTxtBox.Text = Convert.ToString(personData.LastName);
                nationalNoTxtBox.Text = Convert.ToString(personData.NationalNo);
                personDateTimePicker.Value = Convert.ToDateTime(personData.DateOfBirth);

                if (Convert.ToByte(personData.Gender) == 0)
                    maleRadioButton.Checked = true;
                else
                    femaleRadioButton.Checked = true;

                addressTxtBox.Text =Convert.ToString(personData.Address);
                phoneTxtBox.Text = Convert.ToString(personData.Phone);
                emailTxtBox.Text = Convert.ToString(personData.Email);
                countryComboBox.SelectedIndex = Convert.ToInt16(personData.NationaltityCountryID);

                if (personData.ImagePath != null)
                {
                    if (File.Exists(personData.ImagePath.ToString()))
                    {
                        userPicture.ImageLocation = personData.ImagePath.ToString();
                        removeImageBtn.Visible = true;
                        setImageBtn.Text = "Change Image";
                        PersonalImage = true;
                    }
                    else
                    {
                        if (maleRadioButton.Checked) userPicture.Image = Properties.Resources.defaultuser;
                        else userPicture.Image = Properties.Resources.female;
                    }
                }
                else
                {
                    if (maleRadioButton.Checked) userPicture.Image = Properties.Resources.defaultuser;
                    else userPicture.Image = Properties.Resources.female;
                }

            }
            else
            {
                MessageBox.Show("Error Loading Person Data", "Error");
                this.ParentForm.Close();
            }
        }
 
        private void AddEditUserControl_Load(object sender, EventArgs e)
        {
            personDateTimePicker.MinDate = DateTime.Now.AddYears(-100);//leastDate
            personDateTimePicker.MaxDate = DateTime.Now.AddYears(-18);
            if (!editmode)
            {
                countryComboBox.DataSource = DVLDShared.countries;
                countryComboBox.Text = "Egypt";
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                MessageBox.Show("Close and open again for a new action", "Changes already made", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ParentForm.Close();
                return;
            }
            foreach (Control ctrl in personGroupBox.Controls)
            {
                if (!string.IsNullOrEmpty(errorProvider.GetError(ctrl)))
                {
                    MessageBox.Show("Error, Please Fix the red Errors!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!editmode)
            {
                int id = DVLD_BL.People.add_new_person(save_data_to_struct());
                if (id != -1)//check if there errors or not
                {
                    MessageBox.Show("New Person Added Successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form frm = Application.OpenForms["PeopleForm"];
                    if (frm != null)
                        ((PeopleForm)frm).refersh_all();
                    personGroupBox.Text = $"Person ID : {id}";
                    saved = true;
                }
                else
                {
                    MessageBox.Show("Error, Required Feild is Empty or in wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    saved = false;
                }
            }
            else
            {
                if (!change_happend())
                {
                    MessageBox.Show("No change to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DVLD_BL.People.update_new_person(save_data_to_struct()))
                {
                    MessageBox.Show("Person Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form frm = Application.OpenForms["PeopleForm"];
                    if (frm != null)
                        ((PeopleForm)frm).refersh_all();
                    saved = true;
                }
                else
                {
                    MessageBox.Show("Error, Required Feild is Empty or in wrong format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    saved = false;
                }
            }
        }

        private void NameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void phoneTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void nationalNoTxtBox_Leave(object sender, EventArgs e)
        {
            if (editmode)
            {
                if (DVLD_BL.People.is_unique_nationalNo_but_personal(nationalNoTxtBox.Text, personID))
                    errorProvider.SetError(nationalNoTxtBox, "There is a Person with this National Number.");
                else errorProvider.Clear();
            }
            else
            {
                if (DVLD_BL.People.is_unique_naitonalNo(nationalNoTxtBox.Text))
                    errorProvider.SetError(nationalNoTxtBox, "There is a Person with this National Number.");
                else errorProvider.Clear();
            }
        }

        private void emailTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        private void emailTxtBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(emailTxtBox.Text))
            {
                if (emailTxtBox.Text.Contains("@") && emailTxtBox.Text.Contains(".") &&
                    (emailTxtBox.Text.IndexOf("@") > 0 && emailTxtBox.Text.LastIndexOf(".") > emailTxtBox.Text.IndexOf("@")))
                    errorProvider.Clear();
                else
                {
                    errorProvider.SetError(emailTxtBox, "Invalid Email Format");
                }
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(!PersonalImage)
            userPicture.Image = Properties.Resources.defaultuser;
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(!PersonalImage) 
                userPicture.Image = Properties.Resources.female;
        }

        private string copy_image_to_app_data(string orginal_image_path)
        {
            try
            {
                //get app data folder path
                string localappdataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                string imagesFolder = Path.Combine(localappdataPath, "DVLD_Images");// create your folder path

                if (!Directory.Exists(imagesFolder))
                    Directory.CreateDirectory(imagesFolder);//create floder if not exists in that path

                string newfilename = Guid.NewGuid().ToString() + Path.GetExtension(orginal_image_path); //creataes file name

                string app_image_path = Path.Combine(imagesFolder, newfilename);//creates new image address

                File.Copy(orginal_image_path, app_image_path, true);//copy the orginal photo to it

                return app_image_path;

            }
            catch
            {
                return "";
            }
        }

        private void remove_image_form_app_data(string image_path)
        {
            if (string.IsNullOrEmpty(image_path)) return;

            try
            {
                if(File.Exists(image_path))
                {
                    if(userPicture.ImageLocation == image_path)
                    {
                        userPicture.ImageLocation = null;
                        userPicture.Image = (maleRadioButton.Checked) ?
                            Properties.Resources.defaultuser : userPicture.Image = Properties.Resources.female;
                    }
                    File.Delete(image_path);
                }
            }
            catch
            {
                throw;
            }
        }

        private void setImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                userPicture.ImageLocation =  copy_image_to_app_data(dlg.FileName);
                removeImageBtn.Visible = true;
                setImageBtn.Text = "Change Image";
                PersonalImage = true;
            }

        }

        private void removeImageBtn_Click(object sender, EventArgs e)
        {
            remove_image_form_app_data(get_image_path());
            userPicture.Image = (maleRadioButton.Checked) ? Properties.Resources.defaultuser : Properties.Resources.female;
            removeImageBtn.Visible = false;
            setImageBtn.Text = "Set Image";
            PersonalImage = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                if (MessageBox.Show("Nothing Saved, Are you Sure to Close?", "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes) this.ParentForm.Close();
            }
            else 
            this.ParentForm.Close();
        }
    }
     
}
