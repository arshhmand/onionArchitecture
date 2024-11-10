namespace CleanArchitecture.Application.Abstraction;

public interface IGenericRepository<T> where T : class
{
    /* Commands */
    Task<bool> InsertAsync(T entity);
    Task<bool> UpdateAsync(T entity);
    Task<bool> DeleteAsync(string id);
    
    /* Queries */
    Task<T> GetAsync(Guid id);
    Task<IEnumerable<T>> GetAllAsync();
}
