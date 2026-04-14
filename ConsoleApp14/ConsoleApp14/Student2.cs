using System;

namespace ConsoleApp14
{
    partial class Student
    {
        public Student(string name, string grup)
        {
            this.name = name;
            this.grup = grup;
        }

        public void F()
        {
            Console.WriteLine(name);
        }
        partial void F1()
        {
            Console.WriteLine(name + " " + grup);
        }
    }
}