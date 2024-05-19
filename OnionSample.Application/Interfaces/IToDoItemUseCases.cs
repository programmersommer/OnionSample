using OnionSample.Application.Commands;
using OnionSample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionSample.Application.Interfaces
{
    public interface IToDoItemUseCases
    {
        Task<ToDoCommandResult> AddToDoItemAsync(DateTime dateTime, string description);
        Task<IEnumerable<ToDoItem>> GetToDoItemsAsync();
    }
}
