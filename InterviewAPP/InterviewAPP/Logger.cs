using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Logger
    {
        private string Timestamp = DateTime.Now.ToString();
        private string? LogMessage { get; set; }
        private string? Filepath { get; set; }

        public static void Log(string Filename, string LogType, string LogMessage)
        {
            Logger Logger = new Logger();
            Logger.Filepath = AppDomain.CurrentDomain.BaseDirectory + Filename;
            Logger.LogMessage = string.Format("[{0}] [{1}] {2}", Logger.Timestamp, LogType, LogMessage);
            File.AppendAllText(Logger.Filepath, Logger.LogMessage + Environment.NewLine);
            Console.WriteLine("Log Output: " + Logger.Filepath);
        }

    }
}
