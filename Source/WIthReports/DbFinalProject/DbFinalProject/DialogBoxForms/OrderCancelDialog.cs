using DbFinalProject.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFinalProject.DialogBoxForms
{
    public partial class OrderCancelDialog : Form
    {
        public OrderCancelDialog()
        {
            InitializeComponent();
            foreach (int orderId in Order.GetOrderIdsNotCompleted())
            {
                cbOrderId.Items.Add(orderId);
            }
        }


        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbOrderId.SelectedItem == null)
                {
                    MessageBox.Show("Please select an order ID.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int orderId = int.Parse(cbOrderId.SelectedItem.ToString());
                Order orderToCancel = Order.GetOrderFromOrderId(orderId);
                orderToCancel.Cancel();
                MessageBox.Show("Order cancelled successfully.", "Cancellation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
