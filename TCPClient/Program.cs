using System;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ToGram / ToOz <value>");
            var client = new Client(7000);
                client.Start();
                Console.ReadKey();
        }
    }
}
