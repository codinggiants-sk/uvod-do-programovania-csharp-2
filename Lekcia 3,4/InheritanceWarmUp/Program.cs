using System;

namespace InheritanceWarmUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle(3500, 120, "Car", "BMW");
            Bicycle bike = new Bicycle(15, 50, "Bicykel", "Cube");
            car.DisplayData();
            bike.DisplayData();
            Console.ReadKey();
        }
    }
}
