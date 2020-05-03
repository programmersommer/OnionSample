using System;
using System.Threading.Tasks;

namespace OnionSample.Application.Interfaces
{
    public interface IAddToDoItemUseCase
    {
        Task<bool> AddToDoItem(DateTime dateTime, string description);
    }
}
