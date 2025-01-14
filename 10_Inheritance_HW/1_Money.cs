using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal class _1_Money
    {
        protected int dollar;
        protected int cent;
        public int Dollar
        {
            get => dollar;
            set
            {
                if(value < 0)
                {
                    dollar = 0;
                }
                else
                {
                    dollar = value;
                }
            }
        }
        public int Cent { get => cent;
            set
            {
                if (value < 0)
                    cent = 0;
                else if (value > 99)
                {
                    int temp = value / 100;
                    dollar += temp;
                    cent = value % 100;
                }
                else 
                    cent = value;
            }
        }
        public _1_Money(int dol = 0, int cen = 0)
        {
            Dollar = dol;
            Cent = cen;
        }
        public override string ToString()
        {
            return $"\t${Dollar,5}.{Cent,2}";
        }
    }
}
