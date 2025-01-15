using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Struct_HW
{
    struct Fraction
    {
        public int num;
        public int den;
        public int Num { get => num; set => num = value; }
        public int Den { get => den; set => den = value != 0 ? value : -1; }
        public Fraction(int num, int den)
        {
            Num = num;
            Den = den;
        }
        public override string ToString()
        {
            return $"{num}/{den}";
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int num = a.num * b.den + b.num * a.den;
            int den = a.den * b.den;
            return new Fraction(num, den);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            int num = a.num * b.den - b.num * a.den;
            int den = a.den * b.den;
            return new Fraction(num, den);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            int num = a.num *  b.num;
            int den = a.den * b.den;
            return new Fraction(num, den);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            int num = a.num * b.den;
            int den = a.den * b.num;
            return new Fraction(num, den);
        }
    }
}
