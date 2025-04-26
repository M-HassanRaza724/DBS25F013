using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement.BL
{
    public class User
    {
        protected int userId; // only userId use to be passed to child classes
        private string username;
        private string email;
        private string password;
        private string role;

        public User(int userId, string username, string email, string password, string role)
        {
            this.userId = userId;
            this.username = username;
            this.email = email;
            this.password = password;
            this.role = role;
        }


        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }


        public virtual bool Add(User user)
        {
            return UserDL.AddUserToDatabase(user);
        }


        public virtual bool Update(User user)
        {
            return UserDL.UpdateUserToDatabse(user);
        }


        public virtual bool Delete(User user)
        {
            return UserDL.DeleteUserFromDatabase(user);
        }

    }
}

