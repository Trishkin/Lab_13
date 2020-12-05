using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_13.Models
{
    class KDNLog
    {
        public static int count = 0;
        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }

        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                count++;
                Console.WriteLine(line);
            }
            count = count / 5;
        }

        public static void LogForLastTime(StreamReader r)
        {
            
            string line;
            while ((line = r.ReadLine()) != null)
            {
                count++;
                Console.WriteLine(line);
            }
            count = count / 5;
        }
    }
}
