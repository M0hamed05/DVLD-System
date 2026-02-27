using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.SavedID != 0 && DVLD_BL.People.is_person_found(Properties.Settings.Default.SavedID))
            {
                Application.Run(new MainForm(Properties.Settings.Default.SavedID));
            }
            else
            {
                Application.Run(new loginForm());
            }
        }
    }
}
