using System;

namespace Animal
{
    class Animal
    {
        int age;
        int weight;
        double height;
        string type;
        public Animal(int age, int weight, double height, string type)
        {
            this.age = age;
            this.weight = weight;
            this.height = height;
            this.type = type;

        }
        public void WhoAmI()
        {
            Console.WriteLine("Typ {0}, vek {1}, váha {2}, výška {3}", this.type, this.age, this.weight, this.height);
        }
    }
}
