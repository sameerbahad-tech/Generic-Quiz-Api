
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Quiz_Api.ExtensionMethod;
using Quiz_Api.Models;
using System.Configuration;

namespace Quiz_Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            SwaggerExtensions.AddSwaggerExplorer(builder.Services);
            builder.Services.AddCors();
            
            AppConfigExtension.AddAppConfig(builder.Services, builder.Configuration);

            var app = builder.Build();

            AppConfigExtension.ConfigureCORS(app,builder.Configuration);
            

            app.SeedInMemoryDatabase(builder.Configuration);
            StaticFileExtension.ConfigureStaticFiles(app, builder.Environment.ContentRootPath);
            SwaggerExtensions.ConfigureSwaggerExplorer(app);
            
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
