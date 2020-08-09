using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OnionSample.Application.Interfaces;
using OnionSample.Application.Services;
using OnionSample.Application.UseCases;
using System.Reflection;

namespace OnionSample.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IToDoItemUseCases, ToDoItemUseCases>();
            services.AddScoped<ICalendarService, CalendarService>();

            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
