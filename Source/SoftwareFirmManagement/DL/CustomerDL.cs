using SoftwareFirmManagement.BL;
using System;
using System.Collections.Generic;
using ZstdSharp.Unsafe;

namespace SoftwareFirmManagement.DL
{
    public class CustomerDL
    {
        public static bool AddCustomerToDatabase(Customer customer)
        {
            try
            {
                string query = $"INSERT INTO customers VALUES({customer.CustomerId}, {customer.UserId}, {customer.Name});";
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
                string query = $"UPDATE customers SET name = '{updatedCustomer.Name}' WHERE customer_id = {updatedCustomer.CustomerId};";

                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }
        public static List<Customer> GetAllCustomers(string search = null ,string sortby = null, string direction = "ASC")
        {
            List<Customer> list = new List<Customer>();


            foreach (User u in UserDL.allUsers)
            {
                if (u is Customer)
                {
                    list.Add((Customer)u);
                }
            }
            return list;
        }


        public static bool DeleteCustomerFromDatabase(Customer customer)
        {
            try
            {
                string query = $"DELETE FROM customers WHERE customer_id = {customer.CustomerId};";
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
