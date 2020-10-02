using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLib
{
    public class LivingCreature
    {
        private string _name;
        private int _health;


        public LivingCreature()
        {
            Name = "";
            Health = 0;

        }
        public LivingCreature(string name, int health)
        {
            Name = name;
            Health = health;

        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }


    }
}
