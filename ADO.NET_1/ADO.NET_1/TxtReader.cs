using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_1
{
    static class TxtReader
    {
        /// <summary> Reading the coordinates of points from txt and Creating a Triangle class object </summary>
        static public Triangle TxtRead(string name)
        {
            using (StreamReader file = new StreamReader(name))
            {
                string line = file.ReadLine();
                char[] charSeparators = new char[] {' '};
                string[] arr = line.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                if (arr.Length != 6 && arr.Length != 9)
                {
                    throw new ArgumentException("Incorrect parameters");
                }
                try
                {
                    if (arr.Length == 9)
                    {
                        return new Triangle(double.Parse(arr[0]), double.Parse(arr[1]), double.Parse(arr[2]),
                            double.Parse(arr[3]), double.Parse(arr[4]), double.Parse(arr[5]),
                            double.Parse(arr[6]), double.Parse(arr[7]), double.Parse(arr[8]));
                    }
                    else
                    {
                        return new Triangle(double.Parse(arr[0]), double.Parse(arr[1]), double.Parse(arr[2]),
                            double.Parse(arr[3]), double.Parse(arr[4]), double.Parse(arr[5]));
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex);
                    return null;
                }
            }
        }
    }
}
