using System.Linq;

namespace MvcRepository.Services.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        void Create(TEntity instance);

        void Update(TEntity instance);

        void Delete(int instanceId);

        bool IsExists(int instanceId);
        
        TEntity GetByID(int instanceId);

        IQueryable<TEntity> GetAll();
    }
}
