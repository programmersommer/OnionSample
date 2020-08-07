using OnionSample.Application.Interfaces;
using OnionSample.Core.Entities;
using System;
using System.Collections.Generic;

namespace OnionSample.Application.UseCases
{
    public class ToDoItemUseCases : IToDoItemUseCases
    {
        private readonly ICalendarService _calendarService;
        private readonly IToDoItemPersistenceService _toDoItemService;

        public ToDoItemUseCases(ICalendarService calendarService, IToDoItemPersistenceService toDoItemService)
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

        public IEnumerable<ToDoItem> GetToDoItems()
        {
            return _toDoItemService.GetToDoItems();
        }
    }
}
