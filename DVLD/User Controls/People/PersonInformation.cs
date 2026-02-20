using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class PersonInfoUserControl : UserControl
    {
        public PersonInfoUserControl()
        {
            InitializeComponent();
            if (this.DesignMode) return;
        }

        private int personID = -1;

        DVLDShared.clsPerson personData = new DVLDShared.clsPerson();

        public DVLDShared.clsPerson SelectedPersonInfo
        {
            get { return personData; }
        }

        public void load_person_data(int personID)
        {
            if (!DVLD_BL.People.is_person_found(personID))
            {
                MessageBox.Show($"Person was not found with id = {personID}", "Perosn not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ParentForm.Close();
                return;
            }

            List<string> countries = DVLDShared.countries;
            if (personID != -1)
            {
                this.personID = personID;
                personGroupBox.Text = $"Person ID : {personID}";
                personData = DVLD_BL.People.get_person_data_for_edit(personID);
                firstNameTxtBox.Text = Convert.ToString(personData.FirstName);
                secondNameTxtBox.Text = Convert.ToString(personData.SecondName);
                thirdNameTxtBox.Text = Convert.ToString(personData.ThirdName);
                lastNameTxtBox.Text = Convert.ToString(personData.LastName);
                nationalNoTxtBox.Text = Convert.ToString(personData.NationalNo);
                personDateTimePicker.Value = Convert.ToDateTime(personData.DateOfBirth);
                genderTxtBox.Text = (Convert.ToByte(personData.Gender) == 0) ? "Male" : "Female";

                addressTxtBox.Text = Convert.ToString(personData.Address);
                phoneTxtBox.Text = Convert.ToString(personData.Phone);
                emailTxtBox.Text = Convert.ToString(personData.Email);
                countryTxtBox.Text = countries[Convert.ToInt16(personData.NationaltityCountryID)];

                load_person_image();

            }
            else
            {
                MessageBox.Show("Error Loading Person Data", "Error");
                this.ParentForm.Close();
            }
        }

        private void load_person_image()
        {
            if (personData.ImagePath != null)
            {
                if (File.Exists(personData.ImagePath.ToString()))
                {
                    userPicture.ImageLocation = personData.ImagePath.ToString();
                }
                else
                    userPicture.Image = Convert.ToByte(personData.Gender) == 0 ? Properties.Resources.defaultuser :
                        userPicture.Image = Properties.Resources.female;

            }
            else
                userPicture.Image = Convert.ToByte(personData.Gender) == 0 ? Properties.Resources.defaultuser :
                    userPicture.Image = Properties.Resources.female;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (personID != -1)
            {
                AddEditPersonForm frm = new AddEditPersonForm(personID);
                frm.ShowDialog();
                if (frm.is_saved()) load_person_data(personID);
            }
        }

        public string get_nationalityNo() => Convert.ToString(nationalNoTxtBox.Text);

        public int get_personID() => personID;
    }
}
