using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWarmUp
{
    class Vehicle
    {
        int weight;
        int maxSpeed;
        string type;
        string brand;
        public Vehicle(int weight, int maxSpeed, string type, string brand)
        {
            this.weight = weight;
            this.maxSpeed = maxSpeed;
            this.brand = brand;
            this.type = type;
        }
        public void DisplayData()
        {
            Console.WriteLine(" Typ : {0}, značka: {1}, max rýchlosť {2}", type, brand, maxSpeed);
        }
    }
}
