using Microsoft.EntityFrameworkCore;
using MotoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Repositories
{

    //public delegate void ItemAdded<T>(T item);
    public class SqlRepository<T> : IRepository<T> where T : class, IEntity, new()
    {

        private readonly DbSet<T> _dbSet;
        private readonly DbContext _dbContext;
        private readonly Action<T>? _itemAddedCallback;
        public event EventHandler<T>? ItemAdded;
        public SqlRepository(DbContext dbContex, Action<T>? itemAddedCallback=null)
        {

            _dbContext = dbContex;
            _dbSet = _dbContext.Set<T>();
            _itemAddedCallback = itemAddedCallback;
            
        }

        public T GetById(int id)
        {

            return _dbSet.Find(id);

        }


        public void Add(T item)
        {

            _dbSet.Add(item);
            _itemAddedCallback?.Invoke(item);
            ItemAdded?.Invoke(this, item);
        }

        public void Remove(T item)
        {

            _dbSet.Remove(item);
        }

        public void Save()
        {
            _dbContext.SaveChanges();


        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
