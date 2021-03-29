using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Cat : Animal
    {
        public string breed;

        public Cat(int age, int weight, double height, string type, string breed) : base(age, weight, height, type)
        {

            this.breed = breed;
        }
        public void CatchMouse()
        {
            Console.WriteLine("Naháňam myš");
            Console.ReadKey();
        }
    }

}
