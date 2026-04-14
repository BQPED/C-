using System;

namespace ConsoleApp15
{
    public class Rectangle3 : ISquare2, IPerimeter3
    {
        private double a, b;

        public Rectangle3(double a, double b)
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