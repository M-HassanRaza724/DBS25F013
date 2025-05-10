using SoftwareFirmManagement.DL;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public static OrderDTO demoOrder = new OrderDTO()
        {
            orderId = -1,
            createdAt = new DateTime(2025, 05, 10),
            statusId = -1,
            customer = new Customer("username", "email", "pass", -1, "customer"),
            employee = new Employee("username", "email", "pass", -1, "employee", "03000000000", new DateTime(), -1),
            status = "Pending",
            initialBudgetId = -1,
            platformId = -1,
            initialBudget = "<$5000",
            service = new ServiceDTO(-1, "service", -1, "description"),
            platform = "demo",
            description = "demo description",
        };
        // Constructors
        public OrderDTO()
        {
            // Default constructor
        }


        //For data retrieval
        public OrderDTO(int orderId, int statusId, int initialBudgetId, int platformId, Employee employee, Customer customer, DateTime createdAt, string status,
                ServiceDTO service, string initialBudget, string platform, string description)
        {
            this.orderId = orderId;
            //this.OrderDetailId = orderDetailId;   // not needed
            this.Employee = employee;
            this.Customer = customer;
            this.CreatedAt = createdAt;
            this.StatusId = statusId;
            this.Status = status;
            this.Service = service;
            this.InitialBudgetId = initialBudgetId;
            this.PlatformId = platformId;
            this.InitialBudget = initialBudget;
            this.Platform = platform;
            this.Description = description;
        }
        // for updating 
        public OrderDTO(int orderId, Employee employee, Customer customer, int statusId,
                       ServiceDTO service, int initialBudgetId, int platformId, string description)
        {
            this.OrderId = orderId;
            //this.OrderDetailId = orderDetailId;   // not needed
            this.Employee = employee;
            this.Customer = customer;
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
            set { employee = value ?? throw new ArgumentNullException("Employee cant be null"); }
        }
        public Customer Customer
        {
            get { return customer; }
            set { customer = value ?? throw new ArgumentNullException("Customer cant be null"); }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value <= DateTime.Now ? value : throw new InvalidTimeZoneException("I think you have successfully invented time machine"); }
        }

        public int StatusId
        {
            get { return statusId; }

            set
            {
                MessageBox.Show(String.Join(", ", LookupDL.GetLookupIdsByKeyGroup("status")));
                statusId = LookupDL.GetLookupIdsByKeyGroup("status").Contains(value) ? value : throw new InvalidOperationException("Invalid Status Id");
            }
        }
        public string Status
        {
            get { return status; }
            set
            {
                List<string> statuses = LookupDL.GetLookupValuesByKeyGroup("status");
                //MessageBox.Show(String.Join(", ", statuses));
                status = statuses.Contains(value) ? value : throw new InvalidOperationException("Invalid Status");
            }
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
            set
            {
                service = value;
                //service = ServiceDL.allServices.Contains(value) ? value : throw new InvalidOperationException("Invalid service"); }
            }
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
        public static List<OrderDTO> GetOrdersByFilter(List<string> statuses, string search = null, string sortby = null, string direction = "ASC")
        {
            List<OrderDTO> filtered = OrderDL.allOrders
                                          .OfType<OrderDTO>()
                                          .Where(orders => statuses.Contains(orders.status))
                                          .ToList();
            if (search == null && sortby == null)
            {
                return filtered
                            .OfType<OrderDTO>()
                            .OrderByDescending(l => l.CreatedAt)
                            .ToList();
            }
            if (search != null)
            {
                filtered = filtered
                                .OfType<OrderDTO>()
                                .Where(orders => (orders.Description.Contains(search) || orders.Service.Name.Contains(search)))
                                .ToList();
            }
            if (sortby != null)
            {


                if (direction == "DESC" && sortby == "customerName")
                {
                    filtered = filtered
                               .OrderByDescending(l => l.Customer.Name)
                               .ToList();
                }
                else if (sortby == "customerName")
                {
                    filtered = filtered
                               .OrderBy(l => l.Customer.Name)
                               .ToList();
                }
                else if (direction == "DESC" && sortby == "orderDate")
                {
                    filtered = filtered
                               .OrderByDescending(l => l.CreatedAt)
                               .ToList();
                }
                else if (sortby == "orderDate")
                {
                    filtered = filtered
                               .OrderBy(l => l.CreatedAt)
                               .ToList();
                }
                else if (direction == "DESC" && sortby == "serviceName")
                {
                    filtered = filtered
                               .OrderByDescending(l => l.Service.Name)
                               .ToList();
                }
                else if (sortby == "serviceName")
                {
                    filtered = filtered
                               .OrderBy(l => l.Service.Name)
                               .ToList();
                }
            }
            return filtered;
        }
    }
}
