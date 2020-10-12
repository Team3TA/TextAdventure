using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLib
{
    public static class World
    {
        public static readonly List<Weapon> weapons = new List<Weapon>();
        public static readonly List<Potion> potions = new List<Potion>();
        public static readonly List<Treasure> treasures = new List<Treasure>();
        public static readonly List<Item> items = new List<Item>();
        public static readonly List<Mob> mobs = new List<Mob>();
    }
}
