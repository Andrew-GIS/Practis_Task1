using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class Matrix
    {
        static readonly object locker = new object();

        private readonly int windowWidth;

        private readonly int windowHight;

        private Random random = new Random();

        public Matrix()
        {
            this.windowHight = 50;
            this.windowWidth = 50;
            Console.SetWindowSize(windowWidth, windowHight);
            Console.CursorVisible = false;
        }

        public string TakeRandomSign()
        {
            var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(chars.Select(c => chars[random.Next(chars.Length)]).Take(1).ToArray());
        }

        public void PrintWithColorMark(int left, int top, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(left, top);
            Console.WriteLine($"{TakeRandomSign()}");
        }

        public void PrintSpaceRow(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(" ");
        }

        public void DrowingMatrix()
        {
            while (true)
            {
                int rowLength = this.random.Next(3, 10);
                int rowCoordinate = this.random.Next(0, this.windowWidth - 1);
                int spaceRow = this.windowHight - rowLength;
                var rowSpeed = 300;

                for (int i = 0; i < windowHight; i++)
                {
                    Thread.Sleep(rowSpeed);

                    lock (locker)
                    {
                        //start of random located row
                        Console.SetCursorPosition(rowCoordinate, i);

                        //shutting of the row
                        if (i > 0)
                        {
                            this.PrintSpaceRow(rowCoordinate, i - 1);
                        }
                    }

                    int whiteCharPosition = i;
                    int greenCharPosition = i;
                    int darkGreenCharPosition = i;

                    if (i < spaceRow + 2)
                    {
                        //cycle of the our matrixSign row
                        for (int j = 0; j < rowLength; j++)
                        {
                            if (i == 0)
                                Thread.Sleep(rowSpeed);

                            lock (locker)
                            {
                                if (i < spaceRow)
                                {
                                    if (j > 0)
                                    {
                                        this.PrintWithColorMark(rowCoordinate, greenCharPosition, ConsoleColor.Green);
                                        greenCharPosition++;
                                    }
                                    this.PrintWithColorMark(rowCoordinate, whiteCharPosition, ConsoleColor.White);
                                    whiteCharPosition++;
                                }

                                if (j > 1)
                                {
                                    this.PrintWithColorMark(rowCoordinate, darkGreenCharPosition, ConsoleColor.DarkGreen);
                                    darkGreenCharPosition++;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void Execute()
        {
            while (true)
            {
                Thread.Sleep(new Random().Next(100, 1000));
                new Thread(new ThreadStart(this.DrowingMatrix)).Start();
            }
        }
    }
}
