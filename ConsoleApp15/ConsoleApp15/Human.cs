using System;

namespace ConsoleApp15
{
    public abstract class Human
    {
        protected string name;
        protected string secondname;
        protected string lastname;
        protected int age;

        public abstract int ZarPlata();

        public void Info()
        {
            Console.WriteLine("{0} {1} {2}, {3}{4}, зарплата {5} руб",
                lastname, name, secondname, age, Option(), ZarPlata());
        }

        private string Option()
        {
            string s;
            if (age > 10 && age <= 20)
                s = " лет";
            else
            {
                switch (age % 10)
                {
                    case 1:
                        s = " год";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        s = " года";
                        break;
                    default:
                        s = " лет";
                        break;
                }
            }
            return s;
        }

        public Human(string lastname, string name, string secondname, int age)
        {
            this.lastname = lastname;
            this.name = name;
            this.secondname = secondname;
            this.age = age;
        }
    }
}