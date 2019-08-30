using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class MyCar
    {
        private Field field = new Field();

        private RoadBorder road = new RoadBorder();

        private OtherCar otherCar = new OtherCar();

        public int heightWindow;

        public int endBounderCoordinate;

        public int[] leftCoordinate;

        public int[] topCoordinate;

        private char Symbol { get; set; }

        public static int carPosition;

        public MyCar()
        {
            heightWindow = this.field.FieldHight;
            endBounderCoordinate = this.road.EndBorderCoordinate;
            this.Symbol = '*';
            
            this.leftCoordinate = new int[] { endBounderCoordinate - 3, endBounderCoordinate - 4, endBounderCoordinate - 3, endBounderCoordinate - 2, endBounderCoordinate - 3, endBounderCoordinate - 4, endBounderCoordinate - 2 }; //{ 6, 5, 6, 7, 6, 5, 7 };
            this.topCoordinate = new int[] { heightWindow - 5, heightWindow - 4, heightWindow - 4, heightWindow - 4, heightWindow - 3, heightWindow - 2, heightWindow - 2 }; //{ 16, 17, 17, 17, 18, 19, 19 };
        }

        public void DoRightCarPosition()
        {
            carPosition = 2;
            lock (GameProcess.locker)
            {
                for (int i = 0; i < 7; i++)
                {

                    Console.SetCursorPosition(leftCoordinate[i], topCoordinate[i]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(Symbol);
                }
            }
        }

        public void RemoveCarAtLeftPosition()
        {
            lock (GameProcess.locker)
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.SetCursorPosition(leftCoordinate[i] - 3, topCoordinate[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(" ");
                }
            }
        }

        public void DoLeftCarPosition()
        {
            carPosition = 1;
            lock (GameProcess.locker)
            {
                for (int i = 0; i < 7; i++)
                {

                    Console.SetCursorPosition(leftCoordinate[i] - 3, topCoordinate[i]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(Symbol);
                }
            }
        }

        public void RemoveCarAtRightPosition()
        {
            lock (GameProcess.locker)
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.SetCursorPosition(leftCoordinate[i], topCoordinate[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(" ");
                }
            }
        }

        public void RunMainCar()
        {

            while (true)
            {

                var arrow = Console.ReadKey();
                switch (arrow.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        
                        DoLeftCarPosition();
                        RemoveCarAtRightPosition();
                        break;
                    case ConsoleKey.RightArrow:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        DoRightCarPosition();
                        RemoveCarAtLeftPosition();
                        break;
                    case ConsoleKey.Escape:
                        Thread.CurrentThread.Abort();
                        break;
                }
                if (GameProcess.isCrash == true)
                {
                    Thread.CurrentThread.Abort();
                    break;
                }
            }
        }
    }
}

