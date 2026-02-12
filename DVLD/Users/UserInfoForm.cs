using DVLD_Shared;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class UserInfoForm : Form
    {
        int personID = -1;
        int userID = -1;
        public UserInfoForm(int perosnID,int userID)
        {
            this.personID = perosnID;
            this.userID = userID;
            InitializeComponent();
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            userInfoUserControl1.load_all_data(personID,userID);

        }
        
    }
}
