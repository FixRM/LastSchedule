using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeXrmEasy;
using FixRM.LastSchedule.Plugins;

namespace Plugins.Tests
{
    [TestClass]
    public class GetNextRecurrenceHandlerTests
    {
        [TestMethod]
        public void DoNotThrowTest()
        {
            XrmFakedContext fakedContext = new XrmFakedContext();

            XrmFakedPluginExecutionContext executionContext = fakedContext.GetDefaultPluginContext();

            fakedContext.ExecutePluginWith<GetNextRecurrenceHandler>(executionContext);
        }
    }
}
