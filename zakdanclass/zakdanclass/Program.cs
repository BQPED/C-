using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zakdanclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product p1 = new Product();
            //Console.WriteLine(p1.Name);
            //p1.Name = "Хлеб";
            //Console.WriteLine(p1.Name);

            //Product p2 = new Product();
            //p2.Name = "Молоко";
            //p2.Price = 80;
            //p2.Description = "Описание молока";
            //p2.Quantity = 12;

            //p2.PrintInfo();

            //p2.AddQuantity(5);
            //p2.PrintInfo();

            //p2.SellProduct(3);
            //p2.PrintInfo();

            //p2.SetNewPrice(99);
            //p2.PrintInfo();

            Human h3 = new Human("Васильевич", "Василий", "Иванов", 45);
            Human.getCountHuman();
            Human h1 = new Human();
            h1.Last_Name = "Васильевич";
            h1.Name = "Василий";
            h1.Second_name = "Иванов";
            h1.Age = 45;
            Human.getCountHuman();

            h1.printInfo();

            Human h2 = new Human();
            h2.Last_Name = "Сидоров";
            h2.Name = "Александр";
            h2.Second_name = "Михалович";
            h2.Age = 23;
            Human.getCountHuman();

            Console.WriteLine($"Сотрудник: {h1.Full_name} \n Возраст: {h2.Age}");
            h3.printInfo();
            Human.getCountHuman();
        }
    }
}
