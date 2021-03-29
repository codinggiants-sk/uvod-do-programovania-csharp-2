using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    public class Human : Hero
    {
        protected new string name;
        protected string eye_color;
        protected string profession;

        public Human(string name, string surname, string eyes, string prof, int health, int attack, int weight)
            : base(name, weight, health, attack)
        {
            this.name = surname;
            eye_color = eyes;
            profession = prof;
        }

        public override string GetInfo()
        {
            return string.Format("Som človek {0} " +
            "{1}, farba očí {2} a som {3}", base.name, name, eye_color, profession);
        }

    }
}
