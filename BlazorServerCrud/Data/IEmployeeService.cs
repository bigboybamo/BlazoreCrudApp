using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCrud.Data
{

    interface IEmployeeService
    {

        List<Employee> GetEmployees();

        Employee GetEmployee(Guid id);

        void updateemployee(Employee employee);
        void AddEmployee(Employee employee);

        void DeleteEmployee(Guid id);
    }
}
