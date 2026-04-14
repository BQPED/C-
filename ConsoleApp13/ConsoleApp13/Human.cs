using System;

namespace ConsoleApp13
{
    class Human
    {
        private string lastname;
        private string name;
        private string secondname;
        private int age;

        public int Age
        {
            get { return age; }
        }

        public Human(string lastname, string name, string secondname, int age)
        {
            this.lastname = lastname;
            this.name = name;
            this.secondname = secondname;
            this.age = age;
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

        public static Human operator !(Human a)
        {
            return new Human(a.lastname, a.name, a.secondname, a.age + 1);
        }

        public static Human operator /(Human a, string s)
        {
            return new Human(s, a.name, a.secondname, a.age);
        }
    }
}