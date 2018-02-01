using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
          
               Cat cat = new Cat();
               cat.name = "Mirre";
               Console.WriteLine("Here is {0}: {1}", cat.name, cat.Talk()); // Here is Mirre: Miau!

               Dog dog = new Dog { name = "Musti" };
               Console.WriteLine("Here is {0}: {1}", dog.name, dog.Talk()); // Here is Musti: Wuw!

               Console.ReadKey();
            

        }
    }
}
