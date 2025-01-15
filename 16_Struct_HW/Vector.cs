using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Struct_HW
{
    struct Vector
    {
        private double x; private double y; private double z;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Z { get { return z; } set { z = value; } }
        public Vector(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
        public Vector(double x, double y)
        {
            X = x; Y = y; Z = 0;

        }
        public Vector(double x)
        {
            X = x;
            Y = 0;
            Z = 0;
        }
        public override string ToString()
        {
            return $"({X};{Y};{Z})";
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        public static Vector operator *(Vector b, double a)
        {
            return new Vector(b.X * a, b.Y * a, b.Z * a);
        }
    }
}
