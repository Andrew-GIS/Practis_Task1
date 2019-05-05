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
            Car car = new Car(4, EngineType.Electro, GearBoxType.Robot, 4, ConsoleColor.DarkBlue, 60, 4);

            Vehicle[] vehicles = new Vehicle[3];
            

            vehicles[0] = new Car(4, EngineType.Electro, GearBoxType.Robot, 4, ConsoleColor.DarkBlue, 60, 4);
            vehicles[1] = new Bicycle(BicycleType.MountainBike, BreakeType.FootBrakes, 2, ConsoleColor.Red, 50, 1);
            vehicles[2] = new Moto(MotoType.Chopper, 2, ConsoleColor.Magenta, 150, 2);
            DisplayCar();


            foreach (var item in vehicles)
            {
                item.Move(5000);
            }
            void DisplayCar()
            {
                Console.SetWindowSize(100, 50);
                Console.Write("WheelCount\tColor\tMaxSpeed\tPassengerCount\tDoorsCount\tEngine\tGearbox\n");
                Console.Write($"{car.WheelCount}\t{car.Color}\t{car.MaxSpeed}\t{car.PassengerCount}\t{car.DoorsCount}\t{car.Engine}\t{car.GearBox}");
                //Console.Write($"{vehicles[0].WheelCount}\t{vehicles[0].Color}\t{vehicles[0].MaxSpeed}\t{vehicles[0].PassengerCount}\t");
                Console.WriteLine();
            }
        }

    }
}









