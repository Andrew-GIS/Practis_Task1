using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1
{
    //https://ru.stackoverflow.com/questions/776375/%D0%9F%D0%B0%D0%B4%D0%B0%D1%8E%D1%89%D0%B8%D0%B5-%D1%81%D0%B8%D0%BC%D0%B2%D0%BE%D0%BB%D1%8B

     public class Matrix
    {
        static readonly object locker = new object();

        private readonly int windowWidth;

        private readonly int windowHight;

        public Random random = new Random();

        public const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";

        public Matrix()
        {
            this.windowHight = 50;
            this.windowWidth = 100;
            Console.SetWindowSize(windowWidth, windowHight);
        }

        public void PrintRandomLetter()
        {
            random = new Random();
            char[] set = new char[chars.Length];

            for (int i = 0; i < 1; i++)
            {
                set[i] = chars[random.Next(chars.Length)];
                Console.WriteLine(set[i]);
                Thread.Sleep(100);
            }
        }

        public void DoColorMark(int firstValue, int secondValue, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(firstValue, secondValue);
            PrintRandomLetter();
            //if (firstValue == secondValue)
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //}
            //else if (secondValue == firstValue - 1)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkGreen;
            //}
        }
        
        public void ShowSpaceSign(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(' ');
        }

        public void DrowingMatrix()
        {
            while (true)
            {
                int stringLength = this.random.Next(3, this.windowHight / 3);
                int rowCoordinate = this.random.Next(0, this.windowWidth-1);
                int space = this.windowHight - stringLength;
                var symbolSpeed = this.random.Next(50, 300);

                for (int i = 0; i < windowHight; i++)
                {
                    Thread.Sleep(symbolSpeed);

                    lock (locker)
                    {
                        Console.SetCursorPosition(rowCoordinate, i);

                        if (i > 0)
                        {
                            this.ShowSpaceSign(rowCoordinate, i - 1);
                        }
                    }

                    if (i < space + 2)
                    {
                        for (int j = 0; j < stringLength; j++)
                        {
                            if (i == 0)
                                Thread.Sleep(symbolSpeed);

                            lock (locker)
                            {
                                if (j > 1)
                                {
                                    this.DoColorMark(rowCoordinate, i, ConsoleColor.DarkGreen);
                                    i++;
                                }

                                if (i < space)
                                {
                                    if (j > 0)
                                    {
                                        this.DoColorMark(rowCoordinate, i, ConsoleColor.Green);
                                        i++;
                                    }
                                    this.DoColorMark(rowCoordinate, i, ConsoleColor.White);
                                    i++;
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
                Thread.Sleep(new Random().Next(10, 1000));
                new Thread(new ThreadStart(this.DrowingMatrix)).Start();
            }
        }

        //static object locker = new object();
        //static Random rnd = new Random();

        //public static void DrawString(object x)
        //{
        //    int stringLength = rnd.Next(1, Console.WindowHeight - 10);
        //    int pozX = (int)x; // координата Х (номер столбца)
        //    int pozY = rnd.Next(0, Console.WindowHeight - 2); // начало строки
        //    int currentY = 0; // текущая координата Y. Используется во время изменения цвета символов

        //    for (int i = 0; i < stringLength; i++)
        //    {
        //        lock (locker)
        //        {

        //            1.Установка курсора новую позицию
        //            if (pozY == Console.WindowHeight - 1)
        //            {
        //                pozY = 0;
        //                Console.SetCursorPosition(pozX, pozY);
        //                currentY = pozY + 1;
        //            }
        //            else
        //            {
        //                Console.SetCursorPosition(pozX, pozY++);
        //                currentY = pozY + 1;
        //            }

        //            2.Рисуется белый(головной) символ
        //            Console.ForegroundColor = ConsoleColor.White;
        //            Console.WriteLine("{0}", Convert.ToChar(rnd.Next(100, 126)));

        //            3.Символ который оказался перед белым меняет цвет на зелёный, а перед зелёным на тёмно-зелёный
        //            if (currentY > 3 && i >= 2)
        //            {
        //                Console.SetCursorPosition(pozX, currentY - 3);
        //                Console.ForegroundColor = ConsoleColor.Green;
        //                Console.WriteLine("{0}", Convert.ToChar(rnd.Next(100, 126)));

        //                Console.SetCursorPosition(pozX, currentY - 4);
        //                Console.ForegroundColor = ConsoleColor.DarkGreen;
        //                Console.WriteLine("{0}", Convert.ToChar(rnd.Next(100, 126)));
        //            }
        //            else if (currentY <= 2)
        //            {
        //                Console.SetCursorPosition(pozX, currentY - 4 + Console.WindowHeight);
        //                Console.ForegroundColor = ConsoleColor.Green;
        //                Console.WriteLine("{0}", Convert.ToChar(rnd.Next(100, 126)));

        //                Console.SetCursorPosition(pozX, currentY - 5 + Console.WindowHeight);
        //                Console.ForegroundColor = ConsoleColor.DarkGreen;
        //                Console.WriteLine("{0}", Convert.ToChar(rnd.Next(100, 126)));
        //            }

        //            4.Строка укорачивается на один символ
        //            if (i == stringLength - 1)
        //            {
        //                if (pozY >= stringLength)
        //                {
        //                    Console.SetCursorPosition(pozX, pozY - stringLength);
        //                    Console.Write(' ');
        //                    i--;
        //                }
        //                else
        //                {
        //                    Console.SetCursorPosition(pozX, Console.WindowHeight - stringLength + pozY);
        //                    Console.Write(' ');
        //                    i--;
        //                }
        //            }
        //            Thread.Sleep(0);
        //        }
        //    }
        //}




        //static readonly object locker = new object();

        //private readonly Random random;

        //private readonly int consoleWidth;

        //private readonly int consoleHeight;

        //public Matrix()
        //{
        //    this.random = new Random();
        //    this.consoleWidth = 120;
        //    this.consoleHeight = 50;
        //    Console.SetWindowSize(this.consoleWidth, this.consoleHeight);
        //    Console.CursorVisible = false;
        //}

        //public void Execute()
        //{
        //    while (true)
        //    {
        //        Thread.Sleep(new Random().Next(20, 1000));
        //        new Thread(new ThreadStart(this.PrintSymbols)).Start();
        //    }
        //}

        //public void PrintSymbols()
        //{
        //    while (true)
        //    {
        //        var symbolLength = this.random.Next(3, this.consoleHeight / 3);
        //        var symbolSpeed = this.random.Next(50, 300);
        //        var leftCursorPosition = this.random.Next(0, this.consoleWidth - 1);
        //        var emptySpace = this.consoleHeight - symbolLength;

        //        for (int i = 0; i < this.consoleHeight; i++)
        //        {
        //            Thread.Sleep(symbolSpeed);

        //            lock (locker)
        //            {
        //                Console.SetCursorPosition(leftCursorPosition, i);

        //                if (i > 0)
        //                {
        //                    this.PrintBlankSymbol(leftCursorPosition, i - 1);
        //                }
        //            }

        //            int whiteColorPosition = i;
        //            int greenColorPosition = i;
        //            int darkGreenColorPosition = i;

        //            if (i < emptySpace + 2)
        //            {
        //                for (int j = 0; j < symbolLength; j++)
        //                {
        //                    if (i == 0)
        //                        Thread.Sleep(symbolSpeed);

        //                    lock (locker)
        //                    {
        //                        if (j > 1)
        //                        {
        //                            this.SetColor(leftCursorPosition, darkGreenColorPosition, ConsoleColor.DarkGreen);
        //                            darkGreenColorPosition++;
        //                        }

        //                        if (i < emptySpace)
        //                        {
        //                            if (j > 0)
        //                            {
        //                                this.SetColor(leftCursorPosition, greenColorPosition, ConsoleColor.Green);
        //                                greenColorPosition++;
        //                            }

        //                            this.SetColor(leftCursorPosition, whiteColorPosition, ConsoleColor.White);
        //                            whiteColorPosition++;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //public char ConvertToChar()
        //{
        //    var randomSelection = this.random.Next(0, 3);

        //    var symbol = ' ';

        //    switch (randomSelection)
        //    {
        //        case 0:
        //            symbol = Convert.ToChar(this.random.Next(48, 57));
        //            break;
        //        case 1:
        //            symbol = Convert.ToChar(this.random.Next(63, 90));
        //            break;
        //        case 2:
        //            symbol = Convert.ToChar(this.random.Next(97, 122));
        //            break;
        //        default:
        //            symbol = '$';
        //            break;
        //    }

        //    return symbol;
        //}

        //public void PrintBlankSymbol(int left, int top)
        //{
        //    Console.SetCursorPosition(left, top);
        //    Console.WriteLine(" ");
        //}

        //public void SetColor(int leftPosition, int topPosition, ConsoleColor color)
        //{
        //    Console.ForegroundColor = color;
        //    Console.SetCursorPosition(leftPosition, topPosition);
        //    Console.WriteLine($"{ConvertToChar()}");
        //}
    }
}
