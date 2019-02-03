using Exxat.SupportPro.API.Models;
using Exxat.SupportPro.API.Repositories;
using Exxat.SupportPro.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddScoped<IQueryRepository, QueryRepository>();

            var connectionString = new ConnectionSettings();
            Configuration.Bind("ConnectionString", connectionString.ConnectionString);
            services.AddSingleton(connectionString);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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
