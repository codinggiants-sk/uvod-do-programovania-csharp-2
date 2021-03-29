using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    public class Hero
    {
        public string name;
        public int weight;
        public int health;
        public int attack_strength;

        public Hero(string name, int weight, int health, int attack)
        {
            this.name = name;
            this.weight = weight;
            this.health = health;
            attack_strength = attack;
        }

        public virtual string GetInfo()
        {
            return String.Format("Som hrdina. Moja váha je {0} a mám " +
             "{1} bodov života a silu útoku {2}", weight, health, attack_strength);
        }

        public virtual int Damage()
        {
            return 0;
        }

    }
}
