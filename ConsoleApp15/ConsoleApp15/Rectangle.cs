using System;

namespace ConsoleApp15
{
    public class Rectangle : Figure
    {
        private double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double GetSquare()
        {
            return a * b;
        }

        public override double Perimeter()
        {
            return (a + b) * 2;
        }
    }
}