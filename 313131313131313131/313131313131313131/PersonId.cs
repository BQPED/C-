using project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _313131313131313131
{
    class PersonId : Person1
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
        public PersonId(string name, object info, int id) :
        base(name, info)
        {
            this.id = id;
        }
    }
}
