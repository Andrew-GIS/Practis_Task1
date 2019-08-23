using Practis_Task1.Task1;
using Practis_Task1.Task1._2;
using Practis_Task1.Task2;
using Practis_Task1.Task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Task1.PingPong.
            //
            //Game game = new Game();
            //GamePartSecond() game2 = new GamePartSecond();

            //
            //Task2.Hunting.
            //
            HuntingProcess hunting = new HuntingProcess();
            hunting.DoHuntingProcess();

            //
            //IDisposable realization.
            //
            //TestSpace test1 = new TestSpace();
            //test1.Check();
            //TestSpace test2 = new TestSpace();
            //test2.Check2();
        }

    }
}








