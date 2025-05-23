using System;
using System.Net;
using System.Net.Sockets;
using Chat_Server.NET.IO;

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

                //Broadcast Connection the everyone
                BroadcastConnection();
            }
        }

        static void BroadcastConnection()
        {

            foreach (var user in _users)
            {
                foreach (var usr in _users)
                {
                    var broadcastPacket = new PacketBuilder();
                    broadcastPacket.WriteOpCode(1);
                    broadcastPacket.WriteMessage(usr.Username);
                    user.ClientSocket.Client.Send(broadcastPacket.GetPacketBytes());
                }
            }
        }

        public static void BroadcastMessage(string message)
        {
            foreach (var user in _users)
            {
                var msgPacket = new PacketBuilder();
                msgPacket.WriteOpCode(5);
                msgPacket.WriteMessage(message);
                user.ClientSocket.Client.Send(msgPacket.GetPacketBytes());
            }
        }

        public static void BroadcastDisconnect(string Username)
        {
            foreach (var user in _users)
            {
                var msgPacket = new PacketBuilder();
                msgPacket.WriteOpCode(10);
                msgPacket.WriteMessage(Username);
                user.ClientSocket.Client.Send(msgPacket.GetPacketBytes());
            }

            BroadcastMessage($"[{Username} Disconnected]");
        }
    }
}

