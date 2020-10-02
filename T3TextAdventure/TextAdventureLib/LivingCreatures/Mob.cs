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

        // Constructor
        public Mob() : base()
        {

            Damage = 0;
        }

        public Mob(string name, int health, int damage) : base(name, health)
        {
            Damage = damage;
        }

        // Full Property
        // Auto Property
        public int Damage { get; set; }

    }

}
