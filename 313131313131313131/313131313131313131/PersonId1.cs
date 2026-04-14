using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _313131313131313131
{
    class PersonId1<T> : Person2<T>
    {
        private int id;
        public int Id
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
            public PersonId1(string name, T info, int id) : base(name, info)
            {
            this.id = id;
            }
    }
}

