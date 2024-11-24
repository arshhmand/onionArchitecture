using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure;

public partial class AppDbContext: DbContext
{
    public DbSet<Customer> Customers { get; set; }
    
    private const string ConnectionString = "Server=localhost,1433;Database=PrimeDB;User=sa;Password=yourStrong(!)Password;TrustServerCertificate=True;";

    public AppDbContext (DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Apply all configurations in the current assembly
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
