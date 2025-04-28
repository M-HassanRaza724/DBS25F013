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
        public CustomerManagement()
        {
            InitializeComponent();
        }


        public void LoadData(string search)
        {
            string sortby = null, direction = null;
            if (search == "Search")
                search = null;
            if (rdo_sort_customer_id.Checked)
                sortby = "customer_id";
            else if (rdo_sort_username.Checked)
                sortby = "username";
            else if (rdo_sort_customer_name.Checked)
                sortby = "name";

            if (rdo_sort_asc.Checked)
                direction = "DESC";
            else if (rdo_sort_desc.Checked)
                direction = "ASC";


            customerBindingSource.DataSource = Customer.GetAllCustomers(search, sortby ,direction);
            dgv_customers.DataSource = customerBindingSource;
        }

        private void cbx_sort_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_sort.Checked)
            {
                gbx_sort_by.Visible = true;
            }
            else
            {
                gbx_sort_by.Visible = false;
            }
        }

        private void cbtn_direction_CheckedChanged(object sender, EventArgs e)
        {
            if(cbtn_direction.Checked)
            {
                gbx_direction.Visible = true;
            }
            else
            {
                gbx_direction.Visible = false;
            }
        }
    }
}
