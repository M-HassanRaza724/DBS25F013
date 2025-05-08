using DbFinalProject.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.DL
{
    public class CustomerDGV_DL
    {
        public static List<CustomerDGV> customersForDGV = new List<CustomerDGV>();

        public static bool LoadCustomers()
        {
            try
            {
                customersForDGV.Clear();
                string query = "SELECT * FROM get_customers_info;";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    string custName = data[0].ToString();
                    string email = data[1].ToString();
                    int ordersBooked = data.IsDBNull(2) ? 0 : data.GetInt32(2);
                    double totalSpending = data.IsDBNull(3) ? 0 : data.GetDouble(3);
                    double avgSpending = data.IsDBNull(4) ? 0 : data.GetDouble(4);
                    customersForDGV.Add(new CustomerDGV(custName, email, ordersBooked, totalSpending, avgSpending));
                }
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }
    }
}
