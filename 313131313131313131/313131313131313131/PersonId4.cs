using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _313131313131313131
{
    class PersonId4<P> : Person2<char>
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
        public PersonId4(string name, char info, P id) :
        base(name, info)
        {
            this.id = id;
        }
    }
}
