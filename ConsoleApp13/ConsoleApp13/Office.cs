using System;

namespace ConsoleApp13
{
    class Office
    {
        private Human boss;
        private string name;
        private int countworker;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int CountWorker
        {
            set { countworker = value; }
            get { return countworker; }
        }

        public Human Boss
        {
            set { boss = value; }
            get { return boss; }
        }

        public void Info()
        {
            Console.WriteLine("Подразделение: {0}, работающих {1} человек", name, countworker);
            if (boss != null)
                boss.Info();
        }

        public Office()
        {
        }

        public Office(string lastname, string name, string secondname, int age, string name1, int countworker)
        {
            this.name = name1;
            this.countworker = countworker;
            boss = new Human(lastname, name, secondname, age);
        }
    }
}