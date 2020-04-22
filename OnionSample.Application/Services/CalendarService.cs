using System;
using OnionSample.Application.Interfaces;


namespace OnionSample.Application.Services
{
    public class CalendarService : ICalendarService
    {
        public bool DateTimeIsAvailable(DateTime date)
        {
            // some logic checks do some event is already planned for specified day and time
            return true;
        }
    }
}
