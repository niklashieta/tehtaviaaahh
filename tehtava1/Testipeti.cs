using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava1
{
    class Testipeti
    {
        public bool penis(string input)
        {
            if (long.TryParse(input, out long intOutput))
            { return true; }
            else if (float.TryParse(input, out float floatOutput))
                return false;
            else
                return false;
            
        }
    }
}
