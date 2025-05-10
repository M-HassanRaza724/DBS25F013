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
using DbFinalProject.ReportForms;

namespace DbFinalProject.DialogBoxForms
{
    public partial class OrderPayDialog : Form
    {
        private MainForm mainForm;

        public OrderPayDialog(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            Customer customer = (Customer)Program.currentUser;
            foreach (var id in Order.GetOrderIdsNotPaid(customer))
            {
                cbOrderId.Items.Add(id);
            }
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbOrderId.SelectedItem == null)
                {
                    MessageBox.Show("Please select an order ID.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int orderId = int.Parse(cbOrderId.SelectedItem.ToString());
                Order orderToPay = Order.GetOrderFromOrderId(orderId);
                orderToPay.Pay();
                MessageBox.Show("Order payment successful.", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                mainForm.LoadChildForm(new InvoiceReportForm());
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
