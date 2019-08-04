using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class RoadBorder: Figure
    {
        public RoadBorder(char symbol, ConsoleColor color) : base(symbol, color)
        {
            this.Symbol = '|';
        }

        public override void InitializeState()
        {
            this.Node = new List<Node>()
            {
                new Node(0,10),      new Node(10,10),
                new Node(0,9),       new Node(9,9),
                new Node(0,8),       new Node(8,8)
            };
        }

        public override void Move(MoveDirection direction)
        {
            if (direction == MoveDirection.Down)
            {
                foreach (var item in Node)
                {
                    item.Down();
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
