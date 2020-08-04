using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionSample.Application.Interfaces;
using OnionSample.Infrastructure.Persistence.Services;

namespace OnionSample.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IToDoItemPersistenceService, ToDoItemPersistenceService>();

            services.AddDbContext<ToDoContext>(options => options.UseSqlite(configuration.GetConnectionString("ToDoDatabase")));

            return services;
        }
    }
}
