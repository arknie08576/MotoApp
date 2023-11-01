using MotoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Repositories
{
    public class EmployeeRepository
    {

        private readonly List<Employee> _employees = new();

        public void Add(Employee employee)
        {

            employee.Id = _employees.Count + 1;
            _employees.Add(employee);
        }

        public void Save()
        {
            foreach (Employee emp in _employees)
            {
                Console.WriteLine(emp);
            }

        }
        public Employee GetById(int id)
        {
            return _employees.Single(item=>item.Id==id);
        }

    }
}
