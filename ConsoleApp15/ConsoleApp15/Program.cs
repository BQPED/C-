using System;

namespace ConsoleApp15
{
    class Program
    {
        enum OkladEnum
        {
            oklad1 = 25000,
            oklad2 = 30000,
            oklad3 = 35000
        }
        static void Main(string[] args)
        {

            Console.WriteLine("==========");

            Console.WriteLine("Классы без экземпляров");
            Human wrk3 = new Ingener("Иванов", "Василий", "Петрович",
            46, Oklad.Oklad3);
            wrk3.Info();
            Human wrk4 = new Ingener("Сидоров", "Семен", "Алексеевич",
            42, Oklad.Oklad3);
            wrk4.Info();
            Oklad.Koeff(1.3f);
            Human wrk5 = new Ingener("Иванов", "Василий", "Петрович",
            46, Oklad.Oklad2);
            wrk5.Info();
            Human wrk6 = new Ingener("Сидоров", "Семен", "Алексеевич",
            42, Oklad.Oklad2);
            wrk6.Info();

            Console.WriteLine("==========");

            Console.WriteLine("Константы");
            Human wrk7 = new Ingener("Иванов", "Василий", "Петрович",
            46, AbsOklad.oklad3);
            wrk7.Info();
            Human wrk8 = new Ingener("Сидоров", "Семен", "Алексеевич",
            42, AbsOklad.oklad2);
            wrk8.Info();

            Console.WriteLine("==========");

            Console.WriteLine("Перечисления");
            Human wrk9 = new Ingener("Иванов", "Василий", "Петрович",
            46, (int)OkladEnum.oklad3);
            wrk9.Info();
            Human wrk10 = new Ingener("Сидоров", "Семен",
            "Алексеевич", 42, (int)OkladEnum.oklad2);
            wrk10.Info();

            Console.WriteLine("==========");

            Console.WriteLine("Метод Format");
            Console.WriteLine(Enum.Format(typeof(OkladEnum), 30000, "G"));
            Console.WriteLine(Enum.Format(typeof(OkladEnum), 30000, "X"));
            Console.WriteLine(Enum.Format(typeof(OkladEnum), 30000, "d"));

            Console.WriteLine("==========");

            Console.WriteLine("метод typeof() и GetValues()");
            int[] a = (int[])Enum.GetValues(typeof(OkladEnum));
            Console.WriteLine(a[1]);

        }
    }
}