using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLib
{
    public class Potion
    {
        private string _name;
        private string _description;

        // Constructor
        public Potion()
        {
            Name = "No name";
            Description = "No description";
        }

        public Potion(string name, string description)
        {
            Name = name;
            Description = description;
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

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

    }
}
