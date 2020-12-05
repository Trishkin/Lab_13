using Lab_13.Models;
using System;
using System.IO;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = File.AppendText(@"D:\OOP\Lab_13\log.txt"))
            {
                KDNLog.Log("Test1", w);
                KDNLog.Log("Test2", w);
                KDNLog.Log("Alasdwevxc", w);
                KDNLog.Log("wedqw dsvd vx", w);
                KDNLog.Log("sd fac afwe a sdf ", w);
                KDNLog.Log("sad fsacs xca cae ", w);
                KDNLog.Log("as e da dsf cxvz ", w);
                KDNLog.Log("zxv  zdsf df s ffs", w);
            }

            using (StreamReader r = File.OpenText(@"D:\OOP\Lab_13\log.txt"))
            {
                KDNLog.DumpLog(r);
            }
            using (StreamReader r = File.OpenText(@"D:\OOP\Lab_13\log1.txt"))
            {
                KDNLog.LogForLastTime(r);
            }

            Console.WriteLine(KDNLog.count);

            Console.WriteLine();
            KDNDirInfo.ParentDir(@"D:\OOP\Lab_13");
            KDNDirInfo.SubDirCounts(@"D:\OOP\");
            KDNDirInfo.TimeOfCreation(@"D:\OOP\");
            KDNDirInfo.CountOfFiles(@"D:\OOP\");
            Console.WriteLine();

            Console.WriteLine();
            KDNFileInfo.Path(@"D:\OOP\Lab_13\log.txt");
            KDNFileInfo.FileInf(@"D:\OOP\Lab_13\log.txt");
            KDNFileInfo.FileTime(@"D:\OOP\Lab_13\log.txt");
            Console.WriteLine();

            Console.WriteLine();
            KDNDiskInfo.FreeSpace();
            KDNDiskInfo.Format();
            KDNDiskInfo.Info();
            Console.WriteLine();

            Console.WriteLine();
            KDNFileManager.part1();
            KDNFileManager.part2();
            KDNFileManager.part3();
        }
    }
}
