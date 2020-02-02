using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            this._employeeList = new List<Employee>() // generate hard-coded data
            {
                new Employee(){Id = 1, Name="Mohammad", Email = "mqaderi44@gmail.com", Department= Dept.HR},
                new Employee(){Id = 2, Name="Ahmad", Email = "ahmad@gmail.com", Department= Dept.Payroll},
                new Employee(){Id = 3, Name="Ali", Email = "ali@gmail.com", Department= Dept.IT}

            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id + 1);
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }

        public Employee Delete(int Id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == Id);
            if(employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }
    }
}
