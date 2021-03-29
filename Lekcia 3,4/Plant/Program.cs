using System;

namespace Plant
{
    class Program
    {
        static void Main(string[] args)
        {
            Plant ceresna = new Plant(100, 30, "Čerešňa");
            Plant pupava = new Plant(1, 1, "Púpava");
            Plant tuja = new Plant(2, 4, "Tuja");
            Console.WriteLine("Počet rôznych rastin {0}", Plant.GetNumberOfPlants());
            Console.ReadKey();

        }
    }
}


