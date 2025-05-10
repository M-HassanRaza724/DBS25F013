using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbFinalProject.BL;

namespace DbFinalProject.DL
{
    public class OrderDGV_DL
    {
        public static List<OrderDGV> LoadOrders()
        {
            try
            {
                List<OrderDGV> orders = new List<OrderDGV>();
                string query = "SELECT * FROM get_orders_for_admins_and_employees;";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    int orderId = data.IsDBNull(0) ? 0 : data.GetInt32(0);
                    string customerName = data[1].ToString();
                    string serviceName = data[2].ToString();
                    DateTime creatdAt = DateTime.Parse(data[3].ToString());
                    string orderStatus = data[4].ToString();
                    string paymentStatus = data[5].ToString();
                    int stars = data.IsDBNull(6) ? 0 : data.GetInt32(6);
                    string reviwDescription = data[7].ToString();
                    orders.Add(new OrderDGV(orderId, customerName, serviceName, creatdAt, orderStatus, paymentStatus, stars, reviwDescription));
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
