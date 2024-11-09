using MyFakeDatabaseProject.Application;
using MyFakeDatabaseProject.Persistence;

namespace CleanArchitecture.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Add methods Extensions
        builder.Services.AddInjectionPersistence(builder.Configuration);
        builder.Services.AddInjectionApplication();
        
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            //swagger url http://localhost:8080/swagger/index.html
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}