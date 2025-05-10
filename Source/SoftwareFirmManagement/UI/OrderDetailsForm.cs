using ComponentFactory.Krypton.Toolkit;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SoftwareFirmManagement.UI
{
    public partial class OrderDetailsForm : KryptonForm
    {
        OrderManagement parentForm;
        public OrderManagement ParentF { get { return parentForm; } set { parentForm = value; } }
        public OrderDetailsForm(OrderDTO order, Customer customer, Employee employee = null)
        {
            InitializeComponent();
            orderDisplay.OrderDetails = order;
            customerDisplay.Customer = customer;
            if (employee != null)
                employeeDisplay.Employee = employee;
            else
            {
                employeeDisplay.Employee = null;
                employeeDisplay.Visible = false;
                lbl_supervision.Visible = false;
            }

        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int change = e.NewValue - e.OldValue;
            if (change > 0)
            {
                pnl_main.Location = new Point(pnl_main.Location.X, pnl_main.Location.Y - e.NewValue);
            }
            else
            {
                pnl_main.Location = new Point(pnl_main.Location.X, pnl_main.Location.Y + e.NewValue);
            }
            if (e.NewValue == 0)
            {
                this.pnl_main.Location = new System.Drawing.Point(0, 0);

            }
            if (e.NewValue == 100)
            {
                this.pnl_main.Location = new System.Drawing.Point(0, -pnl_main.Height);

            }
        }

        private void toolStripMenuItem_delete_order_Click(object sender, EventArgs e)
        {
            try
            {

                OrderDTO order = new OrderDTO();
                order.OrderId = orderDisplay.OrderDetails.OrderId;
                if (DialogResult.Yes == MessageBox.Show($"Are you sure you want to delete this order?", "Warning", MessageBoxButtons.YesNo))
                {
                    OrderDTO.DeleteOrder(order);
                    back();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripMenuItem_edit_order_Click(object sender, EventArgs e)
        {
            enableGroupBox();

        }

        private void btn_update_order_Click(object sender, EventArgs e)
        {
            try
            {
                // public OrderDTO(int orderId, Employee employee, Customer customer, int statusId,
                //ServiceDTO service, int initialBudgetId, int platformId, string description)
                int statusId = LookupDL.GetLookupId("status", cmb_status.Text);
                int platformId = LookupDL.GetLookupId("platform", cmb_platform.Text);
                Employee emp = EmployeeDL.GetAllEmployees()[cmb_platform.SelectedIndex];
                ServiceDTO ser = ServiceDL.allServices[cmb_service.SelectedIndex];
                OrderDTO order = new OrderDTO(
                        orderDisplay.OrderDetails.OrderId,
                        emp,
                        customerDisplay.Customer,
                        statusId,
                        ser,
                        orderDisplay.OrderDetails.InitialBudgetId,
                        platformId,
                        orderDisplay.OrderDetails.Description
                    );
                OrderDTO.UpdateOrder(order);
                orderDisplay.OrderDetails.Employee = emp;
                orderDisplay.OrderDetails.Status = cmb_status.Text;
                orderDisplay.OrderDetails.Service = ser;
                orderDisplay.OrderDetails.Platform = cmb_platform.Text;
                employeeDisplay.Employee = emp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            disableGroupBox();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            back();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            disableGroupBox();
        }

        private void back()
        {
            ParentF.Return();
            this.Close();
        }






































        void enableGroupBox(int orderId = -1)
        {
            loadEmployees();
            loadPlatforms();
            loadServices();
            loadStatus();
            gbx_add_update_order.Enabled = true;
            gbx_add_update_order.Visible = true;

            cmb_platform.Text = orderDisplay.OrderDetails.Platform;
            cmb_service.Text = orderDisplay.OrderDetails.Service.Name;
            cmb_status.Text = orderDisplay.OrderDetails.Status;
            cmb_supervision.Text = orderDisplay.OrderDetails.Employee.Name;
        }

        private void disableGroupBox()
        {
            gbx_add_update_order.Enabled = false;
            gbx_add_update_order.Visible = false;
            cmb_service.Text = "Select Service";
            cmb_platform.Text = "Select platform";
            cmb_supervision.Text = "Select Supervision";
            cmb_status.Text = "Select Status";
        }
        private void loadPlatforms()
        {
            try
            {
                cmb_platform.Items.Clear();
                List<Lookup> platforms = new List<Lookup>();
                foreach (Lookup p in LookupDL.GetLookupsByKeyGroup("platform"))
                {
                    platforms.Add(p);
                }
                cmb_platform.Items.AddRange(platforms.ToArray());
                //= platforms.ToArray();
                //if (cmb_platform.Items.Count > 0)
                //    cmb_platform.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadStatus()
        {
            try
            {
                cmb_status.Items.Clear();
                List<Lookup> statuses = new List<Lookup>();
                foreach (Lookup p in LookupDL.GetLookupsByKeyGroup("status"))
                {
                    statuses.Add(p);
                }
                cmb_status.Items.AddRange(statuses.ToArray());
                //if (cmb_status.Items.Count > 0)
                //    cmb_status.SelectedIndex = 0;
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
                cmb_service.Items.Clear();
                foreach (ServiceDTO s in ServiceDL.allServices)
                {
                    cmb_service.Items.Add(s.Name);
                }
                if (cmb_service.Items.Count > 0)
                    cmb_service.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadEmployees()
        {
            try
            {
                cmb_supervision.Items.Clear();
                foreach (Employee e in EmployeeDL.GetAllEmployees())
                {
                    cmb_supervision.Items.Add(e.Name);
                }
                if (cmb_supervision.Items.Count > 0)
                    cmb_supervision.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
