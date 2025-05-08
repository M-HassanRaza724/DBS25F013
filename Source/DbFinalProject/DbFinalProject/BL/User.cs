using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbFinalProject.DL;

namespace DbFinalProject.BL
{
    public abstract class User
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
        public User() { }

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


        public static User CheckIfUserExists(string username, string password)
        {
            User user = UserDL.allUsers
                        .Where(u => u.Username == username && u.Password == password)
                        .FirstOrDefault();
            return user;
        }


        public static bool CheckIfUserIsUnique(User newUser)
        {
            bool usernameTaken = false;
            bool passwordTaken = false;
            bool emailTaken = false;
            foreach (var user in UserDL.allUsers)
            {
                if (user.username == newUser.Username)
                {
                    usernameTaken = true;
                    break;
                }
            }
            foreach (var user in UserDL.allUsers)
            {
                if (user.Password == newUser.Password)
                {
                    passwordTaken = true;
                }
            }
            foreach (var user in UserDL.allUsers)
            {
                if (user.Email == newUser.Email)
                {
                    emailTaken = true;
                }
            }
            if (usernameTaken == true || passwordTaken == true || emailTaken == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static bool CheckIfEmailPasswordIsUnique(User currentUser, string email, string password)
        {
            bool emailTaken = false;
            bool passwordTaken = false;
            foreach (var user in UserDL.allUsers)
            {
                if (user.UserId == currentUser.userId)
                {
                    continue;
                }
                else if (user.email == email)
                {
                    emailTaken = true;
                    break;
                }
            }
            foreach (var user in UserDL.allUsers)
            {
                if (user.UserId == currentUser.userId)
                {
                    continue;
                }
                else if (user.password == password)
                {
                    passwordTaken = true;
                    break;
                }
            }
            if (emailTaken == true || passwordTaken == true)
            {
                return false;
            }
            return true;
        }
    }
}
