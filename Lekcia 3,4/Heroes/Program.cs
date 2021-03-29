using System;
using System.Collections.Generic;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Werewolf lucian = new Werewolf(10, 20, 50, "Lucian", 200, 1000, 50);
            lucian.GetInfo();

            Human yennefer = new Human("Yennefer", "of Vengerberg", "zelená", "čarodejnica", 100, 100, 56);
            yennefer.GetInfo();


            Hero hero_werewolf = new Werewolf(10, 30, 50, "Filus", 150, 200, 30);
            Hero hero_human = new Human("Cirilla", "Fiona Elen Riannon", "modrá", "princezná", 30, 20, 58);

            List<Hero> heroList = new List<Hero>();
            heroList.Add(lucian);
            heroList.Add(yennefer);
            heroList.Add(hero_human);
            heroList.Add(hero_werewolf);

            foreach (Hero postac in heroList)
            {
                Console.WriteLine(postac.GetInfo());
            }

            Console.ReadLine();
        }

    }
}

