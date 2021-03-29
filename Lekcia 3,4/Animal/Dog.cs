using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Dog : Animal
    {
        public string breed;

        public Dog(int age, int weight, double height, string type, string breed) : base(age, weight, height, type)
        {

            this.breed = breed;
        }
        public void Stekaj()
        {
            Console.WriteLine("Hau hau !!!");
        }
    }

}
