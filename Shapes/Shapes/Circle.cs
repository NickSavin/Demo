using System;
using Shapes.Abstractions;

namespace Shapes.Shapes
{
    public class Circle : ICircle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
    }
}
