using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareFirmManagement.DL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace SoftwareFirmManagement.BL
{
    public class OrderDTO
    {
        // Attributes from Orders table
        int orderId;
        DateTime createdAt;
        // attributes for DB
        int statusId;
        //Attributes for UI and BL logic
        Customer customer; // use customer.CustomerId for id
        Employee employee; // use employee.EmployeeId for id
        string status;

        // Attributes from OrderDetails table
        // attributes for DB
        //int orderDetailId;   not needed since orderid is in both tables and orderdetailID in auto increment and also both tables has 1:1 relation 
        int initialBudgetId;
        int platformId;
        //Attributes for UI and BL logic
        string initialBudget;
        ServiceDTO service; // use service.ServiceId for id
        string platform;
        string description;

        // Constructors
        public OrderDTO()
        {
            // Default constructor
        }


        //For data retrieval
        public OrderDTO(int orderId, int statusId, int initialBudgetId, int platformId, Employee employee, Customer customer, DateTime createdAt, string status,
                ServiceDTO service, string initialBudget, string platform, string description)
        {
            this.OrderId = orderId;
            //this.OrderDetailId = orderDetailId;   // not needed
            this.Employee = employee;
            this.Customer = customer;
            this.CreatedAt = createdAt;
            this.StatusId = statusId;
            this.Service = service;
            this.InitialBudgetId = initialBudgetId;
            this.PlatformId = platformId;
            this.InitialBudget = initialBudget;
            this.Platform = platform;
            this.Description = description;
        }
        // for updating 
        public OrderDTO(int orderId, Employee employee, Customer customer, DateTime createdAt, int statusId,
                       ServiceDTO service, int initialBudgetId, int platformId, string description)
        {
            this.OrderId = orderId;
            //this.OrderDetailId = orderDetailId;   // not needed
            this.Employee = employee;
            this.Customer = customer;
            this.CreatedAt = createdAt;
            this.StatusId = statusId;
            this.Service = service;
            this.InitialBudgetId = initialBudgetId;
            this.PlatformId = platformId;
            this.Description = description;
        }
        // for creating (adding)
        public OrderDTO(Employee employee, Customer customer, int statusId,
                            ServiceDTO service, int initialBudgetId, int platformId, string description)
        {
            this.Employee = employee;
            this.Customer = customer;
            this.CreatedAt = DateTime.Now;
            this.StatusId = statusId;
            this.Service = service;
            this.InitialBudgetId = initialBudgetId;
            this.PlatformId = platformId;
            this.Description = description;
        }
        //for UI display (less use)
        public OrderDTO(Employee employee, Customer customer, DateTime createdAt, string status,
              ServiceDTO service, string initialBudget, string platform, string description)
        {
            this.Employee = employee;
            this.Customer = customer;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Service = service;
            this.InitialBudget = initialBudget;
            this.Platform = platform;
            this.Description = description;
        }

        // Getters and Setters for Orders table attributes
        public int OrderId
        {
            get { return orderId; }
            set { orderId = OrderDL.GetOrderIds().Contains(value) ? value : throw new InvalidOperationException("Invalid OrderId"); }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Employee Employee
        {
            get { return employee; }
            set { employee = value ?? throw new ArgumentNullException("Employee cant be null") ; }
        }
        public Customer Customer
        {
            get { return customer; }
            set { customer = value ?? throw new ArgumentNullException("Customer cant be null"); }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value >= DateTime.Now ? value : throw new InvalidTimeZoneException("I think you have successfully invented time machine"); }
        }

        public int StatusId
        {
            get { return statusId; }
            
           set { statusId =  LookupDL.GetLookupIdsByKeyGroup("Status").Contains(value) ? value : throw new InvalidOperationException("Invalid Status Id");  }
        }
        public string Status
        {
            get { return status; }
            set { status = LookupDL.GetLookupValuesByKeyGroup("Status").Contains(value) ? value : throw new InvalidOperationException("Invalid Status"); }
        }
        // Getters and Setters for OrderDetails table attributes
        //public int OrderDetailId  // not needed
        //{
        //    get { return orderDetailId; }
        //    set { orderDetailId = value; }
        //}
        public ServiceDTO Service
        {
            get { return service; }
            set { service = ServiceDL.allServices.Contains(value) ? value : throw new InvalidOperationException("Invalid service"); }
        }

        public int InitialBudgetId
        {
            get { return initialBudgetId; }
            set { initialBudgetId = LookupDL.GetLookupIdsByKeyGroup("budget_type").Contains(value) ? value : throw new InvalidOperationException("Invalid initial budget id"); }
        }

        public int PlatformId
        {
            get { return platformId; }
            set { platformId = LookupDL.GetLookupIdsByKeyGroup("platform").Contains(value) ? value : throw new InvalidOperationException("Invalid initial platform id"); }
        }
        public string InitialBudget
        {
            get { return initialBudget; }
            set { initialBudget = LookupDL.GetLookupValuesByKeyGroup("budget_type").Contains(value) ? value : throw new InvalidOperationException("Invalid initial budget"); ; }
        }

        public string Platform
        {
            get { return platform; }
            set { platform = LookupDL.GetLookupValuesByKeyGroup("platform").Contains(value) ? value : throw new InvalidOperationException("Invalid initial platform"); ; }
        }

      
        public static bool AddOrder(OrderDTO order)
        {
            try
            {
                if (OrderDL.AddOrderToDatabase(order))
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
            return false;
        }
        public static bool UpdateOrder(OrderDTO order)
        {
            try
            {
                if (OrderDL.UpdateOrderInDatabase(order))
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
            return false;
        }
        public static bool DeleteOrder(OrderDTO order) // i used whole object so that getter validation should also be applied on id
        {
            try
            {
                if (OrderDL.DeleteOrderInDatabase(order))
                    return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
            return false;
        }

        public static List<OrderDTO> GetOrdersByFilter(string search = null, string sortby = null, string direction = "ASC")
        { // incomplete function because of incomplete UI structure
            if (search == null || sortby == null)
            {
                return OrderDL.allOrders
                       .OfType<OrderDTO>()
                       .OrderBy(l => l.createdAt)
                       .ToList();
            }
            List<OrderDTO> filtered = OrderDL.allOrders
                                      .OfType<OrderDTO>()
                                      .Where(cust => cust.Description.Contains(search) || cust.Service.Name.Contains(search))
                                      .ToList();
            //if (direction == "DESC" && sortby == "username")
            //{
            //    filtered = filtered
            //               .OrderByDescending(l => l.Ordername)
            //               .ToList();
            //}
            //else if (sortby == "username")
            //{
            //    filtered = filtered
            //               .OrderBy(l => l.Ordername)
            //               .ToList();
            //}
            return filtered;
        }
    }
}
