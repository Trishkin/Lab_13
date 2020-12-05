using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_13.Models
{
    public static class KDNFileInfo
    {
        public static void Path(string path)
        {
            FileInfo fileInf = new FileInfo(path);
            Console.WriteLine($"Путь к файлу = {fileInf.DirectoryName}");
        }
        public static void FileInf(string path)
        {
            FileInfo fileInf = new FileInfo(path);
            Console.WriteLine($"Размер файла = {fileInf.Length}");
            Console.WriteLine($"Расширение файла = {fileInf.Extension}");
            Console.WriteLine($"Имя файла = {fileInf.Name}");
        }
        public static void FileTime(string path)
        {
            FileInfo fileInf = new FileInfo(path);
            Console.WriteLine($"Дата создания файла = {fileInf.CreationTime}");
            Console.WriteLine($"Дата изменения файла = {fileInf.LastWriteTime}");
        }
    }
}
