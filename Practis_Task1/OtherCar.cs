using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class OtherCar
    {
        private Field field = new Field();

        private RoadBorder road = new RoadBorder();

        private int heightWindow;

        private int startBouderCoordinate;

        private int[] leftCoordinate;

        private int[] topCoordinate;

        private char Symbol { get; set; }

        private Random random = new Random();

        public OtherCar()
        {
            heightWindow = this.field.FieldHight;
            startBouderCoordinate = this.road.StartBorderCoordinate;
            this.Symbol = '*';

            this.leftCoordinate = new int[] { startBouderCoordinate + 3, startBouderCoordinate + 2, startBouderCoordinate + 3, startBouderCoordinate + 4, startBouderCoordinate + 3, startBouderCoordinate + 2, startBouderCoordinate + 4 }; //{3, 2, 3, 4, 3, 4, 2};
            this.topCoordinate = new int[] { 0, 1, 1, 1, 2, 3, 3 };
        }

        public void DrawOtherCar(int positionLeft, int positionTop)
        {
            lock (GameProcess.locker)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.SetCursorPosition(this.leftCoordinate[j] + positionLeft, this.topCoordinate[j] + positionTop);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Symbol);
                }
            }
        }

        public void DrawSpace(int positionLeft, int positionTop)
        {
            lock (GameProcess.locker)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.SetCursorPosition(this.leftCoordinate[j] + positionLeft, this.topCoordinate[j] + positionTop);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" ");
                }
            }
        }

        public void MoveOtherCar(int fieldHeight)
        {
            while (true)
            {
                Thread.Sleep(400);
                int otherCarPosition = this.random.Next(0, 2);
                int positionLeft = 3;
                int positionTop = 0;

                switch (otherCarPosition)
                {
                    case 0:
                        positionLeft = 0;

                        for (int i = 0; i < fieldHeight-4 ; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = ConsoleColor.Black;
                            this.DrawOtherCar(positionLeft, positionTop);

                            Thread.Sleep(random.Next(400));

                            if (i != fieldHeight-3)
                            {
                                this.DrawSpace(positionLeft, positionTop);
                            }

                            positionTop++;

                            lock (GameProcess.locker)
                            {
                                if (i == 20 && MyCar.carPosition == 1 && positionLeft == 0)
                                {
                                    GameProcess.isCrash = true;
                                    Thread.CurrentThread.Abort();
                                }
                            }
                        }
                        break;

                    case 1:
                        positionLeft = 3;

                        for (int i = 0; i < fieldHeight - 4; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = ConsoleColor.Black;
                            this.DrawOtherCar(positionLeft, positionTop);

                            Thread.Sleep(random.Next(400));

                            if (i != fieldHeight - 3)
                            {
                                this.DrawSpace(positionLeft, positionTop);
                            }

                            positionTop++;

                            lock (GameProcess.locker)
                            {
                                if (i >= 20 && MyCar.carPosition == 2 && positionLeft == 3)
                                {
                                    lock (GameProcess.locker)
                                    {
                                        GameProcess.isCrash = true;
                                        Thread.CurrentThread.Abort();
                                    }
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}