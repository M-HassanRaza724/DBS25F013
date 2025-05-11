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
using Google.Protobuf.WellKnownTypes;

namespace SoftwareFirmManagement.UI
{
    public partial class OrderManagement : KryptonForm
    {
        MainForm parent;
        public MainForm ParentForm { get { return parent; } set { parent = value; } }
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
            List<string> statuses = GetCheckedStatuses();
            //MessageBox.Show($"{String.Join(", ", statuses)} , {search} , {sortby} , {direction}");
            OrderBindingSource.DataSource = OrderDTO.GetOrdersByFilter(statuses,search, sortby, direction);
            dgv_orders.DataSource = OrderBindingSource;
        }
        private void OrderManagement_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        
        {
            
            OrderDTO order = OrderDL.GetOrderById(Convert.ToInt32(currentContextRow.Cells["orderIdColumn"].Value));
            Employee employee = EmployeeDL.GetEmployeeById(order.Employee.EmployeeId);
            Customer customer = CustomerDL.GetCustomerById(order.Customer.CustomerId);
            OrderDetailsForm orderDetails = new OrderDetailsForm(order, customer, employee);
            orderDetails.ParentF = this;
            orderDetails.GrandParentForm = ParentForm;
            ParentForm.HideForm();
            ParentForm.ShowFormInPanel(orderDetails);
        }
        public void Return()
        {
            ParentForm.HideForm();
            ParentForm.ShowFormInPanel(this);
        }
        private void tsm_completed_Click(object sender, EventArgs e)
        {

        }

        private void cancelledToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private List<string> GetCheckedStatuses()
        {
            List<string> statuses = new List<string>();
            foreach (ToolStripMenuItem item in statusToolStripMenuItem.DropDownItems)
            {
                if (item.Checked)
                {
                    statuses.Add(item.Text);
                }
            }
            return statuses;
        }
        private void CustomerNameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(sortby == "customerName")
            {
                sortby = null;
            }
            else
                sortby = "customerName";
            LoadData();

        }

        private void ServiceNameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (sortby == "serviceName")
            {
                sortby = null;
            }
            else
                sortby = "serviceName";

            LoadData();

        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortby == "orderdate")
            {
                sortby = null;
            }
            else
                sortby = "orderdate";
            LoadData();

        }


        private void ToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }


        private void tableLayoutPanel_filters_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderManagement_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void statusToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
        }

        private void tsm_status_pending_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();

        }

        private void tsm_in_progress_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();

        }

        private void tsm_completed_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();

        }

        private void tsm_cancelled_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();

        }

        private void tsm_on_hold_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();

        }

        private void tsm_rejected_CheckedChanged(object sender, EventArgs e)
        {
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
      
      
    }
}