using SoftwareFirmManagement.BL;
using System;
using System.Collections.Generic;

namespace SoftwareFirmManagement.DL
{
    class EmployeeAssignationDL
    {

        //public static List<EmployeeAssignationDTO> employeeAssignations = new List<EmployeeAssignationDTO>();


        public static EmployeeAssignationDTO GetAssignations(int orderId)
        {
            string query = $"SELECT assign_id, employee_id, name, order_id FROM employee_assignation natural join employees where order_id = {orderId}";
            var data = DatabaseHelper.Instance.GetData(query);
            List<Employee> employees = new List<Employee>();
            while (data.Read())
            {
                int employeeId = data.GetInt32(1);
                string employeeName = data.GetString(2);
                Employee employee = EmployeeDL.GetEmployeeById(employeeId);
                //{
                //    Name = employeeName,
                //    EmployeeId = employeeId,
                //};
                employees.Add(employee);
            }
            EmployeeAssignationDTO employeeAssignation = new EmployeeAssignationDTO(employees, OrderDL.GetOrderById(orderId));
            return employeeAssignation;

        }
        public static bool AddAsssignation(int orderId, int employeeId)
        {
            try
            {
                string query = $"INSERT INTO `finalprojectdb`.`employee_assignation` (`employee_id`, `order_id`) VALUES ({employeeId}, {orderId});";
                DatabaseHelper.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteAssignation(int orderId, int employeeId)
        {
            try
            {

                string query = $"DELETE FROM `finalprojectdb`.`employee_assignation` WHERE  (`employee_id`, `order_id`) = ({employeeId}, {orderId});";
                DatabaseHelper.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
