using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class UserInfoUserControl : UserControl
    {
        public UserInfoUserControl()
        {
            InitializeComponent();
        }

        private void UserInfoUserControl_Load(object sender, EventArgs e)
        {

        }

        public void load_all_data(int personID,int userID)
        {
            personInfoUserControl1.load_person_data(personID);
            DVLDShared.stUser user = DVLD_BL.Users.get_user_data(userID);
            userIDTxtBox.Text = user.userID.ToString();
            usernameTxtBox.Text = user.username.ToString();
            if (user.isActive == true)
                isActiveTxtBox.Text = "Yes";
            else isActiveTxtBox.Text = "No";
        }
    }
}
