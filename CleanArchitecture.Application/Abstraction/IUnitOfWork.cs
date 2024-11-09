namespace MyFakeDatabaseProject.Abstraction;

    public interface IUnitOfWork: IDisposable
    {
        ICustomerRepository Customers { get; }
    }
