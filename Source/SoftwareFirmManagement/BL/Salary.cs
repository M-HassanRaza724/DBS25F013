using Google.Protobuf.WellKnownTypes;
using SoftwareFirmManagement.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFirmManagement.BL
{
    public class Salary
    {
        private int salaryId;
        private int employeeId;
        private DateTime date;
        private double amount;
        private double bonus;

        public int SalaryId
        {
            get {  return salaryId; }
            set { salaryId = value; }
        }
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }


        public Salary() { }


        public Salary(int salaryId, int employeeId, DateTime date, double amount, double bonus)
        {
            this.salaryId = salaryId;
            this.employeeId = employeeId;
            this.date = date;
            this.amount = amount;
            this.bonus = bonus;
        }


        public Salary(int employeeId, DateTime date, double amount, double bonus)
        {
            this.employeeId = employeeId;
            this.date = date;
            this.amount = amount;
            this.bonus = bonus;
        }


        public bool Add()
        {
            try
            {
                return SalaryDL.AddSalaryToDatabase(this);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public bool Update()
        {
            try
            {
                return SalaryDL.UpdateSalaryToDatabase(this);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public bool Delete()
        {
            try
            {
                return SalaryDL.DeleteSalaryFromDatabase(this);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
