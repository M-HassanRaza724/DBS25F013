using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;
using System.Runtime.CompilerServices;

namespace SoftwareFirmManagement.UI
{
    public partial class CustomerManagement : KryptonForm
    {
        string sortby = null, direction = null;
        DataGridViewRow currentContextRow = null;
        public CustomerManagement()
        {
            InitializeComponent();
            
            //this.dgv_customers.ContextMenuStrip = contextMenuStrip_grd;
            //dgv_customers.Rows.ContextMenuStrip = contextMenuStrip_grd;
        }


        public void LoadData(string search = null) // search argument is used only when a search button calls this function.
        {
            if (search == "Search")
                search = null;
            customerBindingSource.DataSource = Customer.GetAllCustomers(search, sortby ,direction);
            dgv_customers.DataSource = customerBindingSource;
        }

     

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void userNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortby != "username") sortby = "username";
            else sortby = null;
            LoadData();
            //MessageBox.Show($"Sort by {sortby}");
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

        private void contextMenuStrip_grd_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip_grd_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgv_customers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                currentContextRow = dgv_customers.Rows[e.RowIndex];
                dgv_customers.ClearSelection();
                currentContextRow.Selected = true;
                contextMenuStrip_grd.Show(dgv_customers, dgv_customers.PointToClient(Cursor.Position));
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer.UpdateCustomer(Convert.ToInt32(currentContextRow.Cells["dataGridViewTextBoxColumn1"].Value));
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer.DeleteCustomer(Convert.ToInt32(currentContextRow.Cells["dataGridViewTextBoxColumn1"].Value));

        }

        private void customerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortby != "name")   sortby = "name";
            else   sortby = null;
            MessageBox.Show($"Sort by {sortby}");
            LoadData();
        }



    }
}
