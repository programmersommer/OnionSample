using System;
using System.Threading.Tasks;

namespace OnionSample.Application.Interfaces
{
    public interface IAddToDoItemUseCase
    {
        Task<bool> AddToDoItemAsync(DateTime dateTime, string description);
    }
}
