using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADO.NET_2_2
{
    public class Book
    {
        private const string regName = @"(^[a-zA-Z]{2,20}$)";

        private Author _author;
        private string _name;
        private int _numberOfPages;
        private string _publishingHouse;
        private DateTime _dateOfPublication;
        private DateTime _dateOfWriting;

        public Author Author
        {
            get
            {
                return _author;
            }
            set
            {
                if (value != null)
                {
                    _author = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect parameters");
                }
            }
        }

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
        public int NumberOfPages
        {
            get
            {
                return _numberOfPages;
            }
            set
            {
                if (value > 1)
                {
                    _numberOfPages = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect parameters");
                }
            }
        }
        public string PublishingHouse
        {
            get
            {
                return _publishingHouse;
            }
            set
            {
                if (IsCorrectName(value))
                {
                    _publishingHouse = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect parameters");
                }
            }
        }
        public DateTime DateOfPublication
        {
            get
            {
                return _dateOfPublication;
            }
            set
            {
                if (IsCorrectDate(value, _dateOfWriting))
                {
                    _dateOfPublication = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect parameters");
                }
            }
        }
        public DateTime DateOfWriting
        {
            get
            {
                return _dateOfWriting;
            }
            set
            {
                if (IsCorrectDate(_dateOfPublication, value))
                {
                    _dateOfWriting = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect parameters");
                }
            }
        }

        /// <summary> Creating a Book class object </summary>
        public Book(Author author, String name, int numberOfPages, String publishingHouse,
            DateTime dateOfPublication, DateTime dateOfWriting)
        {
            Author = author;
            Name = name;
            NumberOfPages = numberOfPages;
            PublishingHouse = publishingHouse;
            DateOfPublication = dateOfPublication;
            DateOfWriting = dateOfWriting;
        }

        private bool IsCorrectName(string name)
        {
            return (!string.IsNullOrEmpty(name) || Regex.IsMatch(name, regName));
        }

        private bool IsCorrectDate(DateTime dateOfPublication, DateTime dateOfWriting)
        {
            return (dateOfPublication > dateOfWriting || DateTime.Now > dateOfWriting);
        }
    }
}
