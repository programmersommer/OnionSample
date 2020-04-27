using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnionSample.Application.Interfaces;
using OnionSample.Application.Services;
using OnionSample.Application.UseCases;
using OnionSample.Infrastructure.Persistence.Services;

namespace OnionSample.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Application services and use cases
            // We can use Application services directly but better use container for this
            services.AddScoped<IAddToDoItemUseCase, AddToDoItemUseCase>();
            services.AddScoped<ICalendarService, CalendarService>();

            // Infrastructure services
            // Reference to Infrastructure is needed only to add service into DI container
            // Infrastructure and UI are still independent in Control Flow 
            // If you check diagram that describes Onion architecture, then there would be no reference to Infrastructure from UI
            // Do not use this service from UI directly!
			// It is possible to use Mediator pattern (MediatR package) for DI between Infrastructure and Application
            services.AddScoped<IToDoItemPersistenceService, ToDoItemPersistenceService>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
