using Microsoft.EntityFrameworkCore;
using Quiz_Api.Models;

namespace Quiz_Api.ExtensionMethod
{
    public static class AppConfigExtension
    {
        public static WebApplication ConfigureCORS(this WebApplication app, IConfiguration configuration)
        {
            app.UseCors(options =>
            options.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod());

            return app;
        }

        public static IServiceCollection AddAppConfig(this IServiceCollection services, IConfiguration configuration)
        {
            var databaseType = configuration["DatabaseType"];
            if (databaseType == "InMemory")
            {
                services.AddDbContext<QuizDbContext>(options =>
                    options.UseInMemoryDatabase("InMemoryDb"));
            }
            else if (databaseType == "Sql")
            {
                services.AddDbContext<QuizDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DevConnection")));
            }
            return services;    
        }
    }
}
