using CleanArchitecture.Application.Abstraction;

namespace CleanArchitecture.Infrastructure.Repositories;

internal class UnitOfWork : IUnitOfWork
{
    public ICustomerRepository Customers { get; }
    
    public UnitOfWork(ICustomerRepository customers)
    {
        Customers = customers ?? throw new ArgumentNullException(nameof(customers));
    }
    
    public void Dispose()
    {
        System.GC.SuppressFinalize(this);
    }
}
