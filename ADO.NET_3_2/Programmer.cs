using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_3_2
{
    public abstract class Programmer : Employee
    {
        public Programmer(string name, string surname, Rank rank,
            int experience, double totalSalary)
            : base (name, surname, rank, experience, totalSalary) { }

        public abstract void WriteCode(int count);
        public abstract void FixBugs(int count);

        public abstract Programmer Clone();
    }
}
