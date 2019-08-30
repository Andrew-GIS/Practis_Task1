using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class Field
    {
        private int widthWindow;

        private int heightWindow;

        public int FieldWidth
        {
            get { return widthWindow; }

            set
            {
                if (value > 0)
                    widthWindow = value;
            }
        }

        public int FieldHight
        {
            get { return heightWindow; }
            set
            {
                if (value > 0)
                    heightWindow = value;
            }
        }

        public Field()
        {
            widthWindow = 30;
            heightWindow = 30;
            Console.WindowWidth = widthWindow;
            Console.WindowHeight = heightWindow;
        }
    }
}
