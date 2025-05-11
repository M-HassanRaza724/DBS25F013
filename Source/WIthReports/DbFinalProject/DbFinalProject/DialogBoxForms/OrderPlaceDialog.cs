using DbFinalProject.BL;
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

namespace DbFinalProject.DialogBoxForms
{
    public partial class OrderPlaceDialog : Form
    {
        public OrderPlaceDialog()
        {
            InitializeComponent();
            foreach (var name in Service.GetServiceNames())
            {
                cbService.Items.Add(name);
            }
            dtmDueDate.MinDate = DateTime.Now.Date.AddDays(1); // min date is one day ahead of the current day
        }


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbService.SelectedItem == null)
                {
                    MessageBox.Show("Please select a service.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string serviceName = cbService.SelectedItem.ToString();
                Service service = Service.GetServiceFromName(serviceName);
                DateTime dueDate = dtmDueDate.Value.Date;
                Employee employee = Employee.RandomlySelectAnEmployee();
                int price = 10000;
                int userId = Program.currentUser.UserId;
                //int userId = UserDL.allUsers.Where(u => u.Username == "dora123").Select(u => u.UserId).FirstOrDefault();
                Order order = new Order(employee.EmployeeId, userId, DateTime.Now, 12, service.ServiceId);
                order.Place(price, dueDate);
                MessageBox.Show("Order placed successfully.", "Successfully Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
