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
