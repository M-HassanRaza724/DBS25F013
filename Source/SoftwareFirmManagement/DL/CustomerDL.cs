using SoftwareFirmManagement.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
