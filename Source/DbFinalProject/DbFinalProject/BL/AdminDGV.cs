using DbFinalProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.BL
{
    public class AdminDGV
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string AdminStatus { get; set; }

        public AdminDGV(string username, string email, string name, string phone, string adminStatus)
        {
            Username = username;
            Email = email;
            Name = name;
            Phone = phone;
            AdminStatus = adminStatus;
        }


        public static List<AdminDGV> GetAdmins()
        {
            AdminDGV_DL.LoadAdmins();
            return AdminDGV_DL.allAdmins;
        }

    }
}
