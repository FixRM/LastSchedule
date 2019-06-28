using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FixRM.LastSchedule.Plugins.Tests
{
    [TestClass]
    public class DateExtensionsTests
    {
        [TestMethod]
        public void TruncateTest()
        {
            // Setup
            DateTime now = DateTime.UtcNow;

            // Act
            DateTime noMillisecondsNow = now.Truncate(TimeSpan.TicksPerSecond);

            // Assert
            Assert.AreEqual(0, noMillisecondsNow.Millisecond);
            Assert.AreEqual(now.Kind, noMillisecondsNow.Kind);
            Assert.AreEqual(now.Date, noMillisecondsNow.Date);
            Assert.AreEqual(now.Second, noMillisecondsNow.Second);
        }
    }
}
