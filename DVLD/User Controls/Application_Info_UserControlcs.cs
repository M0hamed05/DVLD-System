using DVLD.Applications;
using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.User_Controls
{
    public partial class Application_Info_UserControl : UserControl
    {
        DVLDShared.stPerson person;
        DVLDShared.stUser user;
        public Application_Info_UserControl()
        {
            InitializeComponent();
        }

        private void Application_Info_UserControl_Load(object sender, EventArgs e)
        {

        }

        public void load_data(int LDLA_ID, string licenseClass, byte passedTests,bool isThereLicense = false)
        {
            int applicationID = DVLD_BL.Applications.get_applicationID_by_LDLA(LDLA_ID);
            DVLDShared.stApplication application = DVLD_BL.Applications.get_application_basic_info(applicationID);
            person = DVLD_BL.People.get_person_data_for_edit(application.ApplicationPersonID);
            user = DVLD_BL.Users.get_user_data(application.UserID);

            applicationIDtxtBox.Text = applicationID.ToString();
            statusTxtBox.Text = ((DVLDShared.enApplicationStatus)application.ApplicationStatus).ToString();
            FessTxtBox.Text = application.PaidFees.ToString();
            typeTxtBox.Text = DVLD_BL.Applications.get_application_Type_Info(application.ApplicationTypeID).ApplicationTitle;
            applicantTxtBox.Text = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}";
            DateTxtBox.Text = application.ApplicationDate.ToShortDateString();
            startDateTxtBox.Text = application.LastStatusDate.ToShortDateString();
            userTxtBox.Text = user.username;
            LDLA_IDtxtBox.Text = LDLA_ID.ToString();
            appliedForLicenseTxtBox.Text = licenseClass;
            passedTxtBox.Text = $"{passedTests.ToString()}/3";

            ShowLicenseBtn.Enabled = isThereLicense;

        }

        private void applicantLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonDetailsForm frm = new PersonDetailsForm(person.personID);
            frm.ShowDialog();

        }

        public string get_applicant_name() => applicantTxtBox.Text;
        public int get_user_ID() => user.userID;
        public int get_applicantion_ID() => Convert.ToInt32(applicationIDtxtBox.Text);
        public int get_LDLA_ID() => Convert.ToInt32(LDLA_IDtxtBox.Text);
        public string get_licenseClass() => appliedForLicenseTxtBox.Text;
        public decimal get_applicationFees() => Convert.ToDecimal(FessTxtBox.Text);

        private void ShowLicenseBtn_Click(object sender, EventArgs e)
        {
            ShowLicenseInfo frm = new ShowLicenseInfo(Convert.ToInt32(applicationIDtxtBox.Text));
            frm.ShowDialog();
        }
    }
}
