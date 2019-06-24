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
            PrintDataInfo();

        }
        public static void PrintDataInfo()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            Console.WriteLine($"Current date = {date}");
            date = DateTime.Now.AddMonths(-2);
            Console.WriteLine($"Date 2 Month ago {date}");
            date = DateTime.Now.AddYears(-1);
            Console.WriteLine($"Date 1 Year Ago {date}");
            DateTime birthdayDate = new DateTime(1995, 7, 29);
            Console.WriteLine("Andrew's birthday -" + birthdayDate.ToString("D"));
            Console.WriteLine("Now is - {0:Y}", date);
        }
    }
}      


           



   

