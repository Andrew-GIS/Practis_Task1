using Practis_Task1.Task1;
using Practis_Task1.Task2;
using Practis_Task1.Task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Task1
            //
            //FolderInfo info = new FolderInfo();
            //info.DisplayInfo();
            //
            //Task 2.
            //
            TextFile text = new TextFile();
            text.CreateText();
            //
            //Task 3.
            //
            FileCountInfo file = new FileCountInfo();
            file.FileCreated();
            file.Counting();
        }
    }
}








