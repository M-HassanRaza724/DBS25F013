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
                // adding users
                string query1 = "SELECT * FROM users;";
                var data1 = DatabaseHelper.Instance.GetData(query1);
                while (data1.Read())
                {
                    int userId = data1.IsDBNull(0) ? 0 : data1.GetInt32(0);
                    string username = data1[1].ToString();
                    string email = data1[2].ToString();
                    string password = data1[3].ToString();
                    int roleId = data1.IsDBNull(4) ? 0 : data1.GetInt32(4);
                    //allUsers.Add(new User(userId, username, email, password, roleId));
                }
                // adding admins
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
                    //allUsers.Add(new Admin(userId, username, email, password, roleId, adminId, name, phone, adminRole));
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
                    //allUsers.Add(new Employee(userId, username, email, password, roleId, employeeId, name, phone, joinedDate, designationId));
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static bool AddUserToDatabase(User user)
        {
            try
            {
                //string query = $"INSERT INTO users VALUES ({user.UserId}, '{user.Username}', '{user.Email}', {user.Password}, {user.RoleId};)";
                //DatabaseHelper.Instance.Update(query);
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
