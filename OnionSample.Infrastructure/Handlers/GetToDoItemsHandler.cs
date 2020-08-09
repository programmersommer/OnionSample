using MediatR;
using OnionSample.Application.Commands;
using OnionSample.Core.Entities;
using OnionSample.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnionSample.Infrastructure.Handlers
{
    class GetToDoItemsHandler : IRequestHandler<GetToDoCommand, List<ToDoItem>>
    {
        private readonly IToDoItemPersistenceService _toDoItemPersistenceService;
        public GetToDoItemsHandler(IToDoItemPersistenceService toDoItemPersistenceService)
        {
            _toDoItemPersistenceService = toDoItemPersistenceService;
        }

        public Task<List<ToDoItem>> Handle(GetToDoCommand request, CancellationToken cancellationToken)
        {
            var items = request.EventDate == null
                ? _toDoItemPersistenceService.GetToDoItems()
                : _toDoItemPersistenceService.GetToDoItems((DateTime)request.EventDate);
            return Task.FromResult(items.ToList());
        }
    }
}
