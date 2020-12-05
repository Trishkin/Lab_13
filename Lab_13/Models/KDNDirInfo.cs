using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Lab_13.Models
{
    public static class KDNDirInfo
    {
        public static void CountOfFiles(string path)
        {
            int a = Directory.GetFiles(path).Length;
            Console.WriteLine($"Count of files = {a}");
        }
        public static void TimeOfCreation(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            Console.WriteLine($"Creation time = {dirInfo.CreationTime}");
        }
        public static void SubDirCounts(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            Console.WriteLine($"Count of directorys = {dirInfo.GetDirectories().Length}");
        }
        public static void ParentDir(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            Console.WriteLine($"Parent directory = {dirInfo.Parent}");
        }
    }
}
