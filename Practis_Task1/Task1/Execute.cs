using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1
{
    class Execute
    {
        public void ShowInfo()
        {
            Console.SetWindowSize(100, 50);

            Vehicle[] vehicles =
            {
            new Car(4, EngineType.Electro, GearBoxType.Robot, 4, ConsoleColor.Cyan, 60, 4),
            new Bicycle(BicycleType.MountainBike, BreakeType.FootBrakes, 2, ConsoleColor.Red, 50, 1),
            new Moto(MotoType.Chopper, 2, ConsoleColor.Magenta, 150, 2) };

            foreach (var item in vehicles)
            {
                item.Move(5000);
                item.DisplayCharacteristics(item);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
