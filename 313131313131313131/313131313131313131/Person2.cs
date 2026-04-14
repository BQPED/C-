using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _313131313131313131
{
    internal class Person2<T>
    {
        private string name;
        private T info;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public T Info
        {
            set
            {
                info = value;
            }
            get
            {
                return info;
            }
        }
        public Person2(string name, T info)
        {
            this.name = name;
            this.info = info;
        }
        static private T code;
        static public T Code
        {
            set
            {
                code = value;
            }
            get
            {
                return code;
            }
        }
    }
}
