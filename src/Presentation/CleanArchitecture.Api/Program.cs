using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure;

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

        // Add methods Extensions
        builder.Services.AddInjectionPersistence(builder.Configuration);
        builder.Services.AddInjectionApplication();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            //swagger url http://localhost:8080/swagger/index.html
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseAuthorization();

        app.Run();
    }
}