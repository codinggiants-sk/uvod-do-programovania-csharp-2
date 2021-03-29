using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dunco = new Dog(11, 4, 0.3, "Pes", "Husky");
            dunco.WhoAmI();
            Cat tom = new Cat(3, 4, 0.1, "Mačka", "Perzská");
            tom.WhoAmI();
            dunco.Stekaj();
            tom.CatchMouse();

        }
    }
}
