using DbFinalProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.BL
{
    public class CustomerDGV
    {
        public string CustomerName { get; set; }
        public string Email {  get; set; }
        public int OrdersBooked { get; set; }
        public double TotalSpending { get; set; }
        public double AverageRating { get; set; }

        public CustomerDGV(string customerName, string email, int ordersBooked, double totalSpending, double averageRating)
        {
            CustomerName = customerName;
            Email = email;
            OrdersBooked = ordersBooked;
            TotalSpending = totalSpending;
            AverageRating = averageRating;
        }
        

        public static List<CustomerDGV> GetAllCustomers()
        {
            CustomerDGV_DL.LoadCustomers();
            return CustomerDGV_DL.customersForDGV;
        }
    }
}
