using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.BL
{
    public interface ISalary
    {
        Salary GetSalary();
        bool SetSalary(int salaryId, DateTime date, double amount, double bonus);
        bool SetSalary(DateTime date, double amount, double bonus);
        bool SetSalaryToDb(DateTime date, double amount, double bonus);
        bool UpdateSalary(DateTime payDate, double amount, double bonus);
        bool DeleteSalary();

    }
}
