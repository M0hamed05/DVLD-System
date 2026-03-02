using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class AddEditPersonForm : Form
    {
        public AddEditPersonForm()
        {
            InitializeComponent();
        }

        public AddEditPersonForm(int personID)
        {
            InitializeComponent();
            addEditUserControl1.load_person_data(personID);
            this.Text = "Edit Person";
        }

        private void AddPersonForm_Load(object sender, EventArgs e)
        {
            //point 5 = apply accept and cancel button
            this.AcceptButton = addEditUserControl1.SaveButton;
        }

        private void AddEditPersonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        
        public bool is_saved()
        {
            return addEditUserControl1.saved;
        }

        private void AddEditPersonForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                addEditUserControl1.CloseButton.PerformClick();
            }
        }
    }
}
