using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Oklad
    {
        static private int oklad1 = 25000;
        static private int oklad2 = 30000;
        static private int oklad3 = 35000;
        static public int Oklad1
        {
            get
            {
                return oklad1;
            }
        }
        static public int Oklad2
        {
            get
            {
                return oklad2;
            }
        }
        static public int Oklad3
        {
            get
            {
                return oklad3;
            }
        }
        static public void Koeff(float k)
        {
            oklad1 = (int)(oklad1 * k);
            oklad2 = (int)(oklad2 * k);
            oklad3 = (int)(oklad3 * k);
        }
        private Oklad()
        {
        }
    }
}
