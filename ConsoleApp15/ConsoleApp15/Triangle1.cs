using System;

namespace ConsoleApp15
{
    public class Triangle1 : IFigura
    {
        private double a, b, c;

        public Triangle1(double a, double b, double c)
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