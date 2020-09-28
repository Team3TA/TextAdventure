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
        private string _name;

        // Constructor
        public Item()
        {
            Name = "";
        }

        public Item(string name)
        {
            Name = name;
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


    }
}
