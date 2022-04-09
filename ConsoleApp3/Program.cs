using System;

namespace ConsoleApp3
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 6, 7);
            triangle.SquareFigure();
            triangle.PerimeterFigure();

        }
    }

    public abstract class GeometricFigure
    {

        public abstract double SquareFigure();
        public abstract void PerimeterFigure();
    }

    class Triangle : GeometricFigure
    {

        double _sideA;
        double _sideB;
        double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double SquareFigure()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            Console.WriteLine($"Square of Triangle: {Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC))}");
            return p;

        }

        public override void PerimeterFigure()
        {
            Console.WriteLine($"Perimeter of Triangle: {_sideA + _sideB + _sideC}\n");

        }
    }
}