using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOK
{
    interface IEventLogLogger
    {
        void Log(string message, System.Diagnostics.EventLogEntryType type);
        bool EventLogSourceExists();
    }
}
