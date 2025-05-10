using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;


namespace SoftwareFirmManagement.DL
{
    public class EmployeeDL
    {
        public static List<Employee> GetAllEmployees(string search = null, string sortby = null, string direction = null)
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                foreach (User user in UserDL.allUsers)
                {
                    if (user is Employee employee)
                    {
                        employees.Add(employee);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return employees;
        }
        public static List<Employee> GetOnlyUsersFromDatabase()
        {
            try
            {
                List<Employee> onlyUsers = new List<Employee>();
                string query = $"SELECT * FROM users;";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    int userId = data.IsDBNull(0) ? 0 : data.GetInt32(0);
                    string username = data[1].ToString();
                    string email = data[2].ToString();
                    string password = data[3].ToString();
                    int roleId = data.IsDBNull(4) ? 0 : data.GetInt32(4);
                    Employee user = new Employee(userId, username, email, password, roleId, 0, "no_name", "no_phone", DateTime.Now, 0);
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


        public static bool AddEmployeeToDatabase(Employee employee)
        {
            try
            {
                string formattedDate = employee.JoinedDate.ToString("yyyy-MM-dd");
                string query = $"CALL sp_manage_employee('add', {employee.EmployeeId}, '{employee.Name}', '{employee.Phone}', '{formattedDate}', {employee.DesignationId}, {employee.UserId});";
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
                string formattedDate = employee.JoinedDate.ToString("yyyy-MM-dd");
                string query = $"CALL sp_manage_employee('update', {employee.EmployeeId}, '{employee.Name}', '{employee.Phone}', '{formattedDate}', {employee.DesignationId}, {employee.UserId});";
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
                string formattedDate = employee.JoinedDate.ToString("yyyy-MM-dd");
                string query = $"CALL sp_manage_employee('delete', {employee.EmployeeId}, '{employee.Name}', '{employee.Phone}', '{formattedDate}', {employee.DesignationId}, {employee.UserId});";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

        public static Employee GetEmployeeById(int id)
        {
            foreach (var user in UserDL.allUsers)
            {
                if(user is Employee e)
                {
                    if(e.EmployeeId == id)
                    {
                        return e;
                    }
                }
            }
            return null;
        }
    }
}
