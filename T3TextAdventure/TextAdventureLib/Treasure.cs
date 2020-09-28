using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLib
{
    public class Treasure
    {
        // Fields
        private string _name;

        // Constructor
        public Treasure()
        {
            Name = "No name";
        }

        public Treasure(string name)
        {
            Name = name;
        }

        // Property
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


    }
}
