using DotNetEnv;

namespace CleanArchitecture.WebApi.Configurations;

public static class ApiConfig
{
    public static WebApplicationBuilder AddApiConfiguration(this WebApplicationBuilder builder)
    {
        if (builder == null) throw new ArgumentNullException(nameof(builder));

        // Load environment variables from .env file
        Env.Load();

        // Add environment variables to the configuration
        builder.Configuration.AddEnvironmentVariables();

        // Register services like controllers
        builder.Services.AddControllers();

        return builder;
    }
}