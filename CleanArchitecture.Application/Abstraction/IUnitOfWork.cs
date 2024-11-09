namespace CleanArchitecture.Application.Abstraction;

    public interface IUnitOfWork: IDisposable
    {
        ICustomerRepository Customers { get; }
    }
