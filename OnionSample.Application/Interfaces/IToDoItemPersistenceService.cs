using OnionSample.Core.Entities;
using System;
using System.Collections.Generic;

namespace OnionSample.Application.Interfaces
{
    public interface IToDoItemPersistenceService
    {
        void Save(ToDoItem item);
        IEnumerable<ToDoItem> GetToDoItems();
        ToDoItem GetToDoItem(DateTime eventDateTime);
    }
}
