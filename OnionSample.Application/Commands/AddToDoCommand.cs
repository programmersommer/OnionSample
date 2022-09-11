using MediatR;
using OnionSample.Core.Entities;

namespace OnionSample.Application.Commands
{
    public class AddToDoCommand : IRequest<ToDoCommandResult>
    {
        public ToDoItem Item { get; set; }
    }
}
