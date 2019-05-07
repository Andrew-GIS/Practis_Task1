using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Car : Vehicle
    {
        //property
        public int DoorsCount { get; set; }
        public EngineType Engine { get; set; }
        public GearBoxType GearBox { get; set; }

        //constructor
        public Car(int doorsCount, EngineType engine, GearBoxType gearBox,
            int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            DoorsCount = doorsCount;
            Engine = engine;
            GearBox = gearBox;
        }
        public override void DisplayCahracteristics(Vehicle vehicle)
        {
            Console.WriteLine(String.Format("{0, 6} | {1, 10} | {2, 9} | {3,10} | {4,5} | {5,10} | {6,10}",
                "Wheels",
                "Color",
                "Max Speed",
                "Passengers",
                "Doors",
                "Engine",
                "GearBox"));
            Console.Write(String.Format("{0, 6} | {1, 10} | {2, 9} | {3,10}",
                vehicle.WheelCount,
                vehicle.Color,
                vehicle.MaxSpeed,
                vehicle.PassengerCount,
                this.DoorsCount,
                this.Engine,
                this.GearBox
                ));
            Console.WriteLine();
        }
    }

    enum EngineType
    {
        Petrol,
        Diesel,
        Electro
    }

    enum GearBoxType
    {
        Manual,
        Auto,
        Robot
    }
    
}
