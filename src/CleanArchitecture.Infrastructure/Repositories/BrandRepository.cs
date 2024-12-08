using CleanArchitecture.Application.Abstraction;
using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories;

public class BrandRepository : IBrandRepository
{
    private readonly AppDbContext _context;

    public BrandRepository(AppDbContext context)
    {
        _context = context;
    }
    public Task InsertAsync(Brand entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Brand entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Brand> GetAsync(Guid id)
    {
        var brands =  _context.Brand;
        return  brands.Where(b => b.Id == id).FirstOrDefaultAsync();
    }

    public Task<IEnumerable<Brand>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}