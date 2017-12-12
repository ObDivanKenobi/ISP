using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeSmells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CodeSmells.Tests
{
    [TestClass()]
    public class EventLogLoggerTests
    {
        [TestMethod()]
        public void LogToEventLogTest_Success()
        {
            string message = $"test{new Random().Next()}",
                   appName = "EventLogLoggerTest",
                   logName = "New test log";
            EventLogLogger logger = new EventLogLogger(appName, logName);

            logger.LogToEventLog(message, EventLogEntryType.Warning);


            EventLogEntryCollection log = new EventLog(logName).Entries;
            bool found = false;
            foreach (EventLogEntry entry in log)
            {
                if (entry.Message == message)
                {
                    found = true;
                    break;
                }
            }

            Assert.IsTrue(found);
        }

        [TestMethod()]
        public void EventLogSourceExistsTest_SourceExists_Success()
        {
            string appName = "EventLogLoggerTest",
                   logName = "New test log";

            EventLogLogger logger = new EventLogLogger(appName, logName);

            Assert.IsTrue(logger.EventLogSourceExists());
        }

        [TestMethod()]
        public void EventLogSourceExistsTest_SourceDoesNotExist_Fail()
        {
            string appName = "some definitely incorrect event source",
                   logName = "New test log";

            EventLogLogger logger = new EventLogLogger(appName, logName);

            Assert.IsFalse(logger.EventLogSourceExists());
        }
    }
}