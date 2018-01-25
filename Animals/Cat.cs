﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal
    {
        public override int Legs
        {
            get
            {
                return 4;
            }
        }

        public override void Talk()
        {
            Console.WriteLine("Miau!");
        }
    }
}
