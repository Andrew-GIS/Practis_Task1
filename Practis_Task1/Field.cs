using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Field
    {
        private int startX {get;}
        private int startY {get;}
        public int Width { get; }
        public int Height { get; }
        private List<Figure> figures;

        public Field()
        {
            Width = 10;
            Height = 20;
        }

        public void Initialize()
        {
            Console.BackgroundColor = ConsoleColor.Gray;

            List<Figure> figures = new List<Figure>
            {
                new MyCar('*', ConsoleColor.White),
                new OtherCar('^', ConsoleColor.Red),
                new OtherCar('^', ConsoleColor.Green),
                new OtherCar('^', ConsoleColor.Blue),
                new RoadBorder('|', ConsoleColor.White)
            };
        }

        public bool IsPositionFree(Figure figure)
        {

        }

    }
}
