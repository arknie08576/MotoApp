﻿using MotoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Repositories.Extensions
{
    public static class RepositoryExtensions
    {
        public static void AddBatch<T>(this IRepository<T> employeeRepository, T[] items) where T : class, IEntity
        {
            foreach (var item in items)
            {
                employeeRepository.Add(item);

            }
            employeeRepository.Save();
        }
    }
}
