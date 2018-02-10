using System;

namespace MvcRepository.Models.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        AppDbContext Context { get; }

        int SaveChange();
    }
}
