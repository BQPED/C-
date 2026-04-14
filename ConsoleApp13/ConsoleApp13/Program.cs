using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nКлассы как поля");
            Office off1 = new Office();
            off1.Name = "Кафедра математики";
            off1.CountWorker = 12;
            off1.Boss = new Human("Иванов", "Петр", "Николаевич", 46);
            off1.Info();
            Office off2 = new Office("Алексеев","Семен","Михайлович",53 ,"Кафедра физики", 15);
            off2.Info();

            Console.WriteLine("\nВложенные классы");
            Office1 off3 = new Office1("Попов", "Иван", "Петрович", 41, "кафедра химии", 9);
            off3.Info();

            Console.WriteLine("\nОписание операций");
            Human hmn4 = new Human("Васильева", "Александра", "Павловна", 24);
            hmn4.Info();
            hmn4 = !hmn4;
            hmn4.Info();
            hmn4 = hmn4 / "Петрова";
            hmn4.Info();

            Console.WriteLine("\nМассивы пользовательских объектов");
            Human hmn1 = new Human("Иванов", "Василий", "Петрович", 45);
            Human hmn2 = new Human("Титов", "Петр", "Николаевич", 46);
            Human hmn3 = new Human("Васильева", "Александра", "Павловна", 24);
            Human hmn5 = new Human("Шишкин", "Константин", "Алексеевич", 37);
            Human hmn6 = new Human("Николаев", "Алексей", "Иванович", 41);

            Human[] a = { hmn1, hmn2, hmn3, hmn4, hmn5, hmn6 };

            double s = 0;
            for (int k = 0; k < a.Length; k++)
                s += a[k].Age;

            s = Math.Round(s / a.Length, 1);
            Console.WriteLine("Средний возраст сотрудников - {0}", s);

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}