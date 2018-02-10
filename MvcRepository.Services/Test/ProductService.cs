using MvcRepository.Models.Entities.Test;
using MvcRepository.Models.Interfaces;
using MvcRepository.Services.Test.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcRepository.Services.Test
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _repository;

        public ProductService(IGenericRepository<Product> repository)
        {
            this._repository = repository;
        }

        public void Create(Product instance)
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

        public void Update(Product instance)
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
            return this._repository.GetAll().Any(x => x.ProductId == instanceId);
        }

        public Product GetByID(int instanceId)
        {
            return this._repository.Get(x => x.ProductId == instanceId);
        }

        public IQueryable<Product> GetAll()
        {
            return this._repository.GetAll();
        }
    }
}
