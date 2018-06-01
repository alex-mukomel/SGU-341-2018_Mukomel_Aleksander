using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_3_2
{
    public abstract class Man
    {
        private string _name;
        private string _surname;

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
                    throw new ArgumentException("Incorrect Name");
                }             
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (IsCorrectName(value))
                {
                    _surname = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect Surname");
                }                
            }
        }
        
        public Man(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        protected bool IsCorrectName(string name)
        {
            return (!string.IsNullOrEmpty(name));
        }
    }
}
