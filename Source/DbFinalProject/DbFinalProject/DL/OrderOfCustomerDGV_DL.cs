using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbFinalProject.BL;
using ZstdSharp.Unsafe;

namespace DbFinalProject.DL
{
    public class OrderOfCustomerDGV_DL
    {
        public static List<OrderOfCustomerDGV> LoadOrdersOfCustomer(Customer customer)
        {
            try
            {
                List<OrderOfCustomerDGV> orders = new List<OrderOfCustomerDGV>();
                orders.Clear();
                string query = $"CALL sp_get_orders_of_customer({customer.UserId});";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    int orderId = data.IsDBNull(0) ? 0 : data.GetInt32(0);
                    string serviceName = data[1].ToString();
                    DateTime createdAt = DateTime.Parse(data[2].ToString()).Date;
                    string orderStatus = data[3].ToString();
                    string paymentStatus = data[4].ToString();
                    int stars = data.IsDBNull(5) ? 0 : data.GetInt32(5);
                    string description = data.IsDBNull(6) ? "null" : data[6].ToString();
                    orders.Add(new OrderOfCustomerDGV(orderId, serviceName, createdAt, orderStatus, paymentStatus, stars, description));
                }
                return orders;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

    }
}
