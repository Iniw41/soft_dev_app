using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Chat_Server.NET.IO;

namespace Chat_Server
{
    class Client
    {
        public string Username { get; set; }
        public Guid ClientId { get; set; }
        public TcpClient ClientSocket { get; set; }

        PacketReader _packetReader;

        public Client(TcpClient client)
        {
            ClientSocket = client;
            ClientId = Guid.NewGuid();
            _packetReader = new PacketReader(client.GetStream());

            var opCode = _packetReader.ReadByte();
            Username = _packetReader.ReadMessage();

            Console.WriteLine($"[Client {Username} Connected {DateTime.Now}]");
        }
    }
}
