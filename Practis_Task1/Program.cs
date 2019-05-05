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
            Vehicle[] vehicles = new Vehicle[3];
            
                vehicles[0] = new Car(4, EngineType.Diesel, GearBoxType.Manual, 4, ConsoleColor.Cyan, 200, 6);
                vehicles[1] = new Bicycle(BicycleType.MountainBike, BreakeType.FootBrakes,2, ConsoleColor.Red, 50, 1);
                vehicles[2] = new Moto(MotoType.Chopper, 2, ConsoleColor.Magenta, 150, 2);

            //foreach (var item in vehicles)
            //{
            //    item.Move(5000);
            //}
            foreach (var i in vehicles)
            {
                Console.WriteLine(i);
            }
        }
    }
}
                


           



   

