using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement.UI
{
    public partial class CustomerDashboard: Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Customer currentCust = (Customer)Program.CurrentUser;
            orderDTOBindingSource.DataSource = OrderDL.GetOrdersByCustomerId(currentCust.CustomerId);
            dgv_pending_orders.DataSource = orderDTOBindingSource.DataSource;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            Customer cust = (Customer)Program.CurrentUser;
            lbl_name_text.Text = cust.Name;
            lbl_email_text.Text = cust.Email;
        }
    }
}
