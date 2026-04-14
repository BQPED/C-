using System;

namespace ConsoleApp15
{
    public class Rectangle1 : IFigura
    {
        private double a, b;

        public Rectangle1(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double GetSquare()
        {
            return a * b;
        }

        public double Perimeter()
        {
            return (a + b) * 2;
        }
    }
}