using SoftwareFirmManagement.BL;
using System.Windows.Forms;

namespace SoftwareFirmManagement.UI
{
    public partial class OrderDisplay : UserControl
    {
        private OrderDTO order;

        //OrderDTO demoOrder = new OrderDTO()
        //{
        //    OrderId = 1,
        //    Customer = new Customer()
        //    {
        //        CustomerId = 1,
        //        Name = "John Doe"
        //    },
        //    Service = new ServiceDTO()
        //    {
        //        ServiceId = 1,
        //        Name = "Web Development"
        //    },
        //    CreatedAt = DateTime.Now,
        //    Status = "In-Progress",
        //    Platform = "Web",
        //    Description = "Developing a new website for the client."
        //};
        public OrderDisplay()
        {
            InitializeComponent();
        }

        public OrderDTO OrderDetails
        {
            get { return order; }
            set
            {
                //order = value == null ? demoOrder : value;
                order = value;
                if (value != null)
                {

                    lbl_order_id_text.Text = $"SFM_{order.Customer.CustomerId}_{order.OrderId.ToString()}";
                    lbl_service_text.Text = order.Service.Name;
                    lbl_order_date_text.Text = order.CreatedAt.ToString("dd/MM/yyyy");
                    lbl_status_text.Text = order.Status;
                    lbl_platform_text.Text = order.Platform;
                    lbl_description_text.Text = order.Description;
                }
            }
        }


    }
}
