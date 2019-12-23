using System;

namespace UDPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPSender client = new UDPSender();
            client.Start();
        }
    }
}
