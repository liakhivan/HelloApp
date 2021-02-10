using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApp
{
    public class Startup
    {
        IWebHostEnvironment _env;
        public Startup(IWebHostEnvironment env)
        {
            _env = env;
        }
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           // DefaultFilesOptions options = new DefaultFilesOptions();
            //options.DefaultFileNames.Clear();
           // options.DefaultFileNames.Add("hello.html");

            //app.UseDefaultFiles(options);
            //app.UseDirectoryBrowser();
            //app.UseDirectoryBrowser(new DirectoryBrowserOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\html")), 

            //    RequestPath = new PathString("/pages")
            //});
            //app.UseStaticFiles();
            app.UseFileServer(enableDirectoryBrowsing: true);
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello world!");
            });
        }
    }
}
