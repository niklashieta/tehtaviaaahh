using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            joukkue jyp = new joukkue();
            jyp.nimi = "JYP";
            jyp.kaupun = "jyvaskyla";
            Console.WriteLine("moi haluatko tietaa jypin pelaajat");
            Console.ReadLine();
            Console.WriteLine(jyp.pelaaja);










        }
    }
}
