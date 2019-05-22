using Practis_Task1.Task1_Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1_Figure
{
    public class Figure
    {
            public double CenterCoordinates { get; set; }

            public Figure(double centetCoordinates)
            {
                this.CenterCoordinates = centetCoordinates;
            }
    }
}

public class Circle : Figure
{
    public double CircleRadius { get; }

    public Circle(double circleRadius, double centerCoordinates)
     : base(centerCoordinates)
    {
        this.CircleRadius = circleRadius;
        CenterCoordinates = centerCoordinates;
    }

    public void Draw()
    {
        Console.WriteLine($"Circle with radius {this.CircleRadius}m has {CenterCoordinates} center coordinates");
    }
}

class Triangle : Figure
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC, double centerCoordianates)
        : base(centerCoordianates)
    {
        this.SideA = sideA;
        this.SideA = sideB;
        this.SideC = sideC;
        CenterCoordinates = centerCoordianates;
    }

    public void Draw()
    {
        Console.WriteLine($"Triangular with sides: {SideA}, {SideB}, {SideC} and center in coodinate {CenterCoordinates}");
    }
}

class Square : Figure
{
    public double Side { get; }

    public Square(double side, double centerCoordinates)
        : base(centerCoordinates)
    {
        this.Side = side;
        CenterCoordinates = centerCoordinates;
    }

    public void Draw()
    {
        Console.WriteLine($"Square with sides {this.Side}m has {CenterCoordinates} center coordinates");
    }
}

class FigureDrawing
{
    public static void Execute()
    {
        Figure[] figures =
          {
    new Circle(10, 55.45),
    new Circle(4.6, 33.11),
    new Square(4.5, 22.15),
    new Square(12, 34.89),
    new Triangle(5, 6.6, 7.5, 76.34),
    new Triangle(4.2, 8.7, 4, 35.21)
     };

        foreach (var item in figures)
        {
            if (item is Circle circle)
            {
                circle.Draw();
            }
            else if (item is Triangle triangle)
            {
                triangle.Draw();
            }
            else if (item is Square square)
            {
                square.Draw();
            }
        }
    }
}