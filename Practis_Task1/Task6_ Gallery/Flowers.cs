using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task6__Gallery
{
    class Flowers: Plant
    {
        public int LeafNumber { get; set; }

        public int PetalNumber { get; set; }

        public Flowers(string type, ConsoleColor color, int leafnumber, int petalnumber) : base(type, color)
        {
            LeafNumber = leafnumber;
            PetalNumber = petalnumber;
        }

        public override double TookWater()
        {
            Console.WriteLine($"Inpute height of you {this.Type} (cm)");
            double heightPlant = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"How many water did you use to pouring you {this.Type} (ml) (normal quantity of water is from 100 to 500ml)");
            double pour = Convert.ToDouble(Console.ReadLine());
            bool check = true;
            while (check == true)
            {
                if (pour <= 100)
                {
                    Console.WriteLine($"Your {this.Type} wasn't pour");
                    continue;
                }
                else if (pour > 100 && pour < 500)
                {
                    Console.WriteLine($"{this.Type} was pour by {pour}ml of water");
                    heightPlant += 1;
                    Console.WriteLine($"Congratulate - hieght of your {this.Type} become {heightPlant}");
                    check = false;
                }
                else
                {
                    Console.WriteLine("To much water - don't do this anymore, it is harmful for your plant - Don't do this!");
                    Console.WriteLine("Repeat inputting");
                    continue;
                }
            }
            return pour;
        }

        public override double TookMineral()
        {
            Console.WriteLine("How many minerals did you use to fertilize (mg) (normal quantity of soil is 10ml)");
            double mineral = Convert.ToDouble(Console.ReadLine());
            bool check = true;
            while (check == true)
            {
                
                if (mineral <= 0)
                {
                    Console.WriteLine("Your plant wasn't fertilize");
                    continue;
                }
                else if (mineral > 0 && mineral< 10)
                {
                    Console.WriteLine($"Plant was fertilize by {mineral}mg of soil");
                    ConsoleColor colorBefore = this.Color;
                    ConsoleColor colorAfter = ++this.Color;
                    Console.WriteLine($"As resault of your action your {this.Type} changed color from {colorBefore} to {colorAfter}");
                    check = false;
                }
                else
                {
                    Console.WriteLine("To much soil - don't do this anymore, it is harmful for your plant");
                    Console.WriteLine("Repeat inputting");
                    continue;
                }
            }
            return mineral;
        }

        public override void DoPhotosynthesis()
        {
            double pour = TookWater();
            double mineral = TookMineral();
            if (pour > 100 && mineral > 0)
            {
                double oxigen = (pour + mineral) / 2;
                Console.WriteLine($"Plant output {oxigen} ml of oxygen");
            }
        }

        public void LeafNumberChange()
        {
            int leafnumbers = LeafNumber+1;
            Console.WriteLine($"According to grow of you {this.Type} numbers of Leafs on you {this.Type} changed to {leafnumbers}");
        }

        public void PetalNumberChange()
        {
            int petalnumbers = PetalNumber+1;
            Console.WriteLine($"According to grow of you {this.Type} numbers of Petals on you {this.Type} changed to {petalnumbers}");
        }
    }
}
