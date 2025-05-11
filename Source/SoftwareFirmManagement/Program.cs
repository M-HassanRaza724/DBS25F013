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
        //new User(0,"Anonymous","","","Customer");
        static User user = Customer.defaultCustomer;
        [STAThread]
        static void Main()
        {
            //MessageBox.Show($"{new Customer(-1, "username", "email", "passs", -1, -1, "Name")}");
            LookupDL.LoadAllLookups();
            
            UserDL.LoadAllUsers();
            ServiceDL.LoadAllServices();
            OrderDL.GetAllOrdersFromDatabase();
            SalaryDL.LoadAllSalaries();
            ReviewDL.LoadAllReviews();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
