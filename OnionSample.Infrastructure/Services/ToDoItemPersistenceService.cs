using OnionSample.Application.Interfaces;
using OnionSample.Core.Entities;

namespace OnionSample.Infrastructure.Persistence.Services
{
    internal class ToDoItemPersistenceService : IToDoItemPersistenceService
    {
        public void Save(ToDoItem item)
        {
            // logic that saves ToDoItem to database
        }
    }
}
