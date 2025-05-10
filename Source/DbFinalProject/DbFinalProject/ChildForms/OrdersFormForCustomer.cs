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
        public MainForm parent;

        public OrdersFormForCustomer(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
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


        private void btnPayForOrder_Click(object sender, EventArgs e)
        {
            OrderPayDialog dialog = new OrderPayDialog(parent);
            dialog.Show();
        }


        private void btnReviewOrder_Click(object sender, EventArgs e)
        {
            OrderReviewDialog dialog = new OrderReviewDialog();
            dialog.Show();
        }
    }
}
