using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ModelLib;
using Newtonsoft.Json;

namespace UDPClient
{
    public class UDPSender
    {
        private const int PORT = 7001;


        public void Start()
        {
            UdpClient client = new UdpClient();

            Meassurement Meassure = new Meassurement(1.00,23,19, DateTime.Now);

            Console.WriteLine("Ready to send on port: " + PORT);
            Console.Write(">");

            string message = JsonConvert.SerializeObject(Meassure);

            client.Connect(new IPEndPoint(IPAddress.Any, PORT));

            while (true)
            {





                byte[] bytessent = Encoding.UTF8.GetBytes(message);

                client.Send(bytessent, bytessent.Length);
                Console.WriteLine("succesfully sent message:" + message);


                Console.ReadLine();



            }
        }
    }
}
