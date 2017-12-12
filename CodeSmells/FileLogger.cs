using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    public class FileLogger : ILogger
    {
        public string Path { get; }
        
        public FileLogger(string path)
        {
            Path = path;
        }

        public void LogToFile(string message)
        {
            StreamWriter writer = new StreamWriter(Path, true);
            writer.WriteLine(message);
            writer.Close();
        }

        public void LogToEventLog(string message, EventLogEntryType type)
        {
            throw new NotImplementedException();
        }

        public bool EventLogSourceExists()
        {
            throw new NotImplementedException();
        }
    }
}
