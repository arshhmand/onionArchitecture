using CleanArchitecture.Application.Abstraction;

namespace CleanArchitecture.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public ICustomerRepository Customer { get; }
    public IBrandRepository Brand { get; }

    public UnitOfWork(ICustomerRepository customers, IBrandRepository brands)
    {
        Customer = customers ?? throw new ArgumentNullException(nameof(customers));
        Brand = brands ?? throw new ArgumentNullException(nameof(brands));
    }
    
    public void Dispose()
    {
        System.GC.SuppressFinalize(this);
    }
}
