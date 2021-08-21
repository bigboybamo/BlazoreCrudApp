using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCrud.Data
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>
    {
        new Employee
        {
            Id = Guid.NewGuid(),
            Name = "Olabamiji"
        },
         new Employee
        {
            Id = Guid.NewGuid(),
            Name = "Paul"
        }
    };

        public void AddEmployee(Employee employee)
        {
            var id = Guid.NewGuid();
            employee.Id = id;
            employees.Add(employee);
        }

        public void DeleteEmployee(Guid id)
        {
            var employee = GetEmployee(id);
            employees.Remove(employee);
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void updateemployee(Employee employee)
        {
            var getEmployee = GetEmployee(employee.Id);
            getEmployee.Name = employee.Name;
        }
    }
}
