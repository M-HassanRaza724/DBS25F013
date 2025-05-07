using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;

namespace SoftwareFirmManagement.UI
{
    public partial class OrderDisplay: UserControl
    {
        private OrderDTO order_details;
        public OrderDisplay()
        {
            InitializeComponent();
        }

        public OrderDTO OrderDetails
        {
            get { return order_details; }
            set
            {
                order_details = value;
                lbl_order_id_text.Text = $"SFM_{order_details.Customer.CustomerId}_{order_details.OrderId.ToString()}";
                lbl_service_text.Text = order_details.Service.Name;
                lbl_order_date_text.Text = order_details.CreatedAt.ToString("dd/MM/yyyy");
                lbl_status.Text = order_details.Status;
                lbl_platform_text.Text = order_details.Platform;
                lbl_description_text.Text = order_details.Description;
            }
        }

     
    }
}
