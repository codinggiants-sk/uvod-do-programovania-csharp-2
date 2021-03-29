using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public static int numberOfEmployees; // statický prvok
        public string name;
        public decimal salary;
        public Employee(string name, decimal salary) // konštruktor
        {
            numberOfEmployees++;
            this.name = name;
            this.salary = salary;
        }
        static Employee() //statický konštruktor
        {
            numberOfEmployees = 0;
        }
        public void PrintDetails() // metóda
        {
            Console.WriteLine("{0} {1}", name, salary);
        }

        public static void PrintNumberOfEmployees() // statická metóda
        {
            Console.WriteLine("{0}", numberOfEmployees);
        }

    }
}
