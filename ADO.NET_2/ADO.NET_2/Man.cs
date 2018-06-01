using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADO.NET_2
{
    public class Man
    {
        private const string regName = @"(^[a-zA-Z]{2,20}$)";

        private string _name;
        private int _age;
        private double _weight;
        private double _height;

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (IsNotCorrect(value, _age, _weight, _height))
                {
                    throw new ArgumentException("Incorrect parameters"); 
                }
                _name = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (IsNotCorrect(_name, value, _weight, _height))
                {
                    throw new ArgumentException("Incorrect parameters");
                }
                _age = value;
            }
        }
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (IsNotCorrect(_name, _age, value, _height))
                {
                    throw new ArgumentException("Incorrect parameters");
                }
                _weight = value;
            }
        }
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (IsNotCorrect(_name, _age, _weight, value))
                {
                    throw new ArgumentException("Incorrect parameters"); 
                }
                _height = value;
            }
        }

        /// <summary> Creating a Man class object </summary>
        public Man(String name, int age, double weight, double height)
        {
            if (IsNotCorrect(name, age, weight, height))
            {
                throw new ArgumentException("Incorrect parameters");
            }
            _name = name;
            _age = age;
            _weight = weight;
            _height = height;
        }

        public bool IsNotCorrect(String name, int age, double weight, double height)
        {
            return (!Regex.IsMatch(name, regName) || age < 17 || age > 120 ||
                weight < 1.0 || weight > 300.0 ||
                height < 0.20 || height > 3.0);
        }
    }
}
