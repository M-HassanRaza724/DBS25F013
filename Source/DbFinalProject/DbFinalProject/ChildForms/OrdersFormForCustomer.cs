using DbFinalProject.DialogBoxForms;
using DbFinalProject.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbFinalProject.BL;

namespace DbFinalProject.ChildForms
{
    public partial class OrdersFormForCustomer : Form
    {
        public OrdersFormForCustomer()
        {
            InitializeComponent();
            dgvCustomerOrders.DataSource = OrderOfCustomerDGV.GetOrdersOfCustomer((Customer)Program.currentUser);
        }


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            OrderPlaceDialog placeOrderDialog = new OrderPlaceDialog();
            placeOrderDialog.Show();
        }


        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            OrderDL.LoadAllOrders();
            OrderCancelDialog cancelOrderDialog = new OrderCancelDialog();
            cancelOrderDialog.Show();
        }

        private void tlpMenuStrip_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
