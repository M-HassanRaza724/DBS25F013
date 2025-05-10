using DbFinalProject.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.DL
{
    public class OrderDL
    {
        public static List<Order> allOrders = new List<Order>();

        public static void LoadAllOrders()
        {
            try
            {
                allOrders.Clear();
                string query = "SELECT * FROM orders;";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    int orderId = data.IsDBNull(0) ? 0 : data.GetInt32("order_id");
                    int employeeId = data.IsDBNull(1) ? 0 : data.GetInt32(1);
                    int userId = data.IsDBNull(2) ? 0 : data.GetInt32(2);
                    DateTime createdAt = DateTime.Parse(data[3].ToString()).Date;
                    int statusId = data.IsDBNull(4) ? 0 : data.GetInt32(4);
                    int serviceId = data.IsDBNull(5) ? 0 : data.GetInt32(5);
                    allOrders.Add(new Order(orderId, employeeId, userId, createdAt, statusId, serviceId));
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool PlaceOrderInDatabase(Order order, int price, DateTime dueDate)
        {
            try
            {
                string formattedDate = dueDate.Date.ToString("yyyy-MM-dd");
                string query = $"CALL sp_place_order({order.EmployeeId}, {order.UserId}, {order.ServiceId}, {price}, '{formattedDate}');";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool CancelOrderInDatabase(Order order)
        {
            try
            {
                string query = $"CALL sp_cancel_order({order.OrderId});";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


    }
}
