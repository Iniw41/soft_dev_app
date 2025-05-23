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

            Task.Run(() =>Process());
        }

        void Process()
        {
            while (true)
            {
                try
                {
                    var opcode = _packetReader.ReadByte();
                    switch (opcode)
                    {
                        case 5:
                            var message = _packetReader.ReadMessage();
                            Console.WriteLine($"[{DateTime.Now}Client {Username} Message: {message}]");
                            Program.BroadcastMessage($"[{DateTime.Now}]: [{Username}]: {message}");
                            break;
                        default:
                            Console.WriteLine("Unknown opcode");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"[Client {Username} Disconnected {DateTime.Now}]");
                    Program.BroadcastDisconnect(Username);
                    ClientSocket.Close();
                    break;
                }
            }
        }
    }
}
