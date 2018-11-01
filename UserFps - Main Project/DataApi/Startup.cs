using DataApi.Interfaces;
using DataApi.Models;
using DataApi.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Enable Cross-Origin Requests (CORS) service.
            // the api and example project are separate entities
            // therefore they reside in different domains which requires this service
            services.AddCors(options =>
            {
                options.AddPolicy("AllowThisOrigin",
                    builder => builder.WithOrigins("https://localhost:44362")
                        .WithMethods("POST")
                        .WithHeaders("content-type"));
            });

            services.AddMvc();

            services.AddScoped<IVendorRepository, VendorRepository>();

            // dbcontext service to add connection string to project
            services.AddDbContext<ProjectDBContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("DataApiContextConnection")));
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

            // Enabling CORS
            app.UseCors("AllowThisOrigin");

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
