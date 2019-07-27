using System;
using Shapes.Abstractions;

namespace Shapes.Shapes
{
    public class Triangle : ITriangle
    {
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsRightTriangle => 
            Math.Pow(A,2) + Math.Pow(B,2) == Math.Pow(C, 2) || 
            Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2) ||
            Math.Pow(B, 2) + Math.Pow(C, 2) == Math.Pow(A, 2);

        public double A { get; }
        public double B { get; }
        public double C { get; }

        public double CalculateArea()
        {
            var p = CalculateSemiPerimeter();

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        private Double CalculateSemiPerimeter()
        {
            return (A + B + C) / 2;
        }
    }
}
