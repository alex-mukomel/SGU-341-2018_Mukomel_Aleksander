using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var triangle = new Triangle(0, 0, 0, 0, 3, 0, 4, 0, 0);
            var triangle = TxtReader.TxtRead("text.txt");
            //var q = new Triangle(null, null, null);
            var p1 = new Point(0, 3, 0);
            //triangle.A = p1;
            Console.WriteLine("Edge AB = " + triangle.EdgeAB + "; Edge BC = " + triangle.EdgeBC + "; Edge AC = " + triangle.EdgeAC);
            Console.WriteLine("Сoordinates of a point:");
            Console.WriteLine("Area of triangle = " + triangle.Area);
            Console.WriteLine("Perimeter of triangle = " + triangle.Perimeter);
            //triangle.By = 0;
        }
    }
}
