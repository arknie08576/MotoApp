using MotoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Repositories
{
    public class GenericRepository<T> where T : IEntity
    {

        private readonly List<T> _employees = new();

        public void Add(T employee)
        {

            employee.Id = _employees.Count + 1;
            _employees.Add(employee);
        }

        public void Save()
        {
            foreach (var emp in _employees)
            {
                Console.WriteLine(emp);
            }

        }
        public T GetById(int id)
        {
            return _employees.Single(item=>item.Id==id);
        }

    }
}
