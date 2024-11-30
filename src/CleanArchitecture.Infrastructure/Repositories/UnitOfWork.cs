using CleanArchitecture.Application.Abstraction;

namespace CleanArchitecture.Infrastructure.Repositories;

internal class UnitOfWork : IUnitOfWork
{
    public ICustomerRepository Customers { get; }
    public IBrandRepository Brands { get; }

    public UnitOfWork(ICustomerRepository customers, IBrandRepository brands)
    {
        Customers = customers ?? throw new ArgumentNullException(nameof(customers));
        Brands = brands ?? throw new ArgumentNullException(nameof(brands));
    }
    
    public void Dispose()
    {
        System.GC.SuppressFinalize(this);
    }
}
