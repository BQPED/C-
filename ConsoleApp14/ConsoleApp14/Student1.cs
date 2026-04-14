using System;

namespace ConsoleApp14
{
    partial class Student
    {
        private string name;
        private string grup;

        partial void F1();

        public void G()
        {
            Console.WriteLine(grup);
        }

        public void G1()
        {
            F1();
        }
    }
}