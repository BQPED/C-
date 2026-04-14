using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Product
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Товар {Name}, Категория {Category}, Цена {Price}, Количество {Quantity}";
        }
    }
}
