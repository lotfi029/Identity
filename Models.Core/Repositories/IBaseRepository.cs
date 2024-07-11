﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Core.Repositories
{
    public interface IBaseRepository <T> where T : class
    {
        Task<T> GetById(string Id);
        Task<T> GetByName(string Name);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
