using System;

namespace ConsoleApp15
{
    public class Ingener : Human
    {
        private int oklad;

        public override int ZarPlata()
        {
            return oklad;
        }

        public Ingener(string lastname, string name, string secondname, int age, int oklad)
            : base(lastname, name, secondname, age)
        {
            this.oklad = oklad;
        }
    }
}