using MediatR;
using OnionSample.Core.Entities;
using System;
using System.Collections.Generic;

namespace OnionSample.Application.Commands
{
    public class GetToDoCommand : IRequest<List<ToDoItem>>
    {
        public DateTime? EventDate { get; set; }
    }
}
