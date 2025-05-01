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
using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement.UI
{
    public partial class CustomerManagement : KryptonForm
    {
        string sortby = null, direction = null;
        DataGridViewRow currentContextRow = null;
        public CustomerManagement()
        {
            InitializeComponent();
        }

        public void LoadData(string search = null) // search argument is used only when a search button calls this function.
        {
            if (search == "Search")
                search = null;
            customerBindingSource.DataSource = CustomerDL.GetAllCustomers(search, sortby, direction);
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

        private void btn_add_update_cust_Click(object sender, EventArgs e)
        {
            if (btn_add_update_cust.Text == "Update")
            {
                try
                {
                    Customer customer = new Customer(Convert.ToInt32(currentContextRow.Cells["UserIdColumn"].Value), userCredentials1.Username, userCredentials1.Email, userCredentials1.Password, LookupDL.GetLookupId("user_role", "Customer"), Convert.ToInt32(currentContextRow.Cells["CustomerIdColumn"].Value), txt_full_name.TextBoxText);
                    customer.Update(customer);
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
                    Customer customer = new Customer(userCredentials1.Username, userCredentials1.Email, userCredentials1.Password, LookupDL.GetLookupId("user_role", "Customer"), txt_full_name.TextBoxText);
                    customer.Add(customer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            LoadData();
            disableGroupBox();
        }
        void enableGroupBox(int custId = -1)
        {
            gbx_add_update_cust.Enabled = true;
            gbx_add_update_cust.Visible = true;
            if (custId != -1)
            {
                txt_full_name.TextBoxText = currentContextRow.Cells["FullNameColumn"].Value.ToString();
                userCredentials1.Username = currentContextRow.Cells["UsernameColumn"].Value.ToString();
                userCredentials1.Email = currentContextRow.Cells["EmailColumn"].Value.ToString();
                userCredentials1.Password= currentContextRow.Cells["PasswordColumn"].Value.ToString();

                btn_add_update_cust.Text = "Update";
                gbx_add_update_cust.Text = "Update Customer";
            }
        }
        void disableGroupBox()
        {
            gbx_add_update_cust.Enabled = false;
            gbx_add_update_cust.Visible = false;
            txt_full_name.PlaceHolder = "FirstName";
            userCredentials1.UsernamePlaceHolder = "Username";
            userCredentials1.EmailPlaceHolder = "Email";
            userCredentials1.PasswordPlaceHolder = "Password";
            btn_add_update_cust.Text = "Add";
            gbx_add_update_cust.Text = "Add Customer";
        }

 
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableGroupBox(Convert.ToInt32(currentContextRow.Cells["CustomerIdColumn"].Value));
            //Customer.UpdateCustomer(Convert.ToInt32(currentContextRow.Cells["dataGridViewTextBoxColumn1"].Value));
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int custId = Convert.ToInt32(currentContextRow.Cells["CustomerIdColumn"].Value);
            Customer c = new Customer();
            c.CustomerId = custId;
           
            if (DialogResult.Yes == MessageBox.Show($"Are you sure you want to delete {currentContextRow.Cells["FullNameColumn"].Value.ToString()}?", "Warning", MessageBoxButtons.YesNo))
            c.Delete(c);
        }

  


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            disableGroupBox();

        }

        private void btn_add_cust_Click(object sender, EventArgs e)
        {
            enableGroupBox();
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
