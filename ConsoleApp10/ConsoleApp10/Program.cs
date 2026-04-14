using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = Int32.Parse(Console.ReadLine());
            double c = a + b;
            Console.WriteLine("Сумма = " + c);
            double d = a - b;
            double e = a * b;
            double f = a / b;
            Console.WriteLine($"разница = {d}");
            Console.WriteLine($"произведение = {e}");
            Console.WriteLine($"деление = {f}");
            if (a > b)
            {
                Console.WriteLine("max = a");
            }
            else
            {
                Console.WriteLine("max = b");
            }
            double m = 3;
            double n = 1;
            double x = (m * m) - (m / n);
            if (x / 2 == 0)
            {
                Console.WriteLine("чётное");
            }
            else
            {
                Console.WriteLine("нечётное");
            } 
                
        }
    }
}
