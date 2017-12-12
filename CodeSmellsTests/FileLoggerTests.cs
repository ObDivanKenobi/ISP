using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeSmells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeSmells.Tests
{
    [TestClass()]
    public class FileLoggerTests
    {
        static string testFile = "test.txt";

        [TestMethod()]
        public void LogToFileTest_Success()
        {
            ClearFile();

            FileLogger logger = new FileLogger(testFile);
            string message = "test";

            logger.LogToFile(message);

            StreamReader reader = new StreamReader(new FileStream(testFile, FileMode.Open));

            Assert.IsTrue(message == reader.ReadLine());
        }

        void ClearFile()
        {
            StreamReader reader = new StreamReader(new FileStream(testFile, FileMode.Create));
            reader.Close();
        }
    }
}