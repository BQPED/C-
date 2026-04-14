using System;

namespace ConsoleApp15
{
    public class Square : Figure
    {
        private double a;

        public Square(double a)
        {
            this.a = a;
        }

        public override double GetSquare()
        {
            return a * a;
        }

        public override double Perimeter()
        {
            return 4 * a;
        }
    }
}