using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFirmManagement.BL
{
    public class EmployeeAssignationDTO
    {
        int assignationId;
        List<Employee> employees;
        OrderDTO order;
        public List<Employee> Employees { get { return employees; } set { employees = value; } }
        public int AssignationId { get { return assignationId; } set { assignationId = value; } }
        public OrderDTO Order { get { return order; } set { order = value; } }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public EmployeeAssignationDTO(List<Employee> employees, OrderDTO order)
        {
            Employees = employees;
            Order = order;
        }
        public EmployeeAssignationDTO( OrderDTO order)
        {
            Order = order;
            Employees = new List<Employee>();
        }
        public EmployeeAssignationDTO(int assignationId , List<Employee> employees, OrderDTO order)
        {
            Employees = employees;
            Order = order;
            this.assignationId = assignationId;
        }
        public EmployeeAssignationDTO(int assignationId , OrderDTO order)
        {
            Order = order;
            Employees = new List<Employee>();
            this.assignationId = assignationId;
        }
    }
}
