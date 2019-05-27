using Practis_Task1.Task2_Mammals;
using Practis_Task1.Task3_GrertingPerson;
using Practis_Task1.Task4_Calculator;
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
            Calculate calculate = new Calculate();
            calculate.Calculator(4, 2);
        }
    }
}


    
        


           



   

