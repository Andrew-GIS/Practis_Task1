using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class OtherCar : Figure
    {
        public OtherCar(char symbol, ConsoleColor color) : base(symbol, color)
        {
            //this.Symbol = '^';
        }

        public override void InitializeState()
        {
            this.Node = new List<Node>()
            {
                                    new Node(1, 0),
                    new Node(0, 1), new Node(1, 1), new Node(2, 1),
                                    new Node(1, 2),
                    new Node(0, 3),                 new Node(2, 3)
            };
        }

        public override void Move(MoveDirection direction)
        {
            if (direction == MoveDirection.Down)
            {
                foreach (var item in Node)
                {
                    item.Down();
                    Thread.Sleep(500);
                }
            }
        }

    }
}
