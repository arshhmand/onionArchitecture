using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.Abstraction;

    public interface ICustomerRepository: IGenericRepository<Customer>
    {
        Task<int> CountAsync();
        Task<IEnumerable<Customer>> GetAllWithPaginationAsync(int pageNumber, int pageSize);
    }
    