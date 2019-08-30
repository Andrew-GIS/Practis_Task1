using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class RoadBorder
    {
        private Field field = new Field();

        private int startBorderCoordinate;

        private int endBornderCoordinate;

        public int StartBorderCoordinate
        {
            get { return startBorderCoordinate; }

            set
            {
                if (value >= 0)
                    startBorderCoordinate = value;
            }
        }

        public int EndBorderCoordinate
        {
            get { return endBornderCoordinate; }

            set
            {
                if (value > 0)
                    endBornderCoordinate = value;
            }
        }

        private int widthWindow;

        private int heightWindow;

        private char Symbol { get; set; }

        public RoadBorder()
        {
            widthWindow = this.field.FieldWidth;
            heightWindow = this.field.FieldHight;
            this.Symbol = '#';
            Console.ForegroundColor = ConsoleColor.Yellow;
            startBorderCoordinate = 0;
            endBornderCoordinate = 9;
            Console.CursorVisible = false;
        }

        public void Move()
        {
            while (true)
            {
                int positionTop = 0;

                Thread.Sleep(30);
                for (int i = Console.WindowHeight - 1; i > 0; i--)
                {
                    //Thread.Sleep(30);
                    this.DrowBouder(this.Symbol, i, endBornderCoordinate);

                    if (i % 3 == 0)
                    {
                        this.DrowBouder(' ', i + 1, endBornderCoordinate);
                    }
                    positionTop++;
                }

                if (GameProcess.isCrash == true)
                {

                    Thread.CurrentThread.Abort();
                    Console.Clear();
                }
            }
        }

        public void DrowBouder(char Symbol, int startBouderCoordinate, int endBounderCoordinate)
        {
            lock (GameProcess.locker)
            {
                Console.SetCursorPosition(0, startBouderCoordinate);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(Symbol);

                Console.SetCursorPosition(endBounderCoordinate, startBouderCoordinate);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(Symbol);
            }
        }
    }
}
