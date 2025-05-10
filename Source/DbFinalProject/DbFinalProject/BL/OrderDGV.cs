using DbFinalProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.BL
{
    public class OrderDGV
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string ServiceName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public int Stars {  get; set; }
        public string ReviewDescription { get; set; }

        public OrderDGV(int orderId, string customrName, string serviceName, DateTime createdAt, string orderStatus, string paymentStatus, int stars, string reviewDescription)
        {
            OrderId = orderId;
            CustomerName = customrName;
            ServiceName = serviceName;
            CreatedAt = createdAt;
            OrderStatus = orderStatus;
            PaymentStatus = paymentStatus;
            Stars = stars;
            ReviewDescription = reviewDescription; 
        }


        public static List<OrderDGV> GetOrdrs()
        {
            try
            {
                return OrderDGV_DL.LoadOrders();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


    }
}
