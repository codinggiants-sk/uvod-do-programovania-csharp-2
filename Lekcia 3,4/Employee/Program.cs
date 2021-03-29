using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Počet zamestnancov {0}", Employee.numberOfEmployees);
            Employee p1 = new Employee("Kowalski", 5400.0m);
            p1.PrintDetails();
            Employee p2 = new Employee("Novák", 7500.0m);
            p2.PrintDetails();
            Console.WriteLine("Počet zamestnancov {0}", Employee.numberOfEmployees);
            Employee.PrintNumberOfEmployees();
            Console.ReadKey();

        }
    }
}
