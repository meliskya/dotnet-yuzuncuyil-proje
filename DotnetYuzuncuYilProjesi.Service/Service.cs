using DotnetYuzuncuYilProjesi.Core.Repositories;
using DotnetYuzuncuYilProjesi.Core.Services;
using DotnetYuzuncuYilProjesi.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Service
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IGenericRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public async Task<T> AddAsync(T Entity)
        {
            await _repository.AddAsync(Entity);
            await _unitOfWork.CommitAync();
            return Entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsnyc(IEnumerable<T> entities)
        {
            await _repository.AddRangeAync(entities);
            await _unitOfWork.CommitAync();
            return entities;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task Remove(T Entity)
        {
            _repository.Remove(Entity);
            await _unitOfWork.CommitAync();
        }

        public async Task RemoveRangAsnyc(IEnumerable<T> entities)
        {
            _repository.RemoveRange(entities);
            await _unitOfWork.CommitAync();
        }

        public async Task UpdateAsync(T Entity)
        {
            _repository.Update(Entity);
            await _unitOfWork.CommitAync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
