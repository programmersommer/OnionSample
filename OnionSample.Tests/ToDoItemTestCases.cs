using OnionSample.Application.Services;
using OnionSample.Application.UseCases;
using OnionSample.Tests.Stubs;
using System;
using Xunit;


namespace OnionSample.Tests
{
    public class ToDoItemTestCases
    {

        [Fact]
        public void AddToDoItem()
        {
            var persistenceStub = new ToDoItemPersistenceService();
            var calendarService = new CalendarService();
            var useCase = new ToDoItemUseCases(calendarService, persistenceStub);
            var result = useCase.AddToDoItem(DateTime.Now, "test todo");

            Assert.True(result);
        }
    }
}
