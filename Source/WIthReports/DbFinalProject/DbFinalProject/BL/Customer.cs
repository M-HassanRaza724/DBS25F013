using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbFinalProject.DL;

namespace DbFinalProject.BL
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


        public Customer(string username, string email, string password, int roleId, string name) : base(username, email, password, roleId)
        {
            this.name = name;
        }



        public Customer() { }


        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public override bool Add(User user)
        {
            try
            {
                if (user is Customer customer)
                {
                    bool userAdded = UserDL.AddUserToDatabase(user);
                    if (!userAdded)
                    {
                        return false;
                    }
                    // if we don't ask UserId from UI, we have to figure out the UserId the DB has assigned (through auto-increment)
                    List<Customer> onlyUsers = CustomerDL.GetOnlyUsersFromDatabase();
                    int userId = onlyUsers
                                 .Where(c => c.Username == user.Username)
                                 .Select(c => c.UserId)
                                 .FirstOrDefault();
                    customer.UserId = userId;
                    bool status = CustomerDL.AddCustomerToDatabase(customer);
                    UserDL.LoadAllUsers();
                    return status;
                }
                return false;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public override bool Update(User user)
        {
            try
            {
                if (user is Customer customer)
                {
                    bool userUpdated = UserDL.UpdateUserToDatabse(user);
                    if (!userUpdated)
                    {
                        return false;
                    }
                    bool status = CustomerDL.UpdateCustomerToDatabase(customer);
                    UserDL.LoadAllUsers();
                    return status;
                }
                return false;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }



        public override bool Delete(User user)
        {
            try
            {
                if (user is Customer customer)
                {
                    bool customerDeleted = CustomerDL.DeleteCustomerFromDatabase(customer);
                    if (!customerDeleted)
                    {
                        return false;
                    }
                    bool status = UserDL.DeleteUserFromDatabase(user);
                    UserDL.LoadAllUsers();
                    return status;
                }
                return false;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static List<string> GetCustomerUsernames()
        {
            return UserDL.allUsers
                   .OfType<Customer>()
                   .Select(c => c.Username)
                   .ToList();
        }


        public static bool DeleteFromUsername(string username)
        {
            try
            {
                Customer customer = UserDL.allUsers
                    .OfType<Customer>()
                    .Where(c => c.Username == username)
                    .FirstOrDefault();
                if (customer == null)
                {
                    return false;
                }
                bool status = CustomerDL.DeleteCustomerFromDatabase(customer);
                UserDL.LoadAllUsers();
                return status;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


    }
}
