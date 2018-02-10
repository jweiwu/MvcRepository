using MvcRepository.Models.UnitOfWork;
using System.Web.Mvc;

namespace MvcRepository.Web.Filters
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private IUnitOfWork _unitOfWork;

        public IUnitOfWork Create()
        {
            if (this._unitOfWork != null)
            {
                return this._unitOfWork;
            }
            this._unitOfWork = DependencyResolver.Current.GetService<IUnitOfWork>();
            return this._unitOfWork;
        }
    }
}