namespace CleanArchitecture.Application.Abstraction;

    public interface IUnitOfWork: IDisposable
    {
        ICustomerRepository Customer { get; }
        IBrandRepository Brand { get; }
    }
