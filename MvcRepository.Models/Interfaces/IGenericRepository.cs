using MvcRepository.Models.UnitOfWork;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace MvcRepository.Models.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IUnitOfWork _UnitOfWork { get; set; }

        void Create(TEntity instance);

        void Update(TEntity instance);

        void Delete(TEntity instance);

        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> GetAll();
    }
}
