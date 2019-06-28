using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task6__Gallery
{
    public abstract class Plant
    {
        //public double Height { get; set; }

        public string Type { get; set; }

        public ConsoleColor Color { get; set; }

        public Plant(string type,  ConsoleColor color)
        {
            this.Type = type;
            //this.Height = height;
            this.Color = color;
        }

        public abstract double TookWater();


        public abstract double TookMineral();


        public abstract void DoPhotosynthesis();
        

        //public double Grow(double pour, double mineral)
        //{
        //    Console.WriteLine("Inpute height of you plant (cm)");
        //    double heightPlant = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Look to your plant, it look normal (yes/no)");
        //    while (true)
        //    {
        //        string answer = Console.ReadLine();
        //        if (answer == "yes")
        //        {
        //            if (pour > 0 && pour < 500 && mineral > 0 && mineral < 10)
        //            {
        //                Console.WriteLine("You plant tacked a narmal quantity of water and minerals, plant can safed grow");
        //                heightPlant = heightPlant + 1;
        //                DoPhotosynthesis(pour, mineral);
        //            }
        //            else if (pour <= 0 && mineral <= 0)
        //            {
        //                Console.WriteLine("Your plant without pour and minerals, you need to fix it");
        //                TookWater();
        //                TookMineral();
        //            }
        //            else
        //            {
        //                Console.WriteLine("To much minerals and water, go to your wife or husbent and spend your time with your partner, leave your plant alone");
        //            }
        //        }
        //        else if (answer == "no")
        //        {
        //            Console.WriteLine("Oh, dear, this is bad! Take care about your plant, immediately put water and some minerals to your plant");
        //            TookWater();
        //            TookMineral();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Inpute \"yes\" or \"no\" please");
        //            continue;
        //        }
        //        return heightPlant;
        //    }
        //}
    }
}
