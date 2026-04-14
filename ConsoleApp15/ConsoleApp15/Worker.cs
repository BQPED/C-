using System;

namespace ConsoleApp15
{
    public class Worker : Human
    {
        private int tarif;
        private int countday;

        public override int ZarPlata()
        {
            return tarif * countday;
        }

        public Worker(string lastname, string name, string secondname, int age, int tarif, int countday)
            : base(lastname, name, secondname, age)
        {
            this.tarif = tarif;
            this.countday = countday;
        }
    }
}