using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLib
{
    public class Item
    {
        // Fields
        public int ID { get; set; }
        private string _name;
        private string _description;

        // Constructor
        public Item()
        {
            Name = "";
            Description = "";
        }

        public Item(string name, string description)
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
                return Description;
            }
            set
            {
                _description = value;
            }
        }
    }
}
