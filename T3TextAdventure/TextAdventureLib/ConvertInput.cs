using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLib
{
    public static class ConvertInput
    {
        public static int ConvertToInt(string input)
        {
            int output = 0;

            if(int.TryParse(input, out output))
            {
                return output;
            }
            else
            {
                output = -1;
                return output;
            }
        }
    }
}
