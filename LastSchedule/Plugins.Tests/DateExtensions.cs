using System;

namespace FixRM.LastSchedule.Plugins.Tests
{
    public static class DateExtensions
    {
        /// <summary>
        /// Truncate date to date part. For ex. 
        /// </summary>
        /// <param name="roundTo">TimeSpan.TicksPerSecond return DateTime rounded to minutes</param>
        public static DateTime Truncate(this DateTime dateTime, long roundTo)
        {
            return dateTime.AddTicks(-(dateTime.Ticks % roundTo));
        }
    }
}
