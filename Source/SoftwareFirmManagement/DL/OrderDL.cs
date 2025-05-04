using SoftwareFirmManagement.BL;
using System;
using System.Collections.Generic;

namespace SoftwareFirmManagement.DL
{

    class OrderDL
    {
        public static List<OrderDTO> allOrders = new List<OrderDTO>();
        public static void GetAllOrdersFromDatabase()
        {
            try
            {
                allOrders.Clear();
                string query = $"SELECT * all_orders;;";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    Employee e = new Employee()
                    {
                        EmployeeId = data.IsDBNull(1) ? 0 : data.GetInt32(1),
                        Name = data.IsDBNull(7) ? "no_name" : data.GetString(7).ToString()
                    };
                    Customer c = new Customer()
                    {
                        CustomerId = data.IsDBNull(2) ? 0 : data.GetInt32(2),
                        Name = data.IsDBNull(8) ? "no_name" : data.GetString(8).ToString()

                    };
                    ServiceDTO s = new ServiceDTO()
                    {
                        ServiceId = data.IsDBNull(4) ? 0 : data.GetInt32(4),
                        Name = data.IsDBNull(11) ? "no_name" : data.GetString(11).ToString()
                    };
                    int orderId = data.IsDBNull(0) ? 0 : data.GetInt32(0);
                    DateTime createdAt = data.IsDBNull(9) ? DateTime.MinValue : data.GetDateTime(9);
                    int statusId = data.IsDBNull(3) ? 0 : data.GetInt32(3);
                    int initialBudgetId = data.IsDBNull(5) ? 0 : data.GetInt32(5);
                    int platformId = data.IsDBNull(6) ? 0 : data.GetInt32(6);
                    string status = data.IsDBNull(10) ? "no_status" : data.GetString(10);
                    string initialBudget = data.IsDBNull(13) ? "no_budget" : data.GetString(13);
                    string platform = data.IsDBNull(14) ? "no_platform" : data.GetString(14);
                    string description = data.IsDBNull(12) ? "no_description" : data.GetString(12);
                    OrderDTO order = new OrderDTO(orderId, statusId, initialBudgetId, platformId, e, c,createdAt, status, s, initialBudget, platform, description);
                    allOrders.Add(order);
                }
                
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }
        public static bool AddOrderToDatabase(OrderDTO order)
        {
            try
            {
                DatabaseHelper.Instance.ExecuteNonQuery($"call sp_add_order({order.Employee.EmployeeId}, {order.Customer.CustomerId}, '{order.CreatedAt.ToString()}', {order.StatusId}, {order.Service.ServiceId}, {order.InitialBudgetId}, {order.PlatformId});");
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

        public static bool DeleteOrderInDatabase(OrderDTO order)
        {
            try
            {
                DatabaseHelper.Instance.ExecuteNonQuery($"call sp_delete_order({order.OrderId});");
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

        public static bool UpdateOrderInDatabase(OrderDTO order)
        {
            try
            {
                DatabaseHelper.Instance.ExecuteNonQuery($"call midprojectdb.sp_update_order({order.OrderId}, {order.Employee.EmployeeId}, {order.Customer.CustomerId}, {order.StatusId}, {order.Service.ServiceId}, {order.InitialBudgetId}, {order.PlatformId});");
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }
        public static List<int> GetOrderIds()
        {
            List<int> ids = new List<int>();
            foreach(OrderDTO o in allOrders)
            {
                ids.Add(o.OrderId);
            }
            return ids;
        }
        //public static List<int> GetOrderDetailsID()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
