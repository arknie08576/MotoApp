﻿using Microsoft.EntityFrameworkCore;
using MotoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Repositories
{
    public class SqlRepository
    {

        private readonly DbSet<Employee> _dbSet;
        private readonly DbContext _dbContext;

        public SqlRepository(DbContext dbContex)
        {

            _dbContext = dbContex;
            _dbSet = _dbContext.Set<Employee>();
        }

        public Employee GetById(int id)
        {

            return _dbSet.Find(id);

        }


        public void Add(Employee item)
        {

            _dbSet.Add(item);
        }

        public void Remove(Employee item)
        {

            _dbSet.Remove(item);
        }

        public void Save()
        {
            _dbContext.SaveChanges();


        }

    }
}
