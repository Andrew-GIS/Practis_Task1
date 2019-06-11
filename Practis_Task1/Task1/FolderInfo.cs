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
            Console.WriteLine($"Name of your folders: {ChooseDirectory()}");
            Console.WriteLine(string.Empty);
            var folderNumber = this.CountingFolder(ChooseDirectory());
        }

        public string ChooseDirectory()
        {
            return $"D:\\test";
        }

        public string CountingFolder(string directory)
        {
            directory = this.ChooseDirectory();
            int counter = 0;

            ///int directoryCount = System.IO.Directory.GetDirectories($"{directory}").Length;

            //DirectoryInfo DrInfo = new DirectoryInfo(directory);
            //DirectoryInfo[] folder = DrInfo.GetDirectories();
            //FileInfo[] Fi = DrInfo.GetFiles();

            //foreach (var item in folder)
            //{
            //    Console.WriteLine(item);
            //    counter++;
            //    Console.WriteLine(counter);
            //}

            foreach (var item in Directory.GetDirectories(directory))
            {
                foreach (var i in Directory.GetDirectories(directory))
                {
                    //Console.WriteLine(i);
                    counter++;
                }
                CountingFolder(item);
            }

            //foreach (var item in Directory.GetDirectories(directory))
            //{
            //    //Console.WriteLine(item);
            //    counter++;
            //    //do
            //    //{
            //    //    CountingFolder();
            //    //}
            //    //while (counter != 0);
            //    //{
            //    //    Console.WriteLine("End of counting");
            //    //}
            //    //Console.WriteLine(counter);
            //}
            //Console.WriteLine(string.Empty);
            return $"You folder contains {counter} folder(s)";
        }

        public void CountingFiles ()
        {
            var directory = this.ChooseDirectory();
            long size = 0;
            int counter = 0;
            DirectoryInfo info = new DirectoryInfo(directory);
            foreach (var item in Directory.GetFiles(directory))
            {
                Console.WriteLine(item);
                size += item.Length;
                counter++;
            }
            Console.WriteLine($"Files - {counter}");
            //Console.WriteLine($"Size of your directory - {size} bite(s)");
        }
    }
}