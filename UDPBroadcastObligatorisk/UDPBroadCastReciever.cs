using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ModelLib;
using Newtonsoft.Json;

namespace UDPBroadcastObligatorisk
{
    public class UDPBroadCastReciever
    {
        private const int PORT = 7001;

        public void Start()
        {
            UdpClient client = new UdpClient(PORT);

            Console.WriteLine("UDP receiver started på port" + PORT);

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, PORT);

            while (true)
            {
                byte[] bytes = client.Receive(ref endpoint);
                string str = Encoding.UTF8.GetString(bytes);


                string[] splitdata = {" "};
                int count = 3;

                string[] strlist = str.Split(splitdata, count, StringSplitOptions.RemoveEmptyEntries);

                foreach (string s in strlist)
                {
                    Console.WriteLine("Modtaget: " + s);

                }

                Console.WriteLine("\n > Succesfully recieved broadcast" + "\n");



            }
        }
    }
}
