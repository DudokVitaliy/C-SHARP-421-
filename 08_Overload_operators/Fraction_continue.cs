using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Overload_operators
{
    // перезавантаження операторів
    // оператори рівності перевантажуються парами
    // true and faulse перевантажуються парами
    // implicit, explicit 
    // ++i --i

    partial class Fraction
    {
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int num = a.num * b.demon + b.num * a.demon;
            int demon = a.demon * b.demon;
            return new Fraction(num, demon);
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            if (a is null || b is null ) return false;
            return a.num == b.num && a.demon == b.demon;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
        public static bool operator true(Fraction a)
        {
            return a.num != 0;
        }
        public static bool operator false(Fraction a)
        {
            return a.num == 0;
        }
        public static Fraction operator ++(Fraction a)
        {
            Fraction fraction = new Fraction(1, 1);
            return a + fraction;
        }
        public static explicit operator int(Fraction a)
        {
            return a.num / a.demon;
        }
        public static implicit operator double(Fraction a)
        {
            return (double)a.num / (double)a.demon;
        }
    }
}
