using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADO.NET_2
{
    public class Student : Man
    {
        private const string regName = @"(^[a-zA-Z]{2,20}$)";
        private const string regYearOfTraining = @"(^([1][9][6-9][0-9]|[2][0][0-2][0-9])+$)";
        private const string regGroupNumber = @"(^([1-6][1-9][1-3])+$)";

        private int _yearOfTraining;
        private int _course;
        private int _groupNumber;

        public int YearOfTraining
        {
            get
            {
                return _yearOfTraining;
            }
            set
            {
                if (!IsNotCorrect(Name, Age, Weight, Height, value,
                    _course, _groupNumber))
                {
                    _yearOfTraining = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect parameters");
                }
            }
        }
        public int Course
        {
            get
            {
                return _course;
            }
            set
            {
                if (!IsNotCorrect(Name, Age, Weight, Height, _yearOfTraining,
                   value, _groupNumber))
                {
                    _course = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect parameters");
                }
            }
        }
        public int GroupNumber
        {
            get
            {
                return _groupNumber;
            }
            set
            {
                if (!IsNotCorrect(Name, Age, Weight, Height, _yearOfTraining,
                   _course, value))
                {
                    _groupNumber = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect parameters");
                }
            }
        }

        /// <summary> Creating a Student class object </summary>
        public Student(String name, int age, double weight, double height,
            int yearOfTraining, int course, int groupNumber)
            : base(name, age, weight, height)
        {
            if(IsNotCorrect(name, age, weight, height, yearOfTraining, 
                course, groupNumber))
            {
                throw new ArgumentException("Incorrect parameters");
            }
            _yearOfTraining = yearOfTraining;
            _course = course;
            _groupNumber = groupNumber;
        }

        public bool IsNotCorrect(String name, int age, double weight, double height,
            int yearOfTraining, int course, int groupNumber)
        {
            return (!Regex.IsMatch(name, regName) || age < 17 || age > 120 ||
                weight < 1.0 || weight > 300.0 || height < 0.20 || height > 3.0 ||
                !Regex.IsMatch(yearOfTraining.ToString(), regYearOfTraining) ||
                course < 1 || course > 6 ||
                !Regex.IsMatch(groupNumber.ToString(), regGroupNumber) ||
                groupNumber / 100 != course);
        }
    }
}
