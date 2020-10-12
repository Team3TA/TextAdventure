using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLib
{
    public class Weapon : Item
    {
        // Fields

        private int _durability;
        private int _damage;

        // Constructor
        public Weapon()
        {
            Name = "No name";
            Durability = 100;
            Damage = 0;
        }

        public Weapon(string name, string description, int durablitly, int damage) : base(name, description)
        {
            Durability = durablitly;
            Damage = damage;
        }

        // Full Property
        public int Durability
        {
            get
            {
                return _durability;
            }
            set
            {
                _durability = value;
            }
        }

        // Auto Property
        public int Damage { get; set; }

    }
}
