using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbFinalProject.DL;

namespace DbFinalProject.BL
{
    public class Admin : User
    {
        private int adminId;
        private string name;
        private string phone;
        private int adminRole;

        public Admin(int userId, string username, string email, string password, int role, int adminId, string name, string phone, int adminRole) : base(userId, username, email, password, role)
        {
            this.adminId = adminId;
            this.name = name;
            this.phone = phone;
            this.adminRole = adminRole;
        }


        public Admin(int userId, string username, string email, string password, int role, string name, string phone, int adminRole) : base(userId, username, email, password, role)
        {
            this.name = name;
            this.phone = phone;
            this.adminRole = adminRole;
        }


        public int AdminId
        {
            get { return adminId; }
            set { adminId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public int AdminRole
        {
            get { return adminRole; }
            set { adminRole = value; }
        }

        public override bool Add(User user)
        {
            try
            {
                if (user is Admin) // type checking
                {
                    Admin admin = (Admin)user; // type casting
                    bool userAdded = UserDL.AddUserToDatabase(user); // first user is added
                    if (!userAdded)
                    {
                        return false;
                    }
                    List<Admin> onlyUsers = AdminDL.GetOnlyUsersFromDatabase();
                    int userId = onlyUsers
                                 .Where(u => u.Username == user.Username)
                                 .Select(u => u.UserId)
                                 .FirstOrDefault();
                    admin.UserId = userId;
                    bool status = AdminDL.AddAdminToDatabase(admin);
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
                if (user is Admin admin) // type casting and checking in a single line
                {
                    bool userUpdated = UserDL.UpdateUserToDatabse(user);
                    if (!userUpdated)
                    {
                        return false;
                    }
                    bool status = AdminDL.UpdateAdminToDatabase(admin);
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
                if (user is Admin admin)
                {
                    bool adminDeleted = AdminDL.DeleteAdminFromDatabase(admin); // first, admin is deleted
                    if (!adminDeleted)
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

    }
}
