using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADO.NET_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Name: ");
            //String name = Console.ReadLine();
            //Console.Write("Age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.Write("Weight: ");
            //double weight = double.Parse(Console.ReadLine());
            //Console.Write("Height: ");
            //double height = double.Parse(Console.ReadLine());
            //Console.Write("Year of training: ");
            //int yearOfTraining = int.Parse(Console.ReadLine());
            //Console.Write("Course: ");
            //int course = int.Parse(Console.ReadLine());
            //Console.Write("Group Number: ");
            //int groupNumber = int.Parse(Console.ReadLine());

            //var student = new Student(name, age, weight, height,
            //yearOfTraining, course, groupNumber);

            var student = new Student("fdg", 25, 65, 1.84, 1999, 2, 222);
            Console.WriteLine(student.Name + " " + student.Age + " " + 
                student.Weight + " " + student.Height + " " + 
                student.YearOfTraining + " " + student.Course + " " + 
                student.GroupNumber);
        }
    }
}
