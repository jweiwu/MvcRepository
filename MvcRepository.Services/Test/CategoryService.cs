using MvcRepository.Models.Entities.Test;
using MvcRepository.Models.Interfaces;
using MvcRepository.Services.Test.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcRepository.Services.Test
{
    public class CategoryService : ICategoryService
    {
        private readonly IGenericRepository<Category> _repository;

        public CategoryService(IGenericRepository<Category> repository)
        {
            this._repository = repository;
        }

        public void Create(Category instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException();
            }
            
            try
            {
                this._repository.Create(instance);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Category instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException();
            }
            
            try
            {
                this._repository.Update(instance);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int instanceId)
        {
            if (!this.IsExists(instanceId))
            {
                throw new KeyNotFoundException();
            }

            try
            {
                var instance = this.GetByID(instanceId);
                this._repository.Delete(instance);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsExists(int instanceId)
        {
            return this._repository.GetAll().Any(x => x.CategoryId == instanceId);
        }

        public Category GetByID(int instanceId)
        {
            return this._repository.Get(x => x.CategoryId == instanceId);
        }

        public IQueryable<Category> GetAll()
        {
            return this._repository.GetAll();
        }
    }
}
