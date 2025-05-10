using DbFinalProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.BL
{
    public class Order
    {
        private int orderId;
        private int employeeId;
        private int userId;
        private DateTime createdAt;
        private int statusId;
        private int serviceId;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
        public int StatusId
        {
            get { return statusId; }
            set { statusId = value; }
        }
        public int ServiceId
        {
            get { return serviceId; }
            set { serviceId = value; }
        }

        public Order(int employeeId, int userId, DateTime createdAt, int statusId, int serviceId)
        {
            this.employeeId = employeeId;
            this.userId = userId;
            this.createdAt = createdAt;
            this.statusId = statusId;
            this.serviceId = serviceId;
        }


        public Order(int orderId, int employeeId, int userId, DateTime createdAt, int statusId, int serviceId)
        {
            this.orderId = orderId;
            this.employeeId = employeeId;
            this.userId = userId;
            this.createdAt = createdAt;
            this.statusId = statusId;
            this.serviceId = serviceId;
        }


        public bool Place(int price, DateTime dueDate)
        {
            try
            {
                return OrderDL.PlaceOrderInDatabase(this, price, dueDate);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public bool Cancel()
        {
            try
            {
                return OrderDL.CancelOrderInDatabase(this);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public bool Pay()
        {
            try
            {
                return OrderDL.PayOrderInDatabase(this);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static List<Order> GetOrdersOfCurrentCustomer()
        {
            //OrderDL.LoadAllOrders();
            return OrderDL.allOrders
                   .Where(o => o.UserId == Program.currentUser.UserId)
                   .ToList();
        }


        public static List<int> GetOrderIdsNotCompleted()
        {
            return OrderDL.allOrders
                   .Where(o => o.UserId == Program.currentUser.UserId && o.StatusId == 12) // 12 means work-in-progress
                   .Select(o => o.OrderId)
                   .ToList();
        }


        public static Order GetOrderFromOrderId(int orderId)
        {
            return OrderDL.allOrders
                   .Where(o => o.OrderId == orderId)
                   .FirstOrDefault();
        }


        public static List<int> GetOrderIdsNotPaid(Customer customer)
        {
            List<Order> notPaid = OrderDL.GetOrdersNotPaidByCustomer(customer);
            return notPaid
                   .Select(o => o.OrderId)
                   .ToList();
        }


        public bool UpdateReview(int stars, string description)
        {
            try
            {
                return OrderDL.UpdateReview(this.OrderId, stars, description);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

    }
}
