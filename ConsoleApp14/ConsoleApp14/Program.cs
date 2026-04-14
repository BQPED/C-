using ConsoleApp14;
using System;

namespace InheritanceExample
{
    class Human
    {
        protected string lastName;
        protected string name;
        protected string secondName;
        protected int age;
        private string password;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Password
        {
            set { password = value; }
        }

        public string FullName
        {
            get { return $"{lastName} {name} {secondName}"; }
        }

        public Human()
        {
            Console.WriteLine("Вы используете класс Human");
        }

        public Human(string lastname, string name, string secondname, int age)
        {
            this.lastName = lastname;
            this.name = name;
            this.secondName = secondname;
            this.age = age;
        }

        // Переопределение методов System.Object
        public override bool Equals(object ob)
        {
            if (ob is Human hmn)
            {
                return name == hmn.name &&
                       lastName == hmn.lastName &&
                       secondName == hmn.secondName &&
                       age == hmn.age;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{lastName} {name} {secondName}, {age}{Option()}";
        }

        public virtual void Info()
        {
            Console.WriteLine(ToString());
            Console.WriteLine("Введите пароль");
            string inputPassword = Console.ReadLine();
            Password = inputPassword;
        }

        protected string Option()
        {
            string s;
            if (age >= 11 && age <= 20)
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
    }

    class Worker : Human
    {
        private int tarif;

        public int Tarif
        {
            get { return tarif; }
            set { tarif = value; }
        }

        public int ZarPlata(int countday)
        {
            return tarif * countday;
        }

        public Worker() : base()
        {
        }

        public Worker(string lastname, string name, string secondname, int age, int tarif) :
        base(lastname, name, secondname, age)
        {
            this.tarif = tarif;
        }

        public override void Info()
        {
            Console.WriteLine($"{lastName} {name} {secondName}, {age}{Option()}, {tarif} руб/день");
        }

        public override string ToString()
        {
            return $"{lastName} {name} {secondName}, {age}{Option()}, {tarif} руб/день";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== System.Object ===\n");

            Object ob1 = new Object();
            Object ob2 = ob1;
            Object ob3 = new Object();

            Console.WriteLine($"Equals: {ob1.Equals(ob2)}");
            Console.WriteLine($"Equals: {ob1.Equals(ob3)}");
            Console.WriteLine($"GetHashCode: {ob1.GetHashCode()}");
            Console.WriteLine($"GetHashCode: {ob2.GetHashCode()}");
            Console.WriteLine($"GetHashCode: {ob3.GetHashCode()}");
            Console.WriteLine($"GetType: {ob1.GetType()}");
            Console.WriteLine($"ToString: {ob1.ToString()}");

            Console.WriteLine("\n=============================\n");

            Object s1 = "Hello";
            Object s2 = s1;
            Object s3 = "Hello";

            Console.WriteLine($"Equals: {s1.Equals(s2)}");
            Console.WriteLine($"Equals: {s1.Equals(s3)}");
            Console.WriteLine($"GetHashCode: {s1.GetHashCode()}");
            Console.WriteLine($"GetType: {s1.GetType()}");
            Console.WriteLine($"ToString: {s1.ToString()}");

            Console.WriteLine("\n=============================\n");

            Object n1 = 3;
            Object n2 = n1;
            Object n3 = 3;

            Console.WriteLine($"Equals: {n1.Equals(n2)}");
            Console.WriteLine($"Equals: {n1.Equals(n3)}");
            Console.WriteLine($"GetHashCode: {n1.GetHashCode()}");
            Console.WriteLine($"GetType: {n1.GetType()}");
            Console.WriteLine($"ToString: {n1.ToString()}");

            Console.WriteLine("\n=============================\n");

            Human h1 = new Human("Иванов", "Иван", "Иванович", 30);
            Human h2 = new Human("Иванов", "Иван", "Иванович", 30);
            Human h3 = new Human("Петров", "Петр", "Петрович", 25);

            Console.WriteLine($"Equals: {h1.Equals(h2)}");
            Console.WriteLine($"Equals: {h1.Equals(h3)}");
            Console.WriteLine($"ToString h1: {h1.ToString()}");
            Console.WriteLine($"ToString h3: {h3.ToString()}");

            Console.WriteLine("\n=============================\n");

            Worker w1 = new Worker("Сидоров", "Александр", "Михайлович", 42, 2000);
            Worker w2 = new Worker("Сидоров", "Александр", "Михайлович", 42, 2000);

            Console.WriteLine($"Equals: {w1.Equals(w2)}");
            Console.WriteLine($"ToString: {w1.ToString()}");
            Console.WriteLine($"GetType: {w1.GetType()}");

            Console.WriteLine("\n=============================\n");

            Human humanRef = new Worker("Петров", "Сергей", "Иванович", 35, 2500);
            humanRef.Info();

            Console.WriteLine($"\nGetType: {humanRef.GetType()}");
            Console.WriteLine($"is Human: {humanRef is Human}");
            Console.WriteLine($"is Worker: {humanRef is Worker}");

            Console.WriteLine("\n=============================\n");

            Figure f1, f2;
            f1 = new Triangle(3, 4, 5);
            f2 = new Rectangle(2, 6);
            Console.WriteLine(f1.Perimeter() + ", " + f1.Square());
            Console.WriteLine(f2.Perimeter() + ", " + f2.Square());
        }
    }
}