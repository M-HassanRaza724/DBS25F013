using System;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;
using SoftwareFirmManagement.UI;

namespace SoftwareFirmManagement
{
    static class Program
    {
        private static User _currentUser = Customer.defaultCustomer;

        public static User CurrentUser
        {
            get => _currentUser;
            set => _currentUser = value;
        }

        [STAThread]
        static void Main()
        {
            LookupDL.LoadAllLookups();
            UserDL.LoadAllUsers();
            ServiceDL.LoadAllServices();
            OrderDL.GetAllOrdersFromDatabase();
            SalaryDL.LoadAllSalaries();
            ReviewDL.LoadAllReviews();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            MainForm main = new MainForm();
            //using (var loginForm = new LoginForm())
            //{
            //    if (loginForm.ShowDialog() == DialogResult.OK)
            //    {
                    Application.Run(main);
            //    }
            //}
        }
    }
}