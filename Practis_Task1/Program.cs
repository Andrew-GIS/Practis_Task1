using Practis_Task1.Task2_Mammals;
using Practis_Task1.Task3_GrertingPerson;
using Practis_Task1.Task4_Calculator;
using Practis_Task1.Task5;
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
            //Task1 - task with Figures (without polymorphism).
            //
            //FigureDrawing.Execute();

            //
            //Task1 - task with Figures (with polymorphism).
            //
            //DrawingFigurePol.Execute();

            //
            //Task2 - task where realized Mammals polymorphism.
            //
            //FeedingAndMoving set = new FeedingAndMoving();
            //set.FeedAndMoveProcess();

            //
            //Task3 - task where realized Greeting in different languages.
            //
            //Greeting set = new Greeting();
            //set.HelloWord();

            //
            //Task4 - Calulator with support polymorphism.
            //
            //Calculate calculate = new Calculate();
            //calculate.Calculator(4, 2);

            //
            //Task5 - 
            //
            Animal[] arrAnimal = new Animal[8];
            arrAnimal[0] = new Dog { Name = "Шарик" };
            arrAnimal[1] = new Cat { Name = "Кусака" };
            arrAnimal[2] = new Cat { Name = "Ленивец" };
            arrAnimal[3] = new Lynx { Name = "Леснушка" };
            arrAnimal[4] = new Dog { Name = "Джек" };
            arrAnimal[5] = new Cat { Name = "Черныш" };
            arrAnimal[6] = new Dog { Name = "Арчи" };
            arrAnimal[7] = new Lynx { Name = "Рыська" };
            foreach (Animal a in arrAnimal)
            {
                Console.WriteLine($"{a.Bite()}");
                Console.WriteLine();
            }

        }
    }
}


    
        


           



   

