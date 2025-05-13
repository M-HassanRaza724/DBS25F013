using SoftwareFirmManagement.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareFirmManagement.UI
{
    public partial class AdminDashboard: Form
    {
        MainForm parentForm;

        public MainForm ParentForm {  get { return parentForm; } set { parentForm = value; } }
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            Admin cust = (Admin)Program.CurrentUser;
            lbl_name_text.Text = cust.Name;
            lbl_email_text.Text = cust.Email;
        }

        private void btn_customer_management_Click(object sender, EventArgs e)
        {
            ParentForm.ShowCustomerManagement();
        }

        private void btn_employee_management_Click(object sender, EventArgs e)
        {
            ParentForm.ShowEmployeeManagement();    
        }

        private void btn_admin_management_Click(object sender, EventArgs e)
        {
            ParentForm.ShowAdminManagement();
        }

        private void lbl_title_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
