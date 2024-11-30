using CleanArchitecture.Application.Abstraction;
using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInjectionPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        const string connectionString =
            "Server=host.docker.internal,1433;Database=PrimeDB;User=sa;Password=yourStrong(!)Password;TrustServerCertificate=True;";
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IBrandRepository, BrandRepository>();
        
      return services;
    }
}
