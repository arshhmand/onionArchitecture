using MyFakeDatabaseProject.Abstraction;
using MyFakeDatabaseProject.Models;

namespace MyFakeDatabaseProject.Persistence.Repositories;

public class CustomerRepository : ICustomerRepository
{

    public Task<bool> InsertAsync(Customer entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Customer entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Customer>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Customer>> GetAllWithPaginationAsync(int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }
}