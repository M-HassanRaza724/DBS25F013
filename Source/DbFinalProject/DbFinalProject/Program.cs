using DbFinalProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbFinalProject.BL;

namespace DbFinalProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static User currentUser;


        [STAThread]
        static void Main()
        {
            try
            {
                LookupDL.LoadAllLookups();
                UserDL.LoadAllUsers();
                ServiceDL.LoadAllServices();
                CustomerDGV_DL.LoadCustomers();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginSingUpForm());
        }
    }
}
