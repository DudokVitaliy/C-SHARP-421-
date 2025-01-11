using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Overload_operators
{
    partial class Fraction
    {
        private int num;
        private int demon;
        public int Num { get=> num ; set => num = value; }
        public int Demon { get => demon; set => demon = value != 0 ? value : -1; }
        public override string ToString()
        {
            return $"{num}/{demon}";
        }
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return num;
                    case 1: return demon;
                    default:
                        return -1;
                }
            }
            set
            {
                switch (index)
                {
                    case 0: num = value; break;
                    case 1: Demon = value; break;
                    default:
                        return;
                }
            }
        }
        public Fraction(int num, int demon)
        {
            Num = num;
            Demon = demon;
        }
    }
}
