using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_1
{
    public class Triangle
    {
        private const int TWO = 2;

        private Point _a;
        private Point _b;
        private Point _c;

        #region Properties
        public Point A
        {
            get
            {
                return A;
            }
            set
            {
                if(!IsCorrect(value, _b, _c))
                {
                    throw new ArgumentException("Incorrect parameters");
                }
                _a = value;
            }
        }
        public Point B
        {
            get
            {
                return B;
            }
            set
            {
                if (!IsCorrect(_a, value, _c))
                {
                    throw new ArgumentException("Incorrect parameters");
                }
                _b = value;
            }
        }
        public Point C
        {
            get
            {
                return C;
            }
            set
            {
                if (!IsCorrect(_a, _b, value))
                {
                    throw new ArgumentException("Incorrect parameters");
                }
                _c = value;
            }
        }

        public double EdgeAB
        {
            get
            {
                return Math.Sqrt((Math.Pow(_a.X - _b.X, TWO) + Math.Pow(_a.Y - _b.Y, TWO)) + Math.Pow(_a.Z - _b.Z, TWO));
            }
        }
        public double EdgeBC
        {
            get
            {
                return Math.Sqrt((Math.Pow(_b.X - _c.X, TWO) + Math.Pow(_b.Y - _c.Y, TWO)) + Math.Pow(_b.Z - _c.Z, TWO));
            }
        }
        public double EdgeAC
        {
            get
            {
                return Math.Sqrt((Math.Pow(_a.X - _c.X, TWO) + Math.Pow(_a.Y - _c.Y, TWO)) + Math.Pow(_a.Z - _c.Z, TWO));
            }
        }

        public double Perimeter
        {
            get
            {
                return EdgeAB + EdgeBC + EdgeAC;
            }
        }
        public double Area
        {
            get
            {
                return Math.Sqrt((Perimeter / TWO - EdgeAB) * (Perimeter / TWO - EdgeBC) * (Perimeter / TWO - EdgeAC) * Perimeter / TWO);
            }
        }
        #endregion

        #region Constructors
        /// <summary> Creating a Triangle class object </summary>
        public Triangle(Point a, Point b, Point c)
        {
            if (!IsCorrect(a, b, c))
            {
                throw new ArgumentException("Incorrect parameters");
            }
            _a = a;
            _b = b;
            _c = c;
        }

        /// <summary> Creating a Triangle class object in 2D</summary>
        public Triangle(double ax, double ay, double bx, double by, double cx, double cy) : 
            this(new Point(ax, ay, 0), new Point(bx, by, 0), new Point(cx, cy, 0)) { }

        /// <summary> Creating a Triangle class object in 3D </summary>
        public Triangle(double ax, double ay, double az, double bx, double by, double bz, double cx, double cy, double cz) :
            this(new Point(ax, ay, az), new Point(bx, by, bz), new Point(cx, cy, cz)) { }

        #endregion

        public bool IsCorrect(Point a, Point b, Point c)
        {
            if (a == null || b == null || c == null)
            {
                throw new ArgumentNullException(".....");
            }

            return (a != b && a != c && b != c);
        }
    }
}
