
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Quiz_Api.Models;

namespace Quiz_Api
{
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
            builder.Services.AddCors();
            builder.Services.AddDbContext<QuizDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseCors(options => 
            options.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod());


            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider=new PhysicalFileProvider(
                    Path.Combine(builder.Environment.ContentRootPath,"Images")),
                RequestPath="/Images"
            });
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
