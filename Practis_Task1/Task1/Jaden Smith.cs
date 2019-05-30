using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1
{
    class Jaden_Smith
    {
        public void WriteLikeJSmith()
        {
            var jadanText = UpperCase();
            //Console.WriteLine(jadanText);
            Console.WriteLine(string.Join(" ", jadanText));
        }

        public string [] GetMassage()
        {
            Console.WriteLine("Inpute you massage, please.");
            string text = Console.ReadLine();

            string[] massageArray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            return massageArray;
        }

        public string[] UpperCase()
        {
            var massage = GetMassage();
            string[] massageWithUpper = new string[massage.Length];
            Console.WriteLine("Let's write like Jaden Smith");
            for (int i = 0; i < massageWithUpper.Length; i++)
            {
                massageWithUpper[i] = massage[i].Substring(0, 1).ToUpper() + massage[i].Substring(1, massage[i].Length - 1);
            }
            return massageWithUpper;
        }
    }
}
