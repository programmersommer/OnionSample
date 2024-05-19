using MediatR;
using OnionSample.Application.Commands;
using OnionSample.Infrastructure.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace OnionSample.Infrastructure.Handlers
{
    class AddToDoItemHandler : IRequestHandler<AddToDoCommand, ToDoCommandResult>
    {
        private readonly IToDoItemPersistenceService _toDoItemPersistenceService;
        public AddToDoItemHandler(IToDoItemPersistenceService toDoItemPersistenceService)
        {
            _toDoItemPersistenceService = toDoItemPersistenceService;
        }

        public Task<ToDoCommandResult> Handle(AddToDoCommand request, CancellationToken cancellationToken)
        {
            _toDoItemPersistenceService.Save(request.Item);

            return Task.FromResult(new ToDoCommandResult(true, "ToDo item was saved"));
        }
    }
}
