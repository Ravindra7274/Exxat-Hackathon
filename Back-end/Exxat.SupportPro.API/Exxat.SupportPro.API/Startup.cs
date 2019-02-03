using Exxat.SupportPro.API.Models;
using Exxat.SupportPro.API.Repositories;
using Exxat.SupportPro.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Exxat.SupportPro.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ModelContext.ModelContext>(options => options.UseSqlServer("Data Source = Db-Server; Initial Catalog = SupportProDb; User id = developer; Password = developer123; MultipleActiveResultSets = true")); //code to connect sql server i.e to call connection string 

            services.AddScoped<ModelContext.ModelContext>();
            services.AddScoped<IModuleService, ModuleService>();
            services.AddScoped<IQueryService, QueryService>();
            services.AddScoped<IQueryRepository, QueryRepository>();

            var connectionString = new ConnectionSettings();
            Configuration.Bind("ConnectionString", connectionString.ConnectionString);
            services.AddSingleton(connectionString);

            var corsSettings = new List<string>();
            Configuration.Bind("CorsURLs", corsSettings);
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .WithOrigins(corsSettings.ToArray()) //Note:  The URL must be specified without a trailing slash (/).
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var corsSettings = new List<string>();
            Configuration.Bind("CorsURLs", corsSettings);
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                builder => builder
                .WithOrigins(corsSettings.ToArray()) //Note: The URL must be specified without a trailing slash (/).
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
