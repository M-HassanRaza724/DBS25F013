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

namespace SoftwareFirmManagement.UI
{
    public partial class CustomerManagement: KryptonForm
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void cbx_sort_MouseClick(object sender, MouseEventArgs e)
        {
            if (gbx_sort_by.Visible == false)
            {
                gbx_sort_by.Visible = true;
            }
            else
            {
                gbx_sort_by.Visible = false;
            }
        }

        private void cbtn_direction_Click(object sender, EventArgs e)
        {
            if(gbx_direction.Visible == false)
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
