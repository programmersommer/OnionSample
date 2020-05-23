using MediatR;
using OnionSample.Application.Commands;
using OnionSample.Application.Interfaces;
using OnionSample.Core.Entities;
using System;
using System.Threading.Tasks;


namespace OnionSample.Application.UseCases
{
    public class AddToDoItemUseCase : IAddToDoItemUseCase
    {
        private readonly ICalendarService _calendarService;

        private readonly IMediator _mediator;

        public AddToDoItemUseCase(ICalendarService calendarService, IMediator mediator)
        {
            _calendarService = calendarService;
            _mediator = mediator;
        }

        public async Task<bool> AddToDoItemAsync(DateTime dateTime, string description)
        {
            var timeAvailable = _calendarService.DateTimeIsAvailable(dateTime);
            if (!timeAvailable) return false;

            var request = new ToDoCommand()
            {
                Item = new ToDoItem()
                {
                    Time = dateTime,
                    Description = description
                }
            };

            _ = await _mediator.Send(request).ConfigureAwait(false);

            return true;
        }

    }
}
