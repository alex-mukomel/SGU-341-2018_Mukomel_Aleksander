using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_3_2
{
    public class Project
    {
        private string _name;
        private Customer _customer;
        private List<Programmer> _programmers;
        private List<Tester> _testers;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect Name");
                }
                _name = value;
            }
        }
        public Customer Customer
        {
            get
            {
                return _customer;
            }
            set
            {
                _customer = value ?? throw new ArgumentException("Incorrect Customer");
            }
        }
        public List<Programmer> Programmers
        {
            get
            {
                return _programmers;
            }
            set
            {
                if (value != null)
                {
                    _programmers = value.Select(x => x.Clone()).ToList();
                }
                else
                {
                    _programmers = new List<Programmer>();
                }
            }
        }
        public List<Tester> Testers
        {
            get
            {
                return _testers;
            }
            set
            {
                if (value != null)
                {
                    _testers = value.Select(x => x.Clone()).ToList();
                }
                else
                {
                    _testers = new List<Tester>();
                }
            }
        }

        public Project(string name, Customer customer, 
            List<Programmer> programmers, List<Tester> testers)
        {
            Name = name;
            Customer = customer;
            Programmers = programmers;
            Testers = testers;
        }

        public Project(string name, Customer customer)
        {
            Name = name;
            Customer = customer;
        }

        public void AddEmployee(Employee employee)
        {
            if (employee is Programmer)
            {
                Programmers.Add((Programmer)employee);
            }
            else if (employee is Tester)
            {
                Testers.Add((Tester)employee);
            }
        }
    }
}