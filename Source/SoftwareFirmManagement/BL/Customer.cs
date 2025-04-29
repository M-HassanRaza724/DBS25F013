using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFirmManagement.BL
{
    public class Customer : User
    {
        private int customerId;
        private string name;

        public Customer(int userId, string username, string email, string password, int roleId, int customerId, string name) : base(userId, username, email, password, roleId)
        {
            this.customerId = customerId;
            this.name = name;
        }

        public int CustomerId { get { return customerId; } set { customerId = value; } }

        public string Name { get { return name; } set { name = value; } }

        public static List<Customer> GetAllCustomers(string name = null, string sortby = null, string direction = null)
        {
            // replace with DL logic
            List<Customer> customers = new List<Customer>
            {
                { new Customer(0,"ali12","ali@gmail.com","123###",0,0,"Ali Zahid") },
                { new Customer(0,"umer12","umer@gmail.com","123###",0,0,"chota umer") },
                { new Customer(0,"saadi12","asaad@gmail.com","123###",0,0,"Saad nadeem")}
            };
            return customers;
        }

        internal static void DeleteCustomer(int v)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateCustomer(int v)
        {
            throw new NotImplementedException();
        }
    }
}
