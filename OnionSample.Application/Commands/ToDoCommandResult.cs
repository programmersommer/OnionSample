
namespace OnionSample.Application.Commands
{
    public class ToDoCommandResult
    {
        public ToDoCommandResult(bool isSuccessful, string message)
        {
            Message = message;
            IsSuccessful = isSuccessful;
        }
        public string Message { get; }
        public bool IsSuccessful { get; }
    }
}
