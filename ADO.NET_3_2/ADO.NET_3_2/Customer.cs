using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_3_2
{
    public class Customer : Man
    {
        private string _company;

        public string Company
        {
            get
            {
                return _company;
            }
            set
            {
                if (IsCorrectName(value))
                {
                    _company = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect Company");
                }               
            }
        }

        public Customer(string name, string surname, string company)
            : base(name, surname)
        {
            Company = company;
        }

        public override string ToString()
        {
            return $"Name {Name} Surname {Surname} Company {Company}";
        }
    }
}
