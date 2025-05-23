using System;
using System.Net;
using System.Net.Sockets;

namespace Chat_Server 
{
    class Program
    {
        static List<Client> _users;

        static TcpListener _listener;
        static void Main(string[] args)
        {
            _users = new List<Client>();
            _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 7892);
            _listener.Start();

            while (true)
            {

                var client = new Client(_listener.AcceptTcpClient());
                Console.WriteLine("Client connected!");

            }
        }
    }
}

