using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personapli
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            
            person.FirstName = "jimi";
            person.LastName = "leinonen";
            person.Address = "jyvaskyla";
            person.Age = 26;
            person.PhoneNumber = "04023502035";
            Console.WriteLine(person.ToString());
            Teacher jani = new Teacher("jani", "immonen", "unavaible");
            Console.WriteLine(jani.ToString());

            Student pekka = new Student("pekka", "puta", "k2913912");
            pekka.Address = "kuja";
            pekka.Age = 93;
            Console.WriteLine(pekka.ToString());

            Person somepody = new Student("kypra", "aivo", "idiootti");
            somepody.Address = "kuja";
            somepody.Age = 212;
            Console.WriteLine(somepody.ToString());


            List<Person> people = new List<Person>();
            
            for (int i=0; i<20; i++)
            {
                if (i < 5)
                {
                    people.Add(new Person());
                }
                else if(i<12)
                {
                    people.Add(new Teacher());
                }
                else
                {
                    people.Add(new Student());
                }
            }
            foreach(Person personinPeople in people)
            {
                Console.WriteLine(personinPeople.ToString());
            }

        }
    }
}
