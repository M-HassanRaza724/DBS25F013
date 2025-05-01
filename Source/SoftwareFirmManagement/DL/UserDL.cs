using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;

namespace SoftwareFirmManagement.DL
{
    public class UserDL
    {
        public static List<User> allUsers = new List<User>();

        public static void LoadAllUsers()
        {
            try
            {
                string query2 = "SELECT * FROM users NATURAL JOIN admins;";
                var data2 = DatabaseHelper.Instance.GetData(query2);
                while (data2.Read())
                {
                    int userId = data2.IsDBNull(0) ? 0 : data2.GetInt32(0);
                    string username = data2[1].ToString();
                    string email = data2[2].ToString();
                    string password = data2[3].ToString();
                    int roleId = data2.IsDBNull(4) ? 0 : data2.GetInt32(4);
                    int adminId = data2.IsDBNull(5) ? 0 : data2.GetInt32(5);
                    string name = data2[6].ToString();
                    string phone = data2[7].ToString();
                    int adminRole = data2.IsDBNull(8) ? 0 : data2.GetInt32(8);
                    Admin newAdmin = new Admin(userId, username, email, password, roleId, adminId, name, phone, adminRole);
                    string role = LookupDL.allLookups
                                  .Where(l => l.LookupId == roleId)
                                  .Select(l => l.Value)
                                  .FirstOrDefault();
                    newAdmin.Role = role;
                    allUsers.Add(newAdmin);
                }
                // adding employees
                string query3 = $"SELECT * FROM users NATURAL JOIN employees;";
                var data3 = DatabaseHelper.Instance.GetData(query3);
                while (data3.Read())
                {
                    int userId = data3.IsDBNull(0) ? 0 : data3.GetInt32(0);
                    string username = data3[1].ToString();
                    string email = data3[2].ToString();
                    string password = data3[3].ToString();
                    int roleId = data3.IsDBNull(4) ? 0 : data3.GetInt32(4);
                    int employeeId = data3.IsDBNull(5) ? 0 : data3.GetInt32(5);
                    string name = data3[6].ToString();
                    string phone = data3[7].ToString();
                    DateTime joinedDate = DateTime.Parse(data3[8].ToString()).Date;
                    int designationId = data3.IsDBNull(9) ? 0 : data3.GetInt32(9);
                    Employee newEmp = new Employee(userId, username, email, password, roleId, employeeId, name, phone, joinedDate, designationId);
                    string role = LookupDL.allLookups
                                  .Where(l => l.LookupId == roleId)
                                  .Select(l => l.Value)
                                  .FirstOrDefault();
                    newEmp.Role = role;
                    allUsers.Add(newEmp);
                }
                string query4 = "SELECT * FROM users NATURAL JOIN customers;";
                var data4 = DatabaseHelper.Instance.GetData(query4);
                while (data4.Read())
                {
                    int userId = data4.IsDBNull(0) ? 0 : data4.GetInt32(0);
                    string username = data4[1].ToString();
                    string email = data4[2].ToString();
                    string password = data4[3].ToString();
                    int roleId = data4.IsDBNull(4) ? 0 : data4.GetInt32(4);
                    int customerId = data4.IsDBNull(5) ? 0 : data4.GetInt32(5);
                    string name = data4.IsDBNull(6) ? "null" : data4[6].ToString();
                    Customer newCust = new Customer(userId, username, email, password, roleId, customerId, name);
                    string role = LookupDL.allLookups
                                  .Where(l => l.LookupId == roleId)
                                  .Select(l => l.Value)
                                  .FirstOrDefault();
                    newCust.Role = role;
                    allUsers.Add(newCust);
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool AddUserToDatabase(User user)
        {
            try
            {
                string query = $"INSERT INTO users VALUES ({user.UserId}, '{user.Username}', '{user.Email}', {user.Password}, {user.RoleId};)";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static bool UpdateUserToDatabse(User updatedUser) // only password is updatable
        {
            try
            {
                string query = $"UPDATE users SET password = '{updatedUser.Password}') WHERE user_id = {updatedUser.UserId};";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static bool DeleteUserFromDatabase(User userToDelete)
        {
            try
            {
                string query = $"DELETE FROM users WHERE user_id = {userToDelete.UserId};";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
