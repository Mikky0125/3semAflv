using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace TCPClient
{
   public class Client
    {
        private int _port;

        public Client (int port)
        {
            _port = port;
        }
        public void Start()
        {
            var client = new TcpClient("localhost", _port);
            while (true)
            {
                var ns = client.GetStream();
                var sr = new StreamReader(ns);
                var sw = new StreamWriter(ns);
                sw.AutoFlush = true;

                sw.WriteLine(Console.ReadLine());
                Console.WriteLine(sr.ReadLine());

            }
        }
    }
}
