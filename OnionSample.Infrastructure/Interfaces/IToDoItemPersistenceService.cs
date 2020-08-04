using OnionSample.Core.Entities;
using System;
using System.Collections.Generic;

namespace OnionSample.Infrastructure.Interfaces
{
    internal interface IToDoItemPersistenceService
    {
        void Save(ToDoItem item);
        IEnumerable<ToDoItem> GetToDoItems();
        ToDoItem GetToDoItem(DateTime eventDateTime);
    }

}
