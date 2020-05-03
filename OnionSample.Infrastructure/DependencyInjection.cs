using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OnionSample.Application.Interfaces;
using OnionSample.Infrastructure.Persistence.Services;
using System.Reflection;

namespace OnionSample.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IToDoItemPersistenceService, ToDoItemPersistenceService>();
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
