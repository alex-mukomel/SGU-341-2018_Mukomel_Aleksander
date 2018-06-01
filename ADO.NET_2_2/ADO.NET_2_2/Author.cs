using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADO.NET_2_2
{
    public class Author
    {
        private const string regName = @"(^[a-zA-Z]{2,20}$)";
        private string _name;
        private string _lastName;
        private int _year;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (IsCorrectName(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect parameters");
                }
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (IsCorrectName(value))
                {
                    _lastName = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect parameters");
                }
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (IsCorrectDate(value))
                {
                    _year = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect parameters");
                }
            }
        }

        /// <summary> Creating a Author class object </summary>
        public Author(string name, string lastName, int year)
        {
            Name = name;
            LastName = lastName;
            Year = year;
        }
        private bool IsCorrectName(string name)
        {
            return (!String.IsNullOrEmpty(name) || Regex.IsMatch(name, regName));
        }
        private bool IsCorrectDate(int year)
        {
            return (year > 1 || year < 2018);
        }
    }
}
