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

        public void load_person_data(int personID)
        {
            if (this.DesignMode) return;

            DVLDShared.stPerson personData = new DVLDShared.stPerson();
            List <string> countries= DVLDShared.countries;
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

                if (Convert.ToByte(personData.Gender) == 0)
                    genderTxtBox.Text = "Male";
                else
                    genderTxtBox.Text = "Female";

                addressTxtBox.Text = Convert.ToString(personData.Address);
                phoneTxtBox.Text = Convert.ToString(personData.Phone);
                emailTxtBox.Text = Convert.ToString(personData.Email);
                countryTxtBox.Text = countries[Convert.ToInt16(personData.NationaltityCountryID)];

                if (personData.ImagePath != null)
                {
                    if (File.Exists(personData.ImagePath.ToString()))
                    {
                        userPicture.ImageLocation = personData.ImagePath.ToString();
                    }
                    else
                    {
                        if (Convert.ToByte(personData.Gender) == 0) userPicture.Image = Properties.Resources.defaultuser;
                        else userPicture.Image = Properties.Resources.female;
                    }
                }
                else
                {
                    if (Convert.ToByte(personData.Gender) == 0) userPicture.Image = Properties.Resources.defaultuser;
                    else userPicture.Image = Properties.Resources.female;
                }

            }
            else
            {
                MessageBox.Show("Error Loading Person Data", "Error");
                this.ParentForm.Close();
            }
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
