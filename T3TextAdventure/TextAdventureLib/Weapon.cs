using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLib
{
    public class Weapon
    {
        // Fields
        private string _name;
        private int _durability;
        private int _damage;

        // Constructor
        public Weapon()
        {
            Name = "No name";
            Durability = 00;
            Damage = 0;
        }

        public Weapon(string name, int durablitly, int damage)
        {
            Name = name;
            Durability = durablitly;
            Damage = damage;
        }

        // Full Property

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
