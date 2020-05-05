using OnionSample.Core.Entities;
using OnionSample.Infrastructure.Interfaces;

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
