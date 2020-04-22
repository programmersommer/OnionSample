using OnionSample.Core.Entities;
using OnionSample.Application.Interfaces;


namespace OnionSample.Infrastructure.Persistence.Services
{
    public class ToDoItemPersistenceService : IToDoItemPersistenceService
    {
        public void Save(ToDoItem item)
        {
            // logic that saves ToDoItem to database
        }
    }
}
