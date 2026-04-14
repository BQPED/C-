using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _313131313131313131
{
    class PersonId5<T, P> : Person2<T>
    {
        private P id;
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
        public PersonId5(string name, T info, P id) :
        base(name, info)
        {
            this.id = id;
        }
    }
}
