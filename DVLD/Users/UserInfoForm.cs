using DVLD_Shared;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class UserInfoForm : Form
    {
        int personID = -1;
        public UserInfoForm(int perosnID)
        {
            this.personID = perosnID;
            InitializeComponent();
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            userInfoUserControl1.load_all_data(personID);

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
