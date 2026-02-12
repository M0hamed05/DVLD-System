using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void AddEditPersonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        
        public bool is_saved()
        {
            return addEditUserControl1.saved;
        }
    
    }
}
