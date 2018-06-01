using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_1
{
    public class Point : IEquatable<Point>
    {
        /// <summary> Creating a Point class object </summary>
        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static bool operator ==(Point p1, Point p2)
        {
            if ((object)p1 == null && (object)p2 == null)
            {
                return true;
            }
            return ((object)p2 == null && p1.Equals(p2)) || p1.Equals(p2);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Point);
        }

        public bool Equals(Point obj)
        {
            if ((object)obj == null)
                return false;

            if (GetHashCode() != obj.GetHashCode())
            {
                return false;
            }

            return this.X == obj.X && this.Y == obj.Y && this.Z == obj.Z;
        }
    }
}
