using Practis_Task1.Task1;
using Practis_Task1.Task2;
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
            try
            {
                //
                //Task1.
                //
                //MyList<int> userList = new MyList<int>();
                //userList.Add(4);
                //userList.Add(11);
                //userList.ToString();
                //
                //Task2.
                //
                Car<> car1 = new Car("Lada", 1995);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null - retry");
            }
        }
    }
}      


           



   

