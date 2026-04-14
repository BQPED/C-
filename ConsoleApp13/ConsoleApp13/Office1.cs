using System;

namespace ConsoleApp13
{
    class Office1
    {
        private Human1 boss;
        private string name;
        private int countworker;
        private class Human1
        {
            private string name;
            private string secondname;
            private string lastname;
            private int age;

            public string FullName
            {
                get
                {
                    return name + " " + secondname + " " + lastname;
                }
            }

            public void Info()
            {
                Console.WriteLine(lastname + " " + name + " " + secondname + "," + age + Option());
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

            public Human1(string lastname, string name, string secondname, int age)
            {
                this.lastname = lastname;
                this.name = name;
                this.secondname = secondname;
                this.age = age;
            }
        }

        public void Info()
        {
            Console.WriteLine("Подразделение: {0}, работающих {1} человек", name, countworker);
            boss.Info();
        }

        public Office1(string lastname, string name, string secondname, int age, string name1, int countworker)
        {
            this.name = name1;
            this.countworker = countworker;
            boss = new Human1(lastname, name, secondname, age);
        }
    }
}