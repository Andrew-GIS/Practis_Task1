using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class Node
    {
        private int X { get; set; }
        private int Y { get; set; }

        public Node(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Right()
        {
            X = X + 1;
        }

        public void Left()
        {
            X = X - 1;
        }

        public void Up()
        {
            Y = Y + 1;
        }

        public void Down()
        {
            Y = Y - 1;
        }
    }
}
