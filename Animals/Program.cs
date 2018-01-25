using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Chicken());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Chicken());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Chicken());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Chicken());


            foreach (Animal animal in animals)
            {
                Console.WriteLine("Animal is: " + animal.GetType());
            }
        }

    }
}
