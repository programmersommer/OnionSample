using System;


namespace OnionSample.Application.Interfaces
{
    public interface IAddToDoItemUseCase
    {
        bool AddToDoItem(DateTime dateTime, string description);
    }
}
