using FakeXrmEasy;
using FixRM.LastSchedule.Plugins.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using System;

namespace FixRM.LastSchedule.Plugins.Tests
{
    [TestClass]
    public class GetNextRecurrenceHandlerTests
    {
        [TestMethod]
        public void GetNextRecurrenceTest()
        {
            /// Setup
            fixrm_RecurringJobSchedule jobSchedule = new fixrm_RecurringJobSchedule()
            {
                Id = Guid.NewGuid(),
                // Every minute
                fixrm_Pattern = "0 0/1 * 1/1 * ? *"
            };

            fixrm_RecurringJob job = new fixrm_RecurringJob()
            {
                Id = Guid.NewGuid(),
                fixrm_ScheduleId = jobSchedule.ToEntityReference()
            };

            XrmFakedContext fakedContext = new XrmFakedContext();
            fakedContext.Initialize(new Entity[] { jobSchedule, job });

            XrmFakedPluginExecutionContext executionContext = fakedContext.GetDefaultPluginContext();
            executionContext.InputParameters.Add(GetNextRecurrenceHandler.Target, job.ToEntityReference());
            executionContext.OutputParameters.Add(GetNextRecurrenceHandler.NextRecurrence, null);

            /// Act
            fakedContext.ExecutePluginWith<GetNextRecurrenceHandler>(executionContext);

            /// Assert

            // Cron doesn't support seconds by default
            DateTime now = DateTime.UtcNow.Truncate(TimeSpan.TicksPerMinute);

            DateTime expectedNextRecurrence = now.AddMinutes(1);
            DateTime? actualNextRecurrence = executionContext.OutputParameters[GetNextRecurrenceHandler.NextRecurrence] as DateTime?;

            Assert.AreEqual(expectedNextRecurrence, actualNextRecurrence);
        }
    }
}