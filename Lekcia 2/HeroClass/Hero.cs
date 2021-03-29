using System;

namespace HeroClass
{
    public class Hero
    {
        public int Age;
        public int Weight;
        public string Name;
        public string Power;
        public int DefensePoints;
        public int AttackPoints;

        public Hero(int _age, int _weight, string _name, string _power, int _defensePoints, int _attackPoints)
        {
            Age = _age;
            Weight = _weight;
            Name = _name;
            Power = _power;
            DefensePoints = _defensePoints;
            AttackPoints = _attackPoints;

        }
        public void DescribeYourself()
        {
            Console.WriteLine("Meno:{0}, Schopnost:{1}, Vek:{2}", Name, Power, Age);
            Console.ReadKey();

        }
    }
}