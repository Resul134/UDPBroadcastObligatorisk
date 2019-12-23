using System;

namespace UDPBroadcastObligatorisk
{
    class Program
    {
        static void Main(string[] args)
        {

            UDPBroadCastReciever worker = new UDPBroadCastReciever();

            worker.Start();
            Console.WriteLine("Hello World!");
        }
    }
}
