using SoftwareFirmManagement.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFirmManagement.BL
{
    public class Admin : User
    {
        private int adminId;
        private string name;
        private string phone;
        private string adminRole;

        public Admin(int userId, string username, string email, string password, string role, int adminId, string name, string phone, string adminRole) : base(userId, username, email, password, role)
        {
            this.adminId = adminId;
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

        public string AdminRole
        {
            get { return adminRole; }
            set { adminRole = value; }
        }

        public override bool Add(User user)
        {
            if (user is Admin) // type checking
            {
                Admin admin = (Admin)user; // type casting
                bool userAdded = UserDL.AddUserToDatabase(user); // first user is added
                if (!userAdded)
                {
                    return false;
                }
                return AdminDL.AddAdminToDatabase(admin);
            }
            return false;
        }


        public override bool Update(User user)
        {
            if (user is Admin admin) // type casting and checking in a single line
            {
                bool userUpdated = UserDL.UpdateUserToDatabse(user);
                if (!userUpdated)
                {
                    return false;
                }
                return AdminDL.UpdateAdminToDatabase(admin);
            }
            return false;
        }


        public override bool Delete(User user)
        {
            if (user is Admin admin)
            {
                bool adminDeleted = AdminDL.DeleteAdminFromDatabase(admin); // first, admin is deleted
                if (!adminDeleted)
                {
                    return false;
                }
                return UserDL.DeleteUserFromDatabase(user);
            }
            return false;
        }

    }
}

