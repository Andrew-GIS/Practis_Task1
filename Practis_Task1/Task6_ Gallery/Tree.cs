using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task6__Gallery
{
    class Tree: Plant
    {
        public int BranchNumber { get; set; }

        public int AnimalsThatLivesInTree { get; set; }

        public Tree(string type, ConsoleColor color, int branchnumber, int animal) : base(type, color)
        {
            BranchNumber = branchnumber;
            AnimalsThatLivesInTree = animal;
        }

        public override double TookWater()
        {
            Console.WriteLine($"Inpute height of you {this.Type} (cm)");
            double heightPlant = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"How many water did you use to pouring you {this.Type} (ml) (normal quantity of water is from 3 to 10 litres)");
            double pour = Convert.ToDouble(Console.ReadLine());
            //bool check = true;
            while (true)
            {

                if (pour < 3)
                {
                    Console.WriteLine($"Your {this.Type} wasn't pour oor pouring is not enough");
                    break;
                }
                else if (pour >= 3 && pour <= 10)
                {
                    Console.WriteLine($"{this.Type} was pour by {pour} litres of water");
                    heightPlant += 10;
                    Console.WriteLine($"Congratulate - hieght of your {this.Type} become {heightPlant}(cm)");
                    break;
                }
                else
                {
                    Console.WriteLine("To much water - don't do this anymore, it is harmful for your plant - Don't do this!");
                    Console.WriteLine("Repeat inputting");
                    break;
                }
            }
            return pour;
        }

        public override double TookMineral()
        {
            Console.WriteLine("How many minerals did you use to fertilize (mg) (normal quantity of soil is from 100mg tp 500mg)");
            double mineral = Convert.ToDouble(Console.ReadLine());
            bool check = true;
            while (check == true)
            {

                if (mineral < 100)
                {
                    Console.WriteLine("Your plant wasn't fertilize");
                    break;
                }
                else if (mineral >= 100 && mineral <= 500)
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
                    //Console.WriteLine("Repeat inputting");
                    break;
                }
            }
            return mineral;
        }

        public override void DoPhotosynthesis()
        {
            double pour = TookWater();
            double mineral = TookMineral();
            if (pour > 3 && pour<=10 && mineral > 100 && mineral <= 500)
            {
                double oxigen = (pour + mineral) / 2;
                Console.WriteLine($"Plant output {oxigen} ml of oxygen");
            }
            else
            {
                Console.WriteLine($"Your Worker is failed, {this.Type} doesn't have water and mineral, or count of it is to much");
            }
        }

        public void BranchNumberChange()
        {
            int bracnchnumber = BranchNumber + 1;
            Console.WriteLine($"According to grow of you {this.Type} numbers of Leafs on you {this.Type} changed to {bracnchnumber}");
        }

        public void AnimalsThatLivesInTreeNumberChange()
        {
            int animal = AnimalsThatLivesInTree + 1;
            Console.WriteLine($"According to grow of you {this.Type} numbers of Petals on you {this.Type} changed to {animal}");
        }
    }
}
