using Microsoft.Extensions.DependencyInjection;
using OnionSample.Application;
using OnionSample.Application.Interfaces;
using OnionSample.Infrastructure;
using System;
using System.Threading.Tasks;
using Xunit;

namespace OnionSample.Tests
{
    public class ToDoItemTestCases
    {
        private ServiceProvider serviceProvider { get; set; }

        [Fact]
        public async Task AddToDoItem()
        {
            var services = new ServiceCollection();

            services.RegisterApplicationServices();
            services.RegisterInfrastructureServices();

            serviceProvider = services.BuildServiceProvider();

            var useCase = serviceProvider.GetService<IAddToDoItemUseCase>();
            var result = await useCase.AddToDoItemAsync(DateTime.Now, "test todo");

            Assert.True(result);
        }
    }
}
