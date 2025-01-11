using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _08_Overload_operators_HW
{
    internal class Vector
    {
        private double x; private double y;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public Vector(double x, double y)
        {
            X = x; Y = y;
        }
        public Vector(double x)
        {
            X = x;
            Y = 0;
        }
        public override string ToString()
        {
            return $"({X};{Y})";
        }
        public double Length()
        {
            return Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }
        public static Vector operator *(Vector b, double a)
        {
            return new Vector(b.X * a, b.Y * a);
        }
        public static double operator *(Vector a, Vector b)
        {
            return a.X * a.Y + b.X * b.Y;
        }
        public static bool operator ==(Vector a, Vector b)
        {
            return a.Length() == b.Length();
        }
        public static bool operator !=(Vector a, Vector b)
        {
            return !(a == b);
        }
        public static explicit operator double(Vector x)
        {
            return x.Length();
        }
        public static implicit operator Vector(double x)
        {
            return new Vector(x);
        }
        public static Vector operator ++(Vector a)
        {
            return new Vector(a.X + 1, a.Y + 1);
        }
        public static Vector operator --(Vector a)
        {
            return new Vector(a.X - 1, a.Y - 1);
        }
        public static Vector operator -(Vector a)
        {
            return new Vector(-a.X, -a.Y);
        }
        public static bool operator true(Vector a)
        {
            return a.X != 0 || a.Y != 0;
        }
        public static bool operator false(Vector a)
        {
            return a.X == 0 && a.Y == 0;
        }
        public double this[int a]
        {
            get
            {
                switch (a)
                {
                    case 0:
                        return this.X;
                    case 1:
                        return this.Y;
                    default:
                        return 0;
                }
            }
            set
            {
                switch (a)
                {
                    case 0:
                        this.X = value;
                        break;
                    case 1:
                        this.Y = value;
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
