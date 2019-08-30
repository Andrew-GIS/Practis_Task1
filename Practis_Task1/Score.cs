using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Score
    {
        private RoadBorder border = new RoadBorder();

        private Field field = new Field();

        private int endBounderCoordinate;

        public Score()
        {
            endBounderCoordinate = this.border.EndBorderCoordinate;
        }

        public void SetAndDrowScorePosition(int score)
        {
            lock (GameProcess.locker)
            {
                Console.SetCursorPosition(Console.WindowWidth-10, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"Score: {score}");
            }
        }

        public void CountScore()
        {
            int score = 0;
            while (true)
            {
                SetAndDrowScorePosition(score);
                    score += 2;
                    Thread.Sleep(400);
                if (GameProcess.isCrash == true)
                {
                    Console.Clear();
                    Console.SetCursorPosition(endBounderCoordinate + 1, (field.FieldHight / 2) - 1);
                    Console.WriteLine("Game Over");
                    Console.SetCursorPosition(endBounderCoordinate -2, field.FieldHight / 2);
                    Console.WriteLine($"Your scoure is - {score}");
                    Thread.CurrentThread.Abort();
                }
            }
        }
    }
}


