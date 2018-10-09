using System;


namespace TCPServer
{
   class Program
    {
        static void Main(string[] args)
        {
            var server = new Server(7000);
            server.Start();
            Console.ReadKey();


        }
    }
}
