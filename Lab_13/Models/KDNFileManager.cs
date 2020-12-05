using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.IO.Compression;

namespace Lab_13.Models
{
    public static class KDNFileManager
    {
        public static void part1()
        {
            string path = @"D:\";
            string path1 = @"D:\KDNInspect";
            string path2 = @"D:\KDNInspect\kdndirinfo.txt";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            //Console.WriteLine($"Directorys = {dirInfo.GetDirectories()} \n Files = {dirInfo.GetFiles()}");
            DirectoryInfo dirInfo1 = new DirectoryInfo(path1);
            dirInfo1.Create();
            try
            {
                using (StreamWriter sw = new StreamWriter(path2, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("");
                }

                using (StreamWriter sw = new StreamWriter(path2, true, System.Text.Encoding.Default))
                {
                    foreach (var a in Directory.GetFiles(path))
                        sw.WriteLine($"{a}");
                    foreach (var a in Directory.GetDirectories(path))
                        sw.WriteLine($"{a}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            FileInfo file = new FileInfo(path2);
            file.CopyTo(path1 + @"\kdndirinfo1.txt", true);
            file.Delete();
        }

        public static void part2()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"D:\KDNFiles");
            dirInfo.Create();

            string[] picList = Directory.GetFiles(@"D:\", @"*.txt");


            foreach (string f in picList)
            {
                string fName = f.Substring(@"D:\".Length);
                File.Copy(Path.Combine(@"D:\", fName), Path.Combine(@"D:\KDNFiles", fName), true);
            }
            string[] txtList = Directory.GetFiles(@"D:\KDNFiles\", @"*.txt");
            foreach (string f in txtList)
            {
                string fName = f.Substring(@"D:\KDNFiles".Length + 1);
                File.Copy(Path.Combine(@"D:\KDNFiles", fName), Path.Combine(@"D:\KDNInspect", fName), true);
            }
        }

        public static void part3()
        {
            string sourceFolder = "D://KDNFiles/"; // исходная папка
            string zipFile = "D://KDNFiles.zip"; // сжатый файл
            string targetFolder = "D://11"; // папка, куда распаковывается файл

            ZipFile.CreateFromDirectory(sourceFolder, zipFile);
            Console.WriteLine($"Папка {sourceFolder} архивирована в файл {zipFile}");
            ZipFile.ExtractToDirectory(zipFile, targetFolder);

            Console.WriteLine($"Файл {zipFile} распакован в папку {targetFolder}");
            Console.ReadLine();
        }
    
    }
}
