using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.Swagger.Model;

namespace Mappi
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
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

            services.AddSwaggerGen();

            // Add the detail information for the API.
            services.ConfigureSwaggerGen(options =>
            {
                options.SingleApiVersion(new Info
                {
                    Version = "v1",
                    Title = "Mappi API",
                    Description = "",
                    TermsOfService = "",
                    Contact = new Contact { Name = "Henrik Bergqvist", Email = "mail@henrikbergqvist.com", Url = "https://github.com/hbbq/Mappi" },
                });

                //Determine base path for the application.
                var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var commentsFileName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".XML";
                var commentsFile = System.IO.Path.Combine(baseDirectory, commentsFileName);
                
                //Set the comments path for the swagger json and ui.
                options.IncludeXmlComments(commentsFile);
            });

            services.AddCors(options =>
                options.AddPolicy("AllAllowed", builder =>
                    builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()
                )
            );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUi();           

        }
    }
}
