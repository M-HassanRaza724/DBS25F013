using DbFinalProject.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.DL
{
    public class EmployeeDGV_DL
    {
        public static List<EmployeeDGV> allEmployees = new List<EmployeeDGV>();

        public static void LoadEmployees()
        {
            try
            {
                allEmployees.Clear();
                string query = "SELECT * FROM get_employees_info;";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    string username = data[0].ToString();
                    string employeeName = data[1].ToString();
                    string phone = data[2].ToString();
                    DateTime joinedDate = DateTime.Parse(data[3].ToString()).Date;
                    string designation = data[4].ToString();
                    int ordersCompleted = data.IsDBNull(5) ? 0 : data.GetInt32(5);
                    allEmployees.Add(new EmployeeDGV(username, employeeName, phone, joinedDate, designation, ordersCompleted));
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

    }
}
