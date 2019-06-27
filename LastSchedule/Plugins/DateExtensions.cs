using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixRM.LastSchedule.Plugins
{
    static class DateExtensions
    {
        /// <summary>
        /// Truncate date to date part. For ex. 
        /// </summary>
        /// <param name="roundTo">TimeSpan.TicksPerSecond return DateTime rounded to minutes</param>
        internal static DateTime Truncate(this DateTime dateTime, long roundTo)
        {
            return dateTime.AddTicks(-(dateTime.Ticks % roundTo));
        }
    }
}
