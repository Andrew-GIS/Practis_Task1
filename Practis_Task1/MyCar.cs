using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class MyCar : Figure
    {
        public MyCar(char symbol, ConsoleColor color) : base(symbol, color)
        {
            //this.Symbol = '*';
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
            if (direction == MoveDirection.Left)
            {
                foreach (var item in Node)
                {
                    item.Left();
                    item.Left();
                    item.Left();
                }
            }

            if (direction == MoveDirection.Right)
            {
                foreach (var item in Node)
                {
                    item.Right();
                    item.Right();
                    item.Right();
                }
            }
        }
    }
}

