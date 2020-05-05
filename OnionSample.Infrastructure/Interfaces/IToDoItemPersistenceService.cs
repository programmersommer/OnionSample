using OnionSample.Core.Entities;


namespace OnionSample.Infrastructure.Interfaces
{
    internal interface IToDoItemPersistenceService
    {
        void Save(ToDoItem item);
    }

}
