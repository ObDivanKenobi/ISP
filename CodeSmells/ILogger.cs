using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    public interface ILogger
    {
        void LogToFile(string message);
        void LogToEventLog(string message, System.Diagnostics.EventLogEntryType type);
        bool EventLogSourceExists();
    }
}
