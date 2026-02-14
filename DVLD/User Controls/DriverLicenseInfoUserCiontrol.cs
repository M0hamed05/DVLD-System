using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.IO;
using System.Windows.Forms;
namespace DVLD.User_Controls
{
    public partial class DriverLicenseInfoUserCiontrol : UserControl
    {
        DVLDShared.stLicense license = new DVLDShared.stLicense();
        public DriverLicenseInfoUserCiontrol()
        {
            InitializeComponent();
        }

        private void DriverLicenseInfoUserCiontrol_Load(object sender, EventArgs e)
        {

        }

        public void load_data(int licenseID)
        {
            license = DVLD_BL.Licenses.get_licenseInfo(licenseID);
            DVLDShared.stPerson person = DVLD_BL.People.get_person_data_for_edit(DVLD_BL.Drivers.get_personID_FromDriverID(license.driverID));

            classTxtBox.Text = DVLD_BL.Licenses.get_licenseClassName(license.licenseClassID);
            NameTxtBox.Text = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}";
            NationaNoTxtBox.Text = person.NationalNo;
            LicenseIDTxtBox.Text = licenseID.ToString();
            GenderTxtBox.Text = person.Gender == 0 ? "Male" : "Female";
            IssueDateTxtBox.Text = license.issueDate.ToShortDateString();
            IssueReasonTxtBox.Text = get_issueReason(license.issueReason);
            NotesTxtBox.Text = license.Notes;
            IsActiveTxtBox.Text = license.isActive ? "Yes" : "No";
            DateOfBirthTxtBox.Text = person.DateOfBirth.ToShortDateString();
            DriverIDTxtBox.Text = license.driverID.ToString();
            ExpirationDateTxtBox.Text = license.ExpirationDate.ToShortDateString();
            IsDetainedTxtBox.Text = "No";//needs refersh

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

        public void load_data_by_aaplicationID(int AppID)
        {
            license = DVLD_BL.Licenses.get_licenseInfo_By_AppID(AppID);
            DVLDShared.stPerson person = DVLD_BL.People.get_person_data_for_edit(DVLD_BL.Drivers.get_personID_FromDriverID(license.driverID));
            classTxtBox.Text = DVLD_BL.Licenses.get_licenseClassName(license.licenseClassID);
            NameTxtBox.Text = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}";
            NationaNoTxtBox.Text = person.NationalNo;
            LicenseIDTxtBox.Text = license.LicenseID.ToString();
            GenderTxtBox.Text = person.Gender == 0 ? "Male" : "Female";
            IssueDateTxtBox.Text = license.issueDate.ToShortDateString();
            IssueReasonTxtBox.Text = get_issueReason(license.issueReason);
            NotesTxtBox.Text = license.Notes;
            IsActiveTxtBox.Text = license.isActive ? "Yes" : "No";
            DateOfBirthTxtBox.Text = person.DateOfBirth.ToShortDateString();
            DriverIDTxtBox.Text = license.driverID.ToString();
            ExpirationDateTxtBox.Text = license.ExpirationDate.ToShortDateString();
            IsDetainedTxtBox.Text = "No";//needs refersh

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

        private string get_issueReason(int issueReason)
        {
            if (issueReason == (int)DVLDShared.enIssueReason.FirstTime) return "First Time";
            if (issueReason == (int)DVLDShared.enIssueReason.RenewLicense) return "Renew License";
            if (issueReason == (int)DVLDShared.enIssueReason.DamagedLicense) return "Replcament For Damaged License";
            if (issueReason == (int)DVLDShared.enIssueReason.LostLicense) return "Replcament For Lost License";
            return "Don't Know yet";
        }

        public int get_license_id()
        {
            if(license.LicenseID != 0)
            return Convert.ToInt32(LicenseIDTxtBox.Text.ToString());
            else
            {
                return -1;
            }
        }
        public int get_driverID() => license.driverID;
        public int getlicenseClass_id() => license.licenseClassID;
        public bool IsActive() => license.isActive;
        public DateTime get_expiration_date() => license.ExpirationDate;
        public string get_notes() => Convert.ToString(NotesTxtBox.Text);

        public void set_not_active()
        {
            IsActiveTxtBox.Text = "No";
        }

    }
}
