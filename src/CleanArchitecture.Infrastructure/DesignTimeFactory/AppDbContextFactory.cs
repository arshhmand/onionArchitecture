using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CleanArchitecture.Infrastructure.DesignTimeFactory;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
    //TODO Add connection string to the env file
        const string connectionString =
            "Server=host.docker.internal,1433;Database=PrimeDB;User=sa;Password=yourStrong(!)Password;TrustServerCertificate=True;";

        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("Connection string is not set in the environment variables.");
        }

        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer(connectionString);
        
        return new AppDbContext(optionsBuilder.Options);
        
    }
}
