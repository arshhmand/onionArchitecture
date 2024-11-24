using CleanArchitecture.Application.Abstraction;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly AppDbContext _context;
    
    public CustomerRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task InsertAsync(Customer customer)
    {
        await _context.Customers.AddAsync(customer);
        await _context.SaveChangesAsync();
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