using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13Lab2_3DVectors
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(
                v1.X + v2.X,
                v1.Y + v2.Y,
                v1.Z + v2.Z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(
                v1.X - v2.X,
                v1.Y - v2.Y,
                v1.Z - v2.Z);
        }

        public static Vector operator -(Vector v)
        {
            return new Vector(
                -v.X,
                -v.Y,
                -v.Z);
        }

        public static Vector operator *(Vector v, int scalar)
        {
            return new Vector(
                v.X * scalar,
                v.Y * scalar,
                v.Z * scalar);
        }

        public static Vector operator /(Vector v, int scalar)
        {
            return new Vector(
                v.X / scalar,
                v.Y / scalar,
                v.Z / scalar);
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", X, Y, Z);
        }
    }
}
