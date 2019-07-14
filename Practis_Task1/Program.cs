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
            //Link - https://docs.google.com/document/d/1QvUEa2VUAqyhXEo3TJLOkOM9x5lbacruosTKjre6Yjw/edit.
            //
            try
            {
                //
                //Task1.
                //
                //MyList<int> userList = new MyList<int>();
                //userList.Add(4);
                //userList.Add(11);
                //userList.Contains(4);
                //userList.ToString();

                //
                //Task2.
                //
                //CarPark park1 = new CarPark();
                //park1.ShowCar();

                //
                //Task3.
                //
                Task3.BuildingList chain1 = new BuildingList();
                chain1.BuildList();

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null - retry");
            }
        }
    }
}      


           



   

