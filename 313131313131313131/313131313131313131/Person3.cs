using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _313131313131313131
{
    internal class Person3<T,P>
    {
        private string name;
        private T info;
        private P id;
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
        public P Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public Person3(string name, T info, P id)
        {
            this.name = name;
            this.info = info;
            this.id = id;
        }
    }
}
