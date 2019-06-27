using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeXrmEasy;
using FixRM.LastSchedule.Plugins;
using FixRM.LastSchedule.Plugins.Entities;
using Microsoft.Xrm.Sdk;

namespace Plugins.Tests
{
    [TestClass]
    public class GetNextRecurrenceHandlerTests
    {
        [TestMethod]
        public void DoNotThrowTest()
        {
            /// Setup
            DateTime now = DateTime.UtcNow;

            // Cron does not support seconds by default
            now = now.AddTicks(-(now.Ticks % TimeSpan.TicksPerMinute));

            string pattern = "0 0/3 * 1/1 * ? *";

            fixrm_RecurringJobSchedule jobSchedule = new fixrm_RecurringJobSchedule()
            {
                Id = Guid.NewGuid(),
                // Every minute
                fixrm_Pattern = pattern
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
            DateTime expectedNextRecurrence = now.AddMinutes(3);
            DateTime? actualNextRecurrence = executionContext.OutputParameters[GetNextRecurrenceHandler.NextRecurrence] as DateTime?;

            Assert.AreEqual(expectedNextRecurrence, actualNextRecurrence);
        }
    }
}