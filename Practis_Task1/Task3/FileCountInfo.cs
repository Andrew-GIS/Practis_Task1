using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3
{
    class FileCountInfo
    {
        
        public string CreateWay()
        {
            string way = "D:\\test";
            string name = FileName();
            string resultWay = way + "." + name;
            return resultWay;
        }

        public string TextInputing()
        {
            string text = "Text text text";
            return text;
        }

        public string FileName()
        {
            string name = "Text.txt";
            return name;
        }

        public void FileCreated()
        {
            string way = this.CreateWay();
            string text = this.TextInputing();

            if (Directory.Exists(way))
            {
                File.Create(way);
                File.WriteAllText(way, text);
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(way);
                File.Create(way);
                File.WriteAllText(way, text);
            }

        }

        public void Counting()
        {
            try
            {
                string way = this.CreateWay();
                string text = this.TextInputing();

                string resultText = File.ReadAllText(way);
                int countSymbol = resultText.Length;

                int countWords = 0;
                foreach (var item in resultText)
                {
                    if (item == ' ' || item == '\n')
                    {
                        countWords++;
                    }
                }

                int countStrings = 0;
                foreach (var item in resultText)
                {
                    if (item == '\n')
                    {
                        countStrings++;
                    }
                }
                Console.WriteLine("Count of symbols = {0}\nCount of worlds = {1}\nCount of strings = {2}", countSymbol, countWords, countStrings);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access Error");
            }
            
        }
    }
}
