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
        private Employee employee;
        private DateTime date;
        private double amount;
        private double bonus;

        public int SalaryId
        {
            get {  return salaryId; }
            set { salaryId = value; }
        }
        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
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
        public string EmployeeName
        {
            get { return Employee?.Name; }
        }


        public Salary() { }


        public Salary(int salaryId, int employeeId, DateTime date, double amount, double bonus)
        {
            this.salaryId = salaryId;
            this.employee = new Employee();
            this.employee.EmployeeId = employeeId;
            this.date = date;
            this.amount = amount;
            this.bonus = bonus;
        }

        public Salary(int salaryId, Employee employee, DateTime date, double amount, double bonus)
        {
            this.salaryId = salaryId;
            this.employee = employee;
            this.date = date;
            this.amount = amount;
            this.bonus = bonus;
        }


        public Salary(int employeeId, DateTime date, double amount, double bonus)
        {
            this.employee = new Employee();
            this.employee.EmployeeId = employeeId;
            this.date = date;
            this.amount = amount;
            this.bonus = bonus;
        }
        public Salary(Employee employee, DateTime date, double amount, double bonus)
        {
            this.employee = employee;
            this.date = date;
            this.amount = amount;
            this.bonus = bonus;
        }
        public static List<Salary> GetSalarysByFilter(string search = null, string sortby = null, string direction = "ASC" ,int empId = -1)
        {
            List<Salary> filtered;
            
            if(Program.CurrentUser is Employee emp)
            {
                filtered = SalaryDL.allSalaries
                                .OfType<Salary>()
                                .Where(salary => (salary.Employee.EmployeeId == empId))
                                .ToList();
            }
            else
            {
                filtered = SalaryDL.allSalaries;
            }

            if (search == null && sortby == null)
            {
                return filtered
                            .OfType<Salary>()
                            .OrderByDescending(l => l.Date)
                            .ToList();
            }
            if (search != null)
            {
                filtered = filtered
                                .OfType<Salary>()
                                .Where(salary => (salary.Employee.Name.Contains(search)))
                                .ToList();
            }
            if (sortby != null)
            {


                if (direction == "DESC" && sortby == "date")
                {
                    filtered = filtered
                               .OrderByDescending(l => l.Date)
                               .ToList();
                }
                else if (sortby == "customerName")
                {
                    filtered = filtered
                               .OrderBy(l => l.Date)
                               .ToList();
                }
                else if (direction == "DESC" && sortby == "amount")
                {
                    filtered = filtered
                               .OrderByDescending(l => l.Amount)
                               .ToList();
                }
                else if (sortby == "serviceName")
                {
                    filtered = filtered
                               .OrderBy(l => l.Amount)
                               .ToList();
                }
            }
            return filtered;
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
