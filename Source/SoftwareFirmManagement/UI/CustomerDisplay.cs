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
    public partial class CustomerDisplay: UserControl
    {
        Customer customer = new Customer()
        {
            Name = "Customer",
            Email = "customer@gmail.com"
        };

        public CustomerDisplay()
        {
            InitializeComponent();
        }
        public Customer Customer
        {
            get { return customer; }
            set
            {
                customer = value;
                lbl_email_text.Text = customer.Email;
                lbl_full_name_text.Text = customer.Name;
                lbl_username_text.Text = customer.Username;
            }
        }

        private void gbx_customer_details_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
