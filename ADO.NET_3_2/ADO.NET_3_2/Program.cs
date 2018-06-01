/*
методы которого выводят на консоль сообщения о том или ином действии).
В компании работают сотрудники, каждый из которых может выполнять работу и получать зарплату.
Производительность и зарплата зависит от таких характеристик как:
стаж и уровень развития (junior, developer, senior, lead). 
Каждый работник закреплён за конкретным проектом. 
У проекта есть название, заказчик, а также перечень программистов и тестировщиков. 
В компании трудятся разработчики – они умеют писать код и фиксить баги. 
Разработчики подразделяются на бэк-енд и фронт-енд.
Помимо программистов в компании работают тестировщики. 
Каждый тестировщик умеет тестировать код и находить баги. 
Тестировщики подразделяются на тех кто пишет автоматизированные тесты и тех кто занимается ручным тестированием. 
Работа компании заключается в том, что разработчики производят код (характеризуется количеством строк),
тестировщики проверяют этот код и производят баги (характеризуются приоритетом: минорные, мажорные и критичные), 
разработчики получают написанный ими ранее код с багами и в процессе фикса багов производят новый исправленный код.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_3_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Петр", "Петров", "СГУ");
            Project project = new Project("web", customer);
            List<Programmer> programmers = new List<Programmer>
            {
                new BackEndProgrammer("Alex", "Park", Rank.Lead, 10, 1000),
                new FrontEndProgrammer("Marko", "Vik", Rank.Junior, 1, 900)
            };
            project.Programmers = programmers;

            List<Tester> testers = new List<Tester>
            {
                new AutoTester("Сергей", "Семенов", Rank.Senior, 7, 800),
                new ManualTester("Александр", "Александров", Rank.Junior, 2, 700)
            };
            project.Testers = testers;

            project.AddEmployee(new AutoTester("Сергей", "Сергеев", Rank.Senior, 6, 900));
            project.AddEmployee(new BackEndProgrammer("Иван", "Сергеев", Rank.Lead, 12, 1100));

            Console.WriteLine(project.Programmers[0].GetSalary());
            project.Programmers[0].WriteCode(300);
            project.Programmers[1].WriteCode(400);
            project.Programmers[2].WriteCode(200);
            project.Testers[0].TestCode();

            project.Programmers[0].FixBugs(project.Testers[0].FindBugs());
            project.Programmers[1].FixBugs(project.Testers[0].FindBugs());
            project.Testers[1].TestCode();
            project.Testers[2].TestCode();
        }
    }
}
