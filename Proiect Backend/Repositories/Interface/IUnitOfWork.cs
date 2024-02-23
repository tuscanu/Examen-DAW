using Proiect_Backend.Repositories.Interface;
using System;
using System.Threading.Tasks;

namespace Proiect_Backend.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }
        IUserRepository Users { get; }

        Task<int> CompleteAsync();
    }
}
