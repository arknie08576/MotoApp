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

        protected readonly List<T> _items = new();

        public void Add(T employee)
        {

            employee.Id = _items.Count + 1;
            _items.Add(employee);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Save()
        {
            foreach (var emp in _items)
            {
                Console.WriteLine(emp);
            }

        }
        public T GetById(int id)
        {
            return _items.Single(item=>item.Id==id);
        }

    }
}
