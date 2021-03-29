using System;


namespace Heroes
{
    public class Werewolf : Hero
    {
        public int fur_thickness;
        public int number_of_claws;
        public int jaw_strength;

        public Werewolf(int fur, int claws, int jaw,
            string name, int weight, int health, int attack) : base(name, weight, health, attack)
        {
            fur_thickness = fur;
            number_of_claws = claws;
            jaw_strength = jaw;
        }

        public override string GetInfo()
        {
            return String.Format("Volám sa {0}, vážim {1} a mám {2} života." +
            "Útočná sila: {3} a sila uhryznutia {4}."
            , name, weight, health, attack_strength, jaw_strength);
        }

        public override int Damage()
        {
            Random r = new Random();
            return jaw_strength * r.Next(3, 10);
        }
    }
    }
