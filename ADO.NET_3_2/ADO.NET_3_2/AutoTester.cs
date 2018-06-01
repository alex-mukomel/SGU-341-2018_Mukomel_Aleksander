using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_3_2
{
    class AutoTester : Tester
    {
        public AutoTester(string name, string surname, Rank rank,
            int experience, double totalSalary)
            : base(name, surname, rank, experience, totalSalary) { }

        public override int FindBugs()
        {
            Random random = new Random();
            int count = random.Next(1, 10);
            int bugsNo = random.Next(1, 4);
            Bugs bugs;
            if (bugsNo == 1)
            {
                bugs = Bugs.Major;
            }
            else if (bugsNo == 2)
            {
                bugs = Bugs.Minor;
            }
            else
            {
                bugs = Bugs.Critical;
            }
            Console.WriteLine("Auto tester {0} {1} found {2} {3} bugs", Name, Surname, count, bugs);
            return count;
        }

        public override void TestCode()
        {
            Console.WriteLine("Auto tester {0} {1} tested the code", Name, Surname);
        }

        public override Tester Clone()
        {
            return new AutoTester(Name, Surname, Rank, Experience, TotalSalary);
        }
    }
}
