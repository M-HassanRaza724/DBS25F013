using ComponentFactory.Krypton.Toolkit;
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
    public partial class OrderDetails: KryptonForm
    {
        public OrderDetails(OrderDTO order, Customer customer,Employee employee)
        {
            InitializeComponent();
            orderDisplay.OrderDetails = order;
            customerDisplay.Customer = customer;
            employeeDisplay.Employee = employee;
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
