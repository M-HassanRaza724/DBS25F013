using DbFinalProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.BL
{
    public class EmployeeDGV
    {
        public string Username { get; set; }
        public string EmployeeName { get; set; }
        public string Phone { get; set; }
        public DateTime JoinedDate { get; set; }
        public string Designation { get; set; }
        public int OrdersCompleted { get; set; }

        public EmployeeDGV(string username, string employeeName, string phone, DateTime joinedDate, string designation, int ordersCompleted)
        {
            Username = username;
            EmployeeName = employeeName;
            Phone = phone;
            JoinedDate = joinedDate;
            Designation = designation;
            OrdersCompleted = ordersCompleted;
        }


        public static List<EmployeeDGV> GetAllEmployees()
        {
            EmployeeDGV_DL.LoadEmployees();
            return EmployeeDGV_DL.allEmployees;
        }

    }
}
