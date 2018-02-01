using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceexample
{
    interface IConnectionstatuslistener
    {
        void OnConnectionstarted();
        void OnConnectionsuccess();
        void OnConnectionfailed();

    }
    class Internetconnection
    {
        public void Connect(IConnectionstatuslistener listener)
        {
            Console.WriteLine("Connecting to internet....");

            if(listener != null) listener.OnConnectionstarted();
            System.Threading.Thread.Sleep(4000);

            Random rand = new Random();
            if (rand.Next(0,10)<8)
            {
                if (listener != null) listener.OnConnectionsuccess();
            }
            else
            {
                if (listener != null) listener.OnConnectionfailed();
            }
            Console.WriteLine("Connect attempt complete");
        }
    }
}
