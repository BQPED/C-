using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Rectangle : Figure
    {
        double a, b;
public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Square()
        {
            return a * b;
        }
        public override double Perimeter()
        {
            return (a + b) * 2;
        }
    }
}
