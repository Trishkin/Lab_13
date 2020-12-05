using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_13.Models
{
    public static class KDNDiskInfo
    {
        public static void FreeSpace()
        {
            DriveInfo drive = DriveInfo.GetDrives()[0];


                Console.WriteLine($"Доступное свободное место: {drive.AvailableFreeSpace}");

        }
        public static void Format()
        {
            DriveInfo drive = DriveInfo.GetDrives()[0];



                Console.WriteLine($"Формат диска: {drive.DriveFormat}");

        }
        public static void Info()
        {
            DriveInfo drive = DriveInfo.GetDrives()[0];



                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем диска: {drive.TotalSize}");
                    Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
                Console.WriteLine();
        }
    }
}
