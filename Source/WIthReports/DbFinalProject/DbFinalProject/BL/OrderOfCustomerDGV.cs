using DbFinalProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.BL
{
    public class OrderOfCustomerDGV
    {
        public int OrderId { get; set; }
        public string ServiceName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public int Stars { get; set; }
        public string Description { get; set; }

        public OrderOfCustomerDGV(int orderId, string serviceName, DateTime createdAt, string orderStatus, string paymentStatus, int stars, string description)
        {
            OrderId = orderId;
            ServiceName = serviceName;
            CreatedAt = createdAt;
            OrderStatus = orderStatus;
            PaymentStatus = paymentStatus;
            Stars = stars;
            Description = description;
        }


        public static List<OrderOfCustomerDGV> GetOrdersOfCustomer(Customer customer)
        {
            try
            {
                return OrderOfCustomerDGV_DL.LoadOrdersOfCustomer(customer);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

    }
}
