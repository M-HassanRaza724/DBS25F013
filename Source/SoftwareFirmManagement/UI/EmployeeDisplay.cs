using SoftwareFirmManagement.BL;
using System;
using System.Windows.Forms;

namespace SoftwareFirmManagement.UI
{


    public partial class EmployeeDisplay : UserControl
    {
        public bool Assigned { get { return cbtn_assign.Checked; } set{ cbtn_assign.Checked = value; } }
        public bool AssignButton { get { return cbtn_assign.Visible; } set { cbtn_assign.Visible = value; } }
        Employee employee = new Employee();
        Employee demoEmployee = new Employee()
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
                employee = value == null ? demoEmployee : value;
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
        public EventHandler AssignChanged;
        private void cbtn_assign_CheckedChanged(object sender, System.EventArgs e)
        {
            if(cbtn_assign.Checked)
            {
                cbtn_assign.Text = "Assigned";
            }
            else
            {
                cbtn_assign.Text = "Assign";
            }
            AssignChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
