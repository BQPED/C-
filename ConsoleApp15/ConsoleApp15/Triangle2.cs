using System;

namespace ConsoleApp15
{
    public class Triangle2 : IFigura2
    {
        private double a, b, c;

        public Triangle2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetSquare()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double Perimeter()
        {
            return a + b + c;
        }
    }
}