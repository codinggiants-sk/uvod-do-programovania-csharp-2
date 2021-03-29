using System;

namespace Cellphones
{
    class Program
    {
        static void Main(string[] args)
        {
            Cellphone samsung_s4 = new Cellphone(100, 200, 400, "Samsung ", "S4");
            Console.WriteLine("Vytvorený telefón {0} {1}", samsung_s4.brand, samsung_s4.model);
            Console.ReadKey();
        }
    }
}
