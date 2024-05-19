using MediatR;
using OnionSample.Application.Commands;
using OnionSample.Application.Interfaces;
using OnionSample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace OnionSample.Application.UseCases
{
    public class ToDoItemUseCases : IToDoItemUseCases
    {
        private readonly ICalendarService _calendarService;

        private readonly IMediator _mediator;

        public ToDoItemUseCases(ICalendarService calendarService, IMediator mediator)
        {
            _calendarService = calendarService;
            _mediator = mediator;
        }

        public async Task<ToDoCommandResult> AddToDoItemAsync(DateTime dateTime, string description)
        {
            var timeAvailable = _calendarService.DateTimeIsAvailable(dateTime);
            if (!timeAvailable) return new ToDoCommandResult(false, "This time is not available");

            var request = new AddToDoCommand()
            {
                Item = new ToDoItem()
                {
                    EventDateTime = dateTime,
                    Description = description
                }
            };

            var toDoCommandResult = await _mediator.Send(request).ConfigureAwait(false);

            return toDoCommandResult;
        }

        public async Task<IEnumerable<ToDoItem>> GetToDoItemsAsync()
        {
            var request = new GetToDoCommand() { };

            return await _mediator.Send(request).ConfigureAwait(false);
        }

    }
}
