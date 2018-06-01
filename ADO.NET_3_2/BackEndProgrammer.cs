using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_3_2
{
    class BackEndProgrammer : Programmer
    {
        public BackEndProgrammer(string name, string surname, Rank rank,
            int experience, double totalSalary)
            : base(name, surname, rank, experience, totalSalary) { }

        public override void FixBugs(int count)
        {
            Console.WriteLine("Back-end programmer {0} {1} fixed {2} bugs", Name, Surname, count);
        }

        public override void WriteCode(int count)
        {
            Console.WriteLine("Back-end programmer {0} {1} wrote {2} lines of code", Name, Surname, count);
        }

        public override Programmer Clone()
        {
            return new BackEndProgrammer(Name, Surname, Rank, Experience, TotalSalary);
        }
    }
}
