using DbFinalProject.BL;
using DbFinalProject.DL;
using MySql.Data.MySqlClient;
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
    public partial class CustomerDeleteDialog : Form
    {
        public CustomerDeleteDialog()
        {
            InitializeComponent();
            foreach (var username in Customer.GetCustomerUsernames())
            {
                cbUsername.Items.Add(username);
            }
        }
        

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (cbUsername.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer's username.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string username = cbUsername.SelectedItem.ToString();
                Customer.DeleteFromUsername(username);
                MessageBox.Show("Customer deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
