using System;
using OnionSample.Core.Entities;
using OnionSample.Application.Interfaces;


namespace OnionSample.Application.UseCases
{
    public class AddToDoItemUseCase : IAddToDoItemUseCase
    {
        private readonly ICalendarService _calendarService;
        private readonly IToDoItemPersistenceService _toDoItemService;

        public AddToDoItemUseCase(ICalendarService calendarService, IToDoItemPersistenceService toDoItemService)
        {
            _calendarService = calendarService;
            _toDoItemService = toDoItemService;
        }

        public bool AddToDoItem(DateTime dateTime, string description)
        {
            var timeAvailable = _calendarService.DateTimeIsAvailable(dateTime);
            if (!timeAvailable) return false;

            _toDoItemService.Save(new ToDoItem()
            {
                EventDateTime = dateTime,
                Description = description
            });

            return true;
        }

    }
}
