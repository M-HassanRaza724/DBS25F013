using SoftwareFirmManagement.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using ZstdSharp.Unsafe;

namespace SoftwareFirmManagement.DL
{
    public class CustomerDL
    {
        public static List<Customer> GetOnlyUsersFromDatabase()
        {
            try
            {
                List<Customer> onlyUsers = new List<Customer>();
                string query = $"SELECT * FROM users;";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    int userId = data.IsDBNull(0) ? 0 : data.GetInt32(0);
                    string username = data[1].ToString();
                    string email = data[2].ToString();
                    string password = data[3].ToString();
                    int roleId = data.IsDBNull(4) ? 0 : data.GetInt32(4);
                    Customer user = new Customer(userId, username, email, password, roleId, 0, "no_name");
                    user.Role = LookupDL.allLookups
                                .Where(l => l.LookupId == roleId)
                                .Select(l => l.Value)
                                .FirstOrDefault();
                    onlyUsers.Add(user);
                }
                return onlyUsers;

            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool AddCustomerToDatabase(Customer customer)
        {
            try
            {
                string query = $"CALL sp_manage_customer('add', {customer.CustomerId}, {customer.UserId}, '{customer.Name}');";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool UpdateCustomerToDatabase(Customer updatedCustomer)
        {
            try
            {
                string query = $"CALL sp_manage_customer('update', {updatedCustomer.CustomerId}, {updatedCustomer.UserId}, '{updatedCustomer.Name}');";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static List<Customer> GetCustomersByFilter(string search = null ,string sortby = null, string direction = "ASC")
        {
            if (search == null || sortby == null)
            {
                return UserDL.allUsers
                       .OfType<Customer>()
                       .OrderBy(l => l.Username)
                       .ToList();
            }
            List<Customer> filtered = UserDL.allUsers
                                      .OfType<Customer>()
                                      .Where(cust => cust.Username.Contains(search) || cust.Name.Contains(search))
                                      .ToList();
            if (direction == "DESC" && sortby == "username")
            {
                filtered = filtered
                           .OrderByDescending(l => l.Username)
                           .ToList();
            }
            else if (sortby == "username")
            {
                filtered = filtered
                           .OrderBy(l => l.Username)
                           .ToList();
            }
            return filtered;
        }


        public static bool DeleteCustomerFromDatabase(Customer customer)
        {
            try
            {
                string query = $"CALL sp_manage_customer('delete', {customer.CustomerId}, {customer.UserId}, '{customer.Name}');";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

        public static List<Customer> GetAllCustomers()
        { return null; }
    }
}
