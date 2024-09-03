using Microsoft.Extensions.FileProviders;

namespace Quiz_Api.ExtensionMethod
{
    public static class StaticFileExtension
    {
        public static WebApplication ConfigureStaticFiles(this WebApplication app, string RootPath) 
        {
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(RootPath, "Images")),
                RequestPath = "/Images"
            });

            return app;
        }
    }
}
