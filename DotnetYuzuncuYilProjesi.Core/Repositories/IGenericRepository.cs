using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        //Filtreleme yapmak için expression parametresi function delege olarak tanımlanır.
        IQueryable<T> GetAll(Expression<Func<T,bool>> expression);

        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAync(IEnumerable<T> entities); //bir tür üzerinde birden fazla data ekleme 
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities); //Birden vazla metot ekleme
    }
}
