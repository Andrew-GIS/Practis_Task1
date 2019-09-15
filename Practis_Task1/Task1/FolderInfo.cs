using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1
{
    public class FolderInfo
    {
        public void ShowFolderInfo()
        {
            try
            {
                var directory = new DirectoryInfo(ChooseDirectory());

                if (directory.Exists)
                {
                    double folderSize = GetSizeOfFolder(directory);
                    int folrersNumber = GetCountOfFolders(directory);
                    Console.WriteLine($"Numbers of folders in derectory - {folrersNumber}\n" +
                        $"Total size of folder - {folderSize} bytes, {Math.Round(folderSize / 1024)} kbytes");
                }
                else
                {
                    Console.WriteLine("Directory didn't exists");
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Access Denied, sorry");
            }
        }

        public string ChooseDirectory()
        {
            //return $@"D:\test";
            return $@"C:\Windows\System32";
        }

        public int GetCountOfFolders(DirectoryInfo directory)
        {
            directory = new DirectoryInfo(ChooseDirectory());
            int folderNumber = 0;
            folderNumber = directory.GetDirectories().Length;

            return folderNumber;
        }

        public double GetSizeOfFolder(DirectoryInfo directory)
        {
            double sizeValue = 0;
            double counter = 0;


            counter += directory.GetDirectories().Length;

            foreach (var file in directory.GetFiles())
            {
                sizeValue += file.Length;
            }

            foreach (var folder in directory.GetDirectories())
            {
                sizeValue += GetSizeOfFolder(folder);
            }
            return sizeValue;
        }
    }
}