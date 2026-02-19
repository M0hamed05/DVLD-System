using DVLDBussinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DVLD
{
    public partial class PeersonInfoWithFilterUserControl : UserControl
    {
        public PeersonInfoWithFilterUserControl()
        {
            InitializeComponent();
        }

        private List<string> all_nationlityIDs = new List<string>();
        private List<int> all_personIDs = new List<int>();
        bool addSelected = false;

        private void PeersonInfoWithFilterUserControl_Load(object sender, EventArgs e)
        {
            filterComboBox.Items.Add("NationalNo");
            filterComboBox.Items.Add("PersonID");
            filterComboBox.SelectedIndex = 0;

            all_nationlityIDs = DVLD_BL.People.get_all_nationlityID();
            all_personIDs = DVLD_BL.People.get_all_personID();
            allUsersComboBox.DataSource = all_nationlityIDs;

        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            AddEditPersonForm frm = new AddEditPersonForm();
            frm.ShowDialog();
            if (frm.is_saved())
            {
                all_nationlityIDs = DVLD_BL.People.get_all_nationlityID_for_user_adding();
                allUsersComboBox.DataSource = all_nationlityIDs;
                all_personIDs = DVLD_BL.People.get_all_personID();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (filterComboBox.SelectedIndex == 0)
            {
                int personID = DVLD_BL.People.get_personID_by_NationaltyNO(allUsersComboBox.Text.ToString());
                if (personID != -1)
                    personInfoUserControl1.load_person_data(personID);               
            }
            else
            {
                personInfoUserControl1.load_person_data(Convert.ToInt32(allUsersComboBox.SelectedValue.ToString()));

            }
            addSelected = true;
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterComboBox.SelectedIndex == 0)
            {
                allUsersComboBox.DataSource = all_nationlityIDs;
            }
            else
            {
                allUsersComboBox.DataSource = all_personIDs;
            }
        }

        public int get_personID()
        {
            if (filterComboBox.SelectedIndex == 0)
            {
                int personID = DVLD_BL.People.get_personID_by_NationaltyNO(allUsersComboBox.Text.ToString());
                return personID;
            }
            else
            {
                return Convert.ToInt32(allUsersComboBox.Text);
            }
        }

        public string get_nationalityNo()
        {
            return Convert.ToString(personInfoUserControl1.get_nationalityNo());
        }

        public bool is_add_selected()
        {
          return addSelected;
        }

        public void preform_add_click()
        {
            addBtn.PerformClick();
            addSelected = false;
        }
    }
}
