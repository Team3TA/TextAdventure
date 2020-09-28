using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLib
{
    public class Player : LivingCreature
    {
        // Fields        
        private string _password;
        private string _class;
        private string _race;

        // Constructor
        public Player()
        {
            Name = "No name";
            Health = 0;
            Password = "No password";
            Class = "No class";
            Race = "No race";
        }

        public Player(string name, int health, string password, string clas, string race)
        {
            Name = name;
            Health = health;
            Password = password;
            Class = clas;
            Race = race;
        }

        // Property      

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public string Class
        {
            get
            {
                return _class;
            }
            set
            {
                _class = value;
            }
        }

        public string Race
        {
            get
            {
                return _race;
            }
            set
            {
                _race = value;
            }
        }
    }
}
