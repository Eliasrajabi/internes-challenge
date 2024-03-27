using System;
using System.Collections;

namespace HolidayCalendar;



public class HolidayCalendar : IHolidayCalendar
{
    public bool IsHoliday(DateTime date)
    {
        // TODO - replace the below exception with your own implementation
        return date.Month == 12 && date.Day == 25;
    }
    
    public ICollection<DateTime> GetHolidays(DateTime startDate, DateTime endDate)
          {
              // TODO - replace the below exception with your own implementation
              var easterHolidays = new List<DateTime>
              {
                  new DateTime(2023, 4, 6), // Maundy Thursday
                  new DateTime(2023, 4, 7), // Good Friday
                  new DateTime(2023, 4, 9), // Easter Sunday
                  new DateTime(2023, 4, 10) // Easter Monday
              };

              var holidays = new List<DateTime>();
              foreach (var holiday in easterHolidays)
              {
                  if (holiday >= startDate && holiday <= endDate)
                  {
                      holidays.Add(holiday);
                  }
              }
              return holidays;
          }
    /*throw new NotImplementedException();*/
}
    
  
  
