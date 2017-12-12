using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOK
{
    public class FileLogger : IFileLogger
    {
        public string Path { get; }
        
        public FileLogger(string path)
        {
            Path = path;
        }

        public void Log(string message)
        {
            StreamWriter writer = new StreamWriter(Path, true);
            writer.WriteLine(message);
            writer.Close();
        }
    }
}
