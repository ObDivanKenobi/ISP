using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOK
{
    public class EventLogLogger : IEventLogLogger
    {
        public string EventSource { get; }
        public string LogName { get; }
        EventLog eventLog;

        public EventLogLogger(string eventSource, string logName)
        {
            EventSource = eventSource;
            LogName = logName;
        }

        public bool EventLogSourceExists()
        {
            return EventLog.SourceExists(EventSource);
        }

        public void Log(string message, EventLogEntryType type)
        {
            EventLog log = new EventLog(LogName);
            log.Source = EventSource;
            log.WriteEntry(message, type);
        }
    }
}
