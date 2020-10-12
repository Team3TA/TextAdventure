using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLib
{
    public class Room
    {
        // Fields
        private string _name;
        private string _description;


        // Constructor
        public Room()
        {
            Name = "No name";
            Description = "No description";
        }

        public Room(string name, string description)
        {
            Name = name;
            Description = description;
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
