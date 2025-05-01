using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement.BL
{
    public abstract class User // abstraction
    {
        protected int userId; // only userId use to be passed to child classes
        protected string username;
        protected string email;
        protected string password;
        private int roleId;
        private string role;

        public User(int userId, string username, string email, string password, int roleId)
        {
            this.userId = userId;
            this.username = username;
            this.email = email;
            this.password = password;
            this.roleId = roleId;
        }
        public User(string username, string email, string password, int roleId)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.roleId = roleId;
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
        public int RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }


        public abstract bool Add(User user);
        public abstract bool Update(User user);
        public abstract bool Delete(User user);

    }
}

