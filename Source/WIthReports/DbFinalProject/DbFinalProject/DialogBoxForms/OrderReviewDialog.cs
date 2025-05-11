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

namespace DbFinalProject.DialogBoxForms
{
    public partial class OrderReviewDialog : Form
    {
        public OrderReviewDialog()
        {
            InitializeComponent();
            foreach (var order in Order.GetOrdersOfCurrentCustomer())
            {
                cbOrderId.Items.Add(order.OrderId);
            }
        }


        private void btnUpdateReview_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbOrderId.SelectedItem == null)
                {
                    MessageBox.Show("Please select an order ID.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbStars.SelectedItem == null || tbDescription.Text == "")
                {
                    MessageBox.Show("Please enter input for all fields.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int orderId = int.Parse(cbOrderId.SelectedItem.ToString());
                Order order = Order.GetOrderFromOrderId(orderId);
                int stars = int.Parse(cbStars.SelectedItem.ToString());
                string description = tbDescription.Text;
                order.UpdateReview(stars, description);
                MessageBox.Show("Order review updated successfully.", "Review Stored", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
