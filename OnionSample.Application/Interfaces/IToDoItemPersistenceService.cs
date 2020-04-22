using OnionSample.Core.Entities;


namespace OnionSample.Application.Interfaces
{
    public interface IToDoItemPersistenceService
    {
        void Save(ToDoItem item);
    }

}
