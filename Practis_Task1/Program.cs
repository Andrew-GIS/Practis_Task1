using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle { SideA = 10, SideB = 20 };
            PrintFigure(rectangle);
        }

        static void PrintFigure(IGeometrical figure)
        {
            Console.WriteLine("Area" + figure.GetArea());
            Console.WriteLine(figure.GetPerimetr());
        }
    }
}

interface IGeometrical
{
    double GetPerimetr();
    double GetArea();
}

class Rectangle : IGeometrical
{
    public double SideA { get; set; }
    public double SideB { get; set; }

    public double GetArea()
    {
        return (this.SideA * this.SideB);
    }
    public double GetPerimetr ()
    {
        return((this.SideB + this.SideA)*2);
    }
}

//class Circle : IGeometrical
//{
//    public int SideA { get; set; }
//    public int SideB { get; set; }

//    public int GetArea()
//    {
//        return (this.SideA * this.SideB);
//    }
//    public double GetPerimetr()
//    {
//        return (this.SideB * this.SideA);
//    }
//}







