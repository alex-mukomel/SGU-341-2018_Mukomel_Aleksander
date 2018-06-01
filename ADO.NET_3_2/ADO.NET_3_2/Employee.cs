using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_3_2
{
    public abstract class Employee : Man
    {
        private Rank _rank;
        private int _experience;
        private double _totalSalary;

        public Rank Rank
        {
            get
            {
                return _rank;
            }
            set
            {
                if (!Rank.IsDefined(typeof(Rank), value))
                {
                    throw new ArgumentException("Incorrect Rank");
                }
                _rank = value;
            }
        }
        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                if ((value < 0) && (value > 80))
                {
                    throw new ArgumentException("Incorrect Experience");
                }
                _experience = value;
            }
        }
        public double TotalSalary
        {
            get
            {
                return _totalSalary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect Salary");
                }
                _totalSalary = value;
            }
        }

        public Employee(string name, string surname, Rank rank,
            int experience, double totalSalary) 
            : base (name, surname)
        {
            Rank = rank;
            Experience = experience;
            TotalSalary = totalSalary;
        }

        public string GetSalary()
        {
            if (Rank == Rank.Junior)
                return string.Format("{0} {1} received ${2}", Name, Surname, 
                    TotalSalary * 0.5 + Experience * 0.02 * TotalSalary);
            if (Rank == Rank.Developer)
                return string.Format("{0} {1} received ${2}", Name, Surname,
                    TotalSalary * 1.0 + Experience * 0.02 * TotalSalary);
            if (Rank == Rank.Senior)
                return string.Format("{0} {1} received ${2}", Name, Surname, 
                    TotalSalary * 1.3 + Experience * 0.02 * TotalSalary);
            if (Rank == Rank.Lead)
                return string.Format("{0} {1} received ${2}", Name, Surname, 
                    TotalSalary * 1.6 + Experience * 0.02 * TotalSalary);
            else
                return "Everything is very bad...";
        }

    }
}
