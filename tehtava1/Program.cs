using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Testipeti> testit = new List<Testipeti>();
            testit.Add(new Testipeti());
            testit.Add(new Testipeti());
            testit.Add(new Testipeti());
            testit.Add(new Testipeti());
            testit.Add(new Testipeti());
            testit.Add(new Testipeti());
            testit.Add(new Testipeti());
            testit.Add(new Testipeti());
            testit.Add(new Testipeti());
            testit.Add(new Testipeti());
            testit.Add(new Testipeti());
            foreach (Testipeti test in testit)
            {
                Console.WriteLine("penis " + test.penis());
            }

            Console.WriteLine("Staattisen metodin Onkoluku testaus erilaisilla syotteilla: ");
            Console.WriteLine("--Epakelpojen syotteiden testaus: ");
           // Console.WriteLine("syote kissa on luku: " + penis);
            Console.WriteLine("--Kelvollisten syotteidean testaus: ");
        }
    }
}
