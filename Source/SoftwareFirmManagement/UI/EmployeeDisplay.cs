using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;

namespace SoftwareFirmManagement.UI
{
  
    public partial class EmployeeDisplay: UserControl
    {
        Employee employee = new Employee()
        {
            Name = "Employee",
            Email = "employee@gmail.com",
            Designation = "Software Engineer",
            Phone = "03000000000",
            Username = "employee12",
        };
        public EmployeeDisplay()
        {
            InitializeComponent();
        }

        public Employee Employee
        {
            get { return employee; }
            set
            {
                employee = value;
                lbl_full_name_text.Text = employee.Name;
                lbl_email_text.Text = employee.Email;
                lbl_designation_text.Text = employee.Designation;
                lbl_phone_text.Text = employee.Phone;
                lbl_username_text.Text = employee.Username;
            }
        }


        private void gbx_customer_details_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
