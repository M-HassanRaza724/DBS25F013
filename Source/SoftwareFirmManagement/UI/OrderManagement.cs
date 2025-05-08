using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftwareFirmManagement.BL;
using System.Runtime.CompilerServices;
using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement.UI
{
    public partial class OrderManagement : KryptonForm
    {
        string sortby = null, direction = null;
        DataGridViewRow currentContextRow = null;
        public OrderManagement()
        {
            InitializeComponent();
        }
        public void LoadData(string search = null)
        {
            if (search == "Search")
                search = null;
            OrderBindingSource.DataSource = OrderDTO.GetOrdersByFilter(search, sortby, direction);
            dgv_orders.DataSource = OrderBindingSource;
        }
        private void OrderManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            loadPlatforms();
            loadServices();
        }
        private void loadPlatforms()
        {
            try
            {
                cmbPlatform.Items.Clear();
                foreach (Lookup p in LookupDL.GetLookupsByKeyGroup("platform"))
                {
                    cmbPlatform.Items.Add(p.Value);
                }
                if (cmbPlatform.Items.Count > 0)
                    cmbPlatform.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadServices()
        {
            try
            {
                cmbService.Items.Clear();
                foreach (ServiceDTO s in ServiceDL.allServices)
                {
                    cmbService.Items.Add(s.Name);
                }
                if (cmbService.Items.Count > 0)
                    cmbService.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CustomerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortby != "customer") sortby = "customer";
            else sortby = null;
            LoadData();
        }
        private void ServiceNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortby != "service") sortby = "service";
            else sortby = null;
            LoadData();
        }
        private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (direction != "ASC") direction = "ASC";
            else direction = null;
            LoadData();
        }
        private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (direction != "DESC") direction = "DESC";
            else direction = null;
            LoadData();
        }
        private void dgv_orders_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                currentContextRow = dgv_orders.Rows[e.RowIndex];
                dgv_orders.ClearSelection();
                currentContextRow.Selected = true;
                contextMenuStrip_grd.Show(dgv_orders, dgv_orders.PointToClient(Cursor.Position));
            }
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableGroupBox(Convert.ToInt32(currentContextRow.Cells["OrderId"].Value));
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(currentContextRow.Cells["OrderId"].Value);
            OrderDTO order = new OrderDTO();
            order.OrderId = orderId;

            if (DialogResult.Yes == MessageBox.Show($"Are you sure you want to delete this order?", "Warning", MessageBoxButtons.YesNo))
                OrderDTO.DeleteOrder(order);
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            disableGroupBox();
        }
        private void btn_create_order_Click(object sender, EventArgs e)
        {
            enableGroupBox();
        }

        void enableGroupBox(int orderId = -1)
        {
            gbx_add_update_order.Enabled = true;
            gbx_add_update_order.Visible = true;

            if (orderId != -1)
            {
                txt_customer_name.TextBoxText = currentContextRow.Cells["Customer"].Value.ToString();
                txtInitialBudget.TextBoxText = currentContextRow.Cells["InitialBudget"].Value.ToString();
                txtDescription.TextBoxText = currentContextRow.Cells["Description"].Value.ToString();

                string serviceName = currentContextRow.Cells["Service"].Value.ToString();
                int serviceIndex = -1;
                for (int i = 0; i < ServiceDL.allServices.Count; i++)
                {
                    if (ServiceDL.allServices[i].Name == serviceName)
                    {
                        serviceIndex = i;
                        break;
                    }
                }
                if (serviceIndex >= 0)
                    cmbService.SelectedIndex = serviceIndex;

                string platformName = currentContextRow.Cells["Platform"].Value.ToString();
                int platformIndex = -1;
                for (int i = 0; i < cmbPlatform.Items.Count; i++)
                {
                    if (cmbPlatform.Items[i].ToString() == platformName)
                    {
                        platformIndex = i;
                        break;
                    }
                }
                if (platformIndex >= 0)
                    cmbPlatform.SelectedIndex = platformIndex;

                btn_add_update_order.Values.Text = "Update";
                gbx_add_update_order.Values.Heading = "Update Order";
            }
            else
            {
                txt_customer_name.TextBoxText = "";
                txtInitialBudget.TextBoxText = "";
                txtDescription.TextBoxText = "";
                cmbService.SelectedIndex = 0;
                cmbPlatform.SelectedIndex = 0;

                btn_add_update_order.Values.Text = "Create";
                gbx_add_update_order.Values.Heading = "Create Order";
            }
        }

        void disableGroupBox()
        {
            gbx_add_update_order.Enabled = false;
            gbx_add_update_order.Visible = false;
            txt_customer_name.TextBoxText = "";
            txtInitialBudget.TextBoxText = "";
            txtDescription.TextBoxText = "";
            cmbService.SelectedIndex = 0;
            cmbPlatform.SelectedIndex = 0;
            btn_add_update_order.Values.Text = "Create";
            gbx_add_update_order.Values.Heading = "Create Order";
        }

        private void btn_add_update_order_Click(object sender, EventArgs e)
        {
            if (btn_add_update_order.Values.Text == "Update")
            {
                try
                {
                    int orderId = Convert.ToInt32(currentContextRow.Cells["OrderId"].Value);
                    int customerId = Convert.ToInt32(currentContextRow.Cells["CustomerId"].Value);
                    Customer customer = new Customer();
                    customer.CustomerId = customerId;

                    int employeeId = Convert.ToInt32(currentContextRow.Cells["EmployeeId"].Value);
                    Employee employee = new Employee();
                    employee.EmployeeId = employeeId;

                    int statusId = LookupDL.GetLookupId("status", currentContextRow.Cells["Status"].Value.ToString());
                    //int orderId, Employee employee, OrderDTO customer, DateTime createdAt, int statusId,
                    //   ServiceDTO service, int initialBudgetId, int platformId, string description)
                    OrderDTO order = new OrderDTO(
                        orderId,
                        employee,
                        customer,
                        Convert.ToDateTime(currentContextRow.Cells["CreatedAt"].Value),
                        statusId,
                        ServiceDL.allServices[cmbService.SelectedIndex],
                        LookupDL.GetLookupId("budget_type", txtInitialBudget.TextBoxText),
                        LookupDL.GetLookupId("platform", cmbPlatform.Text),
                        txtDescription.TextBoxText
                    );
                    OrderDTO.UpdateOrder(order);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    int employeeId = 1; 
                    Employee employee = new Employee();
                    employee.EmployeeId = employeeId;

                    string customerName = txt_customer_name.TextBoxText;
                    Customer customer = null;
                    foreach (Customer c in CustomerDL.GetAllCustomers())
                    {
                        if (c.Name == customerName)
                        {
                            customer = c;
                            break;
                        }
                    }
                    if (customer == null)
                    {
                        MessageBox.Show("Customer not found");
                        return;
                    }

                    int statusId = LookupDL.GetLookupId("status", "Pending");

                    OrderDTO order = new OrderDTO(
                        employee,
                        customer,
                        statusId,
                        ServiceDL.allServices[cmbService.SelectedIndex],
                        LookupDL.GetLookupId("budget_type", txtInitialBudget.TextBoxText),
                        LookupDL.GetLookupId("platform", cmbPlatform.Text),
                        txtDescription.TextBoxText
                    );
                    OrderDTO.AddOrder(order);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            LoadData();
            disableGroupBox();
        }
    }
}