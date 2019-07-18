using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2
{
    class TextFile
    {
        public void CreateText()
        {
            string path = this.GetWay();
            string fileName = this.FileName();
            string text = this.GetText();
            try
            {
                if (Directory.Exists(path))
                {
                    File.Create(path + fileName).Close();
                    Console.WriteLine("File created - directory exists");
                    File.WriteAllText(path + fileName, text);
                }
                else
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    File.Create(path + fileName).Close();
                    Console.WriteLine("File created - directory didn't exist before");
                    File.WriteAllText(path + fileName, text);
                }
            }
            catch (FileAccess.)
            {

            }
        }

            public string GetText()
            {
                Console.WriteLine("Inpute your text");
                string text = Console.ReadLine();
                return text;
            }

            public string GetWay()
            {
                string way = "C:\\Temp\\";
                return way;
            }

            public string FileName()
            {
                string name = "userText.txt";
                return name;
            }
        }
    }
