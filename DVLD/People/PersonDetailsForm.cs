using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class PersonDetailsForm : Form
    {
        public PersonDetailsForm(int personID)
        {
            InitializeComponent();
            personInfoUserControl1.load_person_data(personID);
        }

        private void PersonDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
