using MvcRepository.Models.Interfaces;
using MvcRepository.Models.UnitOfWork;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MvcRepository.Models.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public IUnitOfWork _UnitOfWork { get; set; }

        private AppDbContext Context { get; set; }

        private DbSet<TEntity> DbSet { get; set; }

        public GenericRepository(IUnitOfWork unitofwork)
        {
            this._UnitOfWork = unitofwork;
            this.Context = unitofwork.Context;
            this.DbSet = this.Context.Set<TEntity>();
        }


        /// <summary>
        /// Creates the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <exception cref="System.ArgumentNullException">instance</exception>
        public void Create(TEntity instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }

            this.DbSet.Add(instance);
        }

        /// <summary>
        /// Updates the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Update(TEntity instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }

            this.Context.Entry(instance).State = EntityState.Modified;
        }

        /// <summary>
        /// Deletes the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Delete(TEntity instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }

            this.Context.Entry(instance).State = EntityState.Deleted;
        }

        /// <summary>
        /// Gets the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return this.DbSet.FirstOrDefault(predicate);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }
    }
}
