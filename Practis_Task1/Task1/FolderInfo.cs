using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1
{
    class FolderInfo
    {
        //
        // вызвать рекусрсивный метод по нахождению обьема
        //
        public void DisplayInfo()
        {
            var directory = "D:\\test";
            int counter = 0;
            long size = 0;

            Console.WriteLine("Name of your folders: ");
            Console.WriteLine(string.Empty);
            foreach (var item in Directory.GetDirectories(directory))
            {
                //Console.WriteLine(item);
                counter++;
            }
            Console.WriteLine(string.Empty);
            Console.WriteLine($"You folder contains {counter} folders");

            int counter2 = 0;
            DirectoryInfo info = new DirectoryInfo(directory);
            foreach (var item in Directory.GetFiles(directory))
            {
                Console.WriteLine(item);
                size += item.Length;
                counter2++;
            }
            Console.WriteLine($"Files - {counter2}");
            Console.WriteLine($"Size of your directory - {size} bite(s)");
        }
    }
}