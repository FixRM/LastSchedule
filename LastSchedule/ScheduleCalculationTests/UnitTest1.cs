using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecurrenceCalculator;
using System.Collections.Generic;
//using Cronos;
using Quartz;

namespace ScheduleCalculationTests
{
    public class JobRecurrence : IRecurrence
    {
        public JobRecurrence()
        {
            // TODO
        }

        public int DayOfMonth { get; set; }
        public bool Sunday { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public int Instance { get; set; }
        public int Day { get; set; }
        public int Interval { get; set; }
        public int MonthOfYear { get; set; }
        public int Occurrences { get; set; }
        public DateTime StartDate { get; set; }
        public RecurrenceType RecurrenceType { get; set; }
        public DateTime? EndDate { get; set; }
    }

    [TestClass]
    public class UnitTest1
    {

        //[TestMethod]
        //public void CronosTest()
        //{
        //    DateTime now = DateTime.UtcNow;
        //    now = now.AddTicks(-(now.Ticks % TimeSpan.TicksPerMinute));

        //    CronExpression expression = CronExpression.Parse("* * * * *");
        //    DateTime? next = expression.GetNextOccurrence(now);

        //    Assert.AreEqual(now.AddMinutes(1), next);
        //}

        [TestMethod]
        public void Quarz()
        {
            DateTime now = DateTime.UtcNow;
            now = now.AddTicks(-(now.Ticks % TimeSpan.TicksPerMinute));            

            CronExpression expression = new CronExpression("0 0/1 * 1/1 * ? *");
  
            DateTimeOffset? next = expression.GetTimeAfter(now);

            Assert.AreEqual(now.AddMinutes(1), next);
        }
    }
}
