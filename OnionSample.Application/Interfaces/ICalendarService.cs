using System;


namespace OnionSample.Application.Interfaces
{
    public interface ICalendarService
    {
        bool DateTimeIsAvailable(DateTime date);
    }

}
