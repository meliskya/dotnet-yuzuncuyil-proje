﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T Entity);
        Task<IEnumerable<T>> AddRangeAsnyc(IEnumerable<T> entities);
        Task UpdateAsync(T Entity);
        Task RemoveAsync(T Entity);
        Task RemoveRangAsnyc(IEnumerable<T> entities);

    }
}
