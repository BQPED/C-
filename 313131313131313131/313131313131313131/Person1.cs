using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Person1
    {
        private string name;
        private object info;
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
        public object Info
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
        public Person1(string name, object info)
        {
            this.name = name;
            this.info = info;
        }
    }
}
