using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Bicycle: Vehicle
    {
        public BicycleType Type { get; set; }
        public BreakeType Breake { get; set; }

        public Bicycle(BicycleType type, BreakeType breake,
            int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            Type = type;
            Breake = breake;
        }
        public override void DisplayCahracteristics(Vehicle vehicle)
        {
            Console.WriteLine(String.Format("{0, 6} | {1, 10} | {2, 9} | {3,10} | {4,5} | {5, 10}",
                "Wheels",
                "Color",
                "Max Speed",
                "Passengers",
                "BicycleType",
                "BreakeType"));
            Console.Write(String.Format("{0, 6} | {1, 10} | {2, 9} | {3,10} | {4,5} | {5, 10}",
                vehicle.WheelCount,
                vehicle.Color,
                vehicle.MaxSpeed,
                vehicle.PassengerCount,
                this.Type,
                this.Breake
                ));
            Console.WriteLine();
        }

    }
    enum BicycleType
    {
        RoadBike,
        MountainBike,
        BMX
    }

    enum BreakeType
    {
        HandBrakes,
        FootBrakes
    }
}
