using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapesArea
{
    public abstract class Shape
    {
        public double Area { get => CalculateArea(); }
        public abstract double CalculateArea();
        protected List<double> Sides;
        protected void SidesChecing()
        {
                foreach (var side in Sides)
                {
                    if (side == 0)
                        throw new ArgumentException("Отрезок не может быть равен нулю!");
                    if (side < 0)
                        throw new ArgumentException("Отрезок не может быть отрицательным!");
                    if (side>double.MaxValue)
                        throw new ArgumentException("Слишком большое значение!");
            }
        }
    }
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Sides = new List<double> { radius };
            SidesChecing();
        }
        public override double CalculateArea()
        {
            return (Math.PI * Sides[0] * Sides[0]);
        }
    }
    public class Triangle : Shape
    {
        public Triangle(double side1, double side2, double side3)
        {
            Sides = new List<double> { side1, side2, side3 };
            SidesChecing();
        }
        public override double CalculateArea()
        {
            double p = Sides.Sum() / 2;
            return (Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2])));
        }
        public bool? IsRectangular()
        {
            if (double.IsInfinity(Math.Pow(Sides[0], 2)) ||
                double.IsInfinity(Math.Pow(Sides[1], 2)) ||
                double.IsInfinity(Math.Pow(Sides[2], 2)))
                return null;
            if ((Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) == Math.Pow(Sides[2], 2)) ||
                (Math.Pow(Sides[0], 2) + Math.Pow(Sides[2], 2) == Math.Pow(Sides[1], 2)) ||
                (Math.Pow(Sides[2], 2) + Math.Pow(Sides[1], 2) == Math.Pow(Sides[0], 2)))
            {
                return true;
            }
            else return false;
        }
    }
}
