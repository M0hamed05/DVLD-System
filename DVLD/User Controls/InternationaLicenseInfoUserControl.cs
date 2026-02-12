using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD.User_Controls
{
    public partial class InternationaLicenseInfoUserControl : UserControl
    {
        public InternationaLicenseInfoUserControl()
        {
            InitializeComponent();
        }

        private void InternationaLicenseInfoUserControl_Load(object sender, EventArgs e)
        {

        }

        public void load_data(int interationalLicenseID)
        {
            DVLDShared.stInternationalLicense license = DVLD_BL.Licenses.get_international_licenseInfo(interationalLicenseID);
            DVLDShared.stPerson person = DVLD_BL.People.get_person_data_for_edit(DVLD_BL.Drivers.get_personID_FromDriverID(license.driverID));

            NameTxtBox.Text = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}";
            NationaNoTxtBox.Text = person.NationalNo;
            LicenseIDTxtBox.Text = license.localLicenseID.ToString();
            InternationIDtxtBox.Text = interationalLicenseID.ToString();
            ApplicationIDTxtBox.Text =license.applicationID.ToString();
            GenderTxtBox.Text = person.Gender == 0 ? "Male" : "Female";
            IssueDateTxtBox.Text = license.issueDate.ToShortDateString();
            IsActiveTxtBox.Text = license.isActive ? "Yes" : "No";
            DateOfBirthTxtBox.Text = person.DateOfBirth.ToShortDateString();
            DriverIDTxtBox.Text = license.driverID.ToString();
            ExpirationDateTxtBox.Text = license.ExpirationDate.ToShortDateString();

            if (person.ImagePath != null)
            {
                if (File.Exists(person.ImagePath.ToString()))
                {
                    personPictureBox.ImageLocation = person.ImagePath.ToString();
                }
                else
                {
                    if (Convert.ToByte(person.Gender) == 0) personPictureBox.Image = Properties.Resources.defaultuser;
                    else personPictureBox.Image = Properties.Resources.female;
                }
            }
            else
            {
                if (Convert.ToByte(person.Gender) == 0) personPictureBox.Image = Properties.Resources.defaultuser;
                else personPictureBox.Image = Properties.Resources.female;
            }
        }
    }
}
