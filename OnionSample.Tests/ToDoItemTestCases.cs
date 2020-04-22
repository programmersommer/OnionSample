using System;
using Xunit;
using OnionSample.Tests.Stubs;
using OnionSample.Application.Services;
using OnionSample.Application.UseCases;


namespace OnionSample.Tests
{
    public class ToDoItemTestCases
    {

        [Fact]
        public void AddToDoItem()
        {
            var persistenceStub = new ToDoItemPersistenceService();
            var calendarService = new CalendarService();
            var useCase = new AddToDoItemUseCase(calendarService, persistenceStub);
            var result = useCase.AddToDoItem(DateTime.Now, "test todo");

            Assert.True(result);
        }
    }
}
