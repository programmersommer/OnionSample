
namespace OnionSample.Application.Commands
{
    public class ToDoCommandResult
    {
        public ToDoCommandResult(string message)
        {
            Message = message;
        }
        public string Message { get; }
    }
}
