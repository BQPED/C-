using System;
using System.Security.Cryptography;

namespace ConsoleApp14
{
    internal class HumanCl
    {
        private string name;
        private string secondname;
        private string lastname;
        private int age;

        public HumanCl()
        {
        }

        public HumanCl(string lastname, string name, string secondname, int age)
        {
            this.lastname = lastname;
            this.name = name;
            this.secondname = secondname;
            this.age = age;
        }
        public string Name
        {
            set { name = value; }
        }

        public string SecondName
        {
            set { secondname = value; }
        }

        public string LastName
        {
            set { lastname = value; }
        }

        public int Age
        {
            set { age = value; }
        }

        public void Info()
        {
            Console.WriteLine(lastname + " " + name + " " + secondname + ", " + age + Option());
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
        class Worker : HumanCl
        {
            private int tarif;
            public int Tarif
            {
                set
                {
                    tarif = value;
                }
            }
            public int ZarPlata(int countday)
            {
                return tarif * countday;
            }
        }
    }
}