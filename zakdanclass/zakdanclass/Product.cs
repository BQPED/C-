using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zakdanclass
{
    public class Product
    {

        //Поля
        private string name;
        private string description;
        private double price;
        private int quantity;


        //Св-ва
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        //методы

        public void AddQuantity(int quantity)
        {
           this.quantity += quantity;
        }
        //Продажа товара , установка новой цены

        public void SellProduct(int quantity)
        {
            if (this.quantity > quantity)
            {
                this.quantity -= quantity;
            }
            else {
                Console.WriteLine("ERROR sell");
            }
        }

        public void SetNewPrice(double price)
        {
            if (price >= 0)
            {
                this.price = price;
            }
            else
            {
                Console.WriteLine("ERROR price");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\n Название - {name}\n Цена = {price}\n Количество = {quantity}\n Описание - {description}");
        }

                //Конструкторы

                public Product()
                {

                }

        public Product(string name, string description, double price, int quantity)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }






    }
}
