using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLib
{
    public class Mob : LivingCreature
    {
        // Fields        
        private int _damage;

        // Constructor
        public Mob()
        {
            Name = "No Name";
            Health = 0;
            Damage = 0;
        }

        public Mob(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        // Full Property
        // Auto Property
        public int Damage { get; set; }

    }

}
