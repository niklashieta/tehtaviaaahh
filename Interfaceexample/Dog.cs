using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceexample
{
    class Dog : Animal, IConnectionstatuslistener
    {
        public override void Talk()
        {
            Console.WriteLine("WUH WUH VITTU!!");
        }

        public void OnConnectionstarted()
        {
            Console.WriteLine("DOG: OnConnectionStarted");
        }
        public void OnConnectionsuccess()
        {
            Console.WriteLine("DOG: OnConnectionsuccess -WUF!");
        }
        public void OnConnectionfailed()
        {
            Console.WriteLine("DOG: OnConnectionfailed Whine.....");
        }
    }
}
