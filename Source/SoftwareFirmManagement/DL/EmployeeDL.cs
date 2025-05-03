using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;

namespace SoftwareFirmManagement.DL
{
    public class EmployeeDL
    {
        public static bool AddEmployeeToDatabase(Employee employee)
        {
            try
            {
                string formattedDate = employee.JoinedDate.ToString("yyyy-MM-dd");
                string query = $"INSERT INTO employees VALUES({employee.EmployeeId}, '{employee.Name}', '{employee.Phone}', '{formattedDate}', {employee.DesignationId}, {employee.UserId});";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

        public static bool UpdateEmployeeToDatabase(Employee employee) // only name and phone are updatable
        {
            try
            {
                string query = $"UPDATE employees SET name = '{employee.Name}', phone = '{employee.Phone}' WHERE employee_id = {employee.EmployeeId};";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool DeleteEmployeeFromDatabase(Employee employee)
        {
            try
            {
                string query = $"DELETE FROM employees WHERE employee_id = {employee.EmployeeId};";
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
