using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_3_2
{
    public abstract class Tester : Employee
    {
        public Tester(string name, string surname, Rank rank,
            int experience, double totalSalary)
            : base(name, surname, rank, experience, totalSalary) { }

        public abstract void TestCode();
        public abstract int FindBugs();

        public abstract Tester Clone();
    }
}
