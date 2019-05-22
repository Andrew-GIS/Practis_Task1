using Practis_Task1.Task1_Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1_Figure
{
    public abstract class FigureWithPolymorphism
    {
        public double CenterCoordinates { get; set; }

        public FigureWithPolymorphism(double centetCoordinates)
        {
            this.CenterCoordinates = centetCoordinates;
        }

        public abstract void Draw();
    }
}

class CirclePol : FigureWithPolymorphism
{
    public double CircleRadius { get; }

    public CirclePol(double circleRadius, double centerCoordinates)
        : base(centerCoordinates)
    {
        this.CircleRadius = circleRadius;
        CenterCoordinates = centerCoordinates;
    }
    public override void Draw()
    {
        Console.WriteLine($"Circle with radius {this.CircleRadius}m has {CenterCoordinates} center coordinates");
    }
}

class TrianglePol : FigureWithPolymorphism
{
    public double SideA { get; }

    public double SideB { get; }

    public double SideC { get; }

    public TrianglePol(double sideA, double sideB, double sideC, double centerCoordinates)
     : base(centerCoordinates)
    {
        this.SideA = sideA;
        this.SideB = sideB;
        this.SideC = sideC;
        CenterCoordinates = centerCoordinates;
    }

    public override void Draw()
    {
        Console.WriteLine($"Triangle with sides A = {this.SideA}m, B = {this.SideB}m, C = {this.SideC}m has {CenterCoordinates} center coordinates");
    }
}

class SquarePol : FigureWithPolymorphism
{
    public double Side { get; }

    public SquarePol(double side, double centerCoordinates)
     : base(centerCoordinates)
    {
        this.Side = side;
        CenterCoordinates = centerCoordinates;
    }

    public override void Draw()
    {
        Console.WriteLine($"Square with sides {this.Side}m has {CenterCoordinates} center coordinates");
    }
}

class DrawingFigurePol
{
    public static void Execute()
    {
        FigureWithPolymorphism[] figures =
        {
    new CirclePol(10, 55.45),
    new SquarePol(4.5, 22.15),
    new TrianglePol(5, 6.6, 7.5, 76.34),
     };

        foreach (var item in figures)
        {
            item.Draw();
        }
    }
}
