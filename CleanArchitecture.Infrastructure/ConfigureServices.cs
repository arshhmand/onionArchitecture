using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyFakeDatabaseProject.Abstraction;
using MyFakeDatabaseProject.Models;
using MyFakeDatabaseProject.Persistence.Repositories;

namespace MyFakeDatabaseProject.Persistence;

public static class ConfigureServices
{
    public static IServiceCollection AddInjectionPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
     
        return services;
    }
}
