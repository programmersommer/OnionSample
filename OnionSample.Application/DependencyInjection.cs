using Microsoft.Extensions.DependencyInjection;
using OnionSample.Application.Interfaces;
using OnionSample.Application.Services;
using OnionSample.Application.UseCases;

namespace OnionSample.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAddToDoItemUseCase, AddToDoItemUseCase>();
            services.AddScoped<ICalendarService, CalendarService>();

            return services;
        }
    }
}
