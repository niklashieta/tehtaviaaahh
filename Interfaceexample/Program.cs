using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog internetawareDog = new Dog();

            Internetconnection conn = new Internetconnection();
            conn.Connect(null);
            conn.Connect(internetawareDog);
        }
    }
}
