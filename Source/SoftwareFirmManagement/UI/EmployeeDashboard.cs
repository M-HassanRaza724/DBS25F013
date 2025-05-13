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
    public partial class EmployeeDashboard: Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            Employee cust = (Employee)Program.CurrentUser;
            lbl_name_text.Text = cust.Name;
            lbl_email_text.Text = cust.Email;

            List<string> statuses = new List<string>
            {
                "Pending",
            };
            orderDTOBindingSource.DataSource = OrderDTO.GetOrdersByFilter(statuses, null, null, "ASC", -1, cust.EmployeeId);
            dgv_pending_orders.DataSource = orderDTOBindingSource.DataSource;

            List<string> statuses2 = new List<string>
            {
                "Completed",
            };
            orderDTOBindingSource1.DataSource = OrderDTO.GetOrdersByFilter(statuses, null, null, "ASC", -1, cust.EmployeeId);
            dgv_completed_orders.DataSource = orderDTOBindingSource1.DataSource;
        }
    }
}
