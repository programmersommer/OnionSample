using OnionSample.Application.Interfaces;
using OnionSample.Core.Entities;
using System;
using System.Collections.Generic;

namespace OnionSample.Tests.Stubs
{
    class ToDoItemPersistenceService : IToDoItemPersistenceService
    {
        public ToDoItem GetToDoItem(DateTime eventDateTime)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDoItem> GetToDoItems()
        {
            throw new NotImplementedException();
        }

        public void Save(ToDoItem item)
        {
            // not yet implemented
        }
    }
}
