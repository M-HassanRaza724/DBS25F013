using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.UI;
using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //static User user = new User(0,"Anonymous","","","Customer");
        [STAThread]
        static void Main()
        {
            LookupDL.LoadAllLookups();
            //UserDL.LoadAllUsers();
            ServiceDL.LoadAllServices();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
