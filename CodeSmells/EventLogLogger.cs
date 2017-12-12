using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    public class EventLogLogger : ILogger
    {
        public string EventSource { get; }
        public string LogName { get; }

        public EventLogLogger(string eventSource, string logName)
        {
            EventSource = eventSource;
            LogName = logName;
        }

        public bool EventLogSourceExists()
        {
            return EventLog.SourceExists(EventSource);
        }

        public void LogToEventLog(string message, EventLogEntryType type)
        {
            EventLog log = new EventLog(LogName);
            log.Source = EventSource;
            log.WriteEntry(message, type);
        }

        public void LogToFile(string message)
        {
            throw new NotSupportedException();
        }
    }
}
