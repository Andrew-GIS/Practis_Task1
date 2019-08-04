using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public abstract class Figure
    {
        protected List<Node> Node { get; set; }
        public char Symbol { get;  set; }
        private ConsoleColor Color { get; set; }

        public Figure(char symbol, ConsoleColor color)
        {
            this.InitializeState();
            this.Symbol = symbol;
            this.Color = color;
        }

        public abstract void InitializeState();

        public abstract void Move(MoveDirection direction);
    }

    public enum MoveDirection 
    {
        Up,
        Down,
        Right,
        Left
    }
}
