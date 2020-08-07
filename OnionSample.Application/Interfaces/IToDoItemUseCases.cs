using OnionSample.Core.Entities;
using System;
using System.Collections.Generic;

namespace OnionSample.Application.Interfaces
{
    public interface IToDoItemUseCases
    {
        bool AddToDoItem(DateTime dateTime, string description);
        IEnumerable<ToDoItem> GetToDoItems();
    }
}
