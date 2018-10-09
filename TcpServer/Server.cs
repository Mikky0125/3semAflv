using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using ConvertDLLLibraryG;


namespace TCPServer
{
   public class Server
    {
        private int _port;

        public Server(int port)
        {
            _port = port;
        }

        public void Start()
        {
            var listener = new TcpListener(IPAddress.Loopback, _port);
            listener.Start();
            while(true)
            {
                var client = listener.AcceptTcpClient();
                Task.Run(() => HandleClient(client));
            }

         
        }
        /// <summary>
        /// Handling client, hvordan vi handler, længere nede bruger jeg convert options if else så jeg har mulighed for at bruge begge metoder fra DLL. parse for at få det ud.
        /// </summary>
        /// <param name="client"></param>
        private void HandleClient(TcpClient client)
        {
            Console.WriteLine("Handling Client");
            while (client.Connected)
            {
                var ns = client.GetStream();
                var sr = new StreamReader(ns);
                var sw = new StreamWriter(ns);
                sw.AutoFlush = true;
                string[] incStrings;

                incStrings = sr.ReadLine().Split(' ');

                string ConvertOptions = incStrings[0].ToLower();
                if (ConvertOptions == "togram")
                {
                    double weight = double.Parse(incStrings[1]);
                    double result = WeightConvert.OzToGrams(weight);
                    sw.WriteLine(result);
                }
                
                else if (ConvertOptions == "tooz")
                {
                    double weight = double.Parse(incStrings[1]);
                    double result = WeightConvert.GramToOzs(weight);
                    sw.WriteLine(result);
                }

            }

        }
        
    
    }

}
