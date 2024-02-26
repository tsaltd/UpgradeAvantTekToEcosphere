using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Workspace;
namespace Workspace
{
    public class Startup
    {
        [Obsolete]
        public Startup(Microsoft.Extensions.Hosting.IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostEnvironment env, ILoggerFactory loggerFactory)
        {

            /* #pragma warning disable CS0618 // Type or member is obsolete
                        loggerFactory.AddDebug();
            #pragma warning restore CS0618 // Type or member is obsolete */

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            //app.UseFileServer(enableDirectoryBrowsing: true);
            //app.UseDirectoryBrowser();


            app.UseRouting();
                
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                   pattern: "{controller=EcoSphere}/{action=ModernWeb}/{id?}");
                 //  pattern: "{controller=Home}/{action=Defaultx}/{id?}");
        });
        }

        private void AddConsole(Startup startup, ILoggingBuilder loggingBuilder, object builder)
        {
            throw new NotImplementedException();
        }
    }
}
