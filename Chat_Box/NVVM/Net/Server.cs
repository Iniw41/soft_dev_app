using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Chat_Box.NVVM.Net.IO;

namespace Chat_Box.NVVM.Net
{
    public class Server
    {
        TcpClient _client;
        
        
        internal PacketReader PacketReader;

        public event Action connectedEvent;
        public event Action msgReciveEvent;
        public event Action UserDisconnectEvent;

        public Server()
        {
            _client = new TcpClient();
        }

        public void ConnectToServer(string usrename)
        {
            if (!_client.Connected)
            { 
                _client.Connect("127.0.0.1", 7892);
                PacketReader = new PacketReader(_client.GetStream());
                var connectPacket = new PacketBuilder();
                connectPacket.WriteOpCode(0);
                connectPacket.WriteMessage(usrename);
                _client.Client.Send(connectPacket.GetPacketBytes());
            }
            ReadPackets();
        }

        private void ReadPackets()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    var opcode = PacketReader.ReadByte();
                    switch (opcode)
                    {
                        case 1:
                            connectedEvent?.Invoke();
                            break;
                        case 5:
                            msgReciveEvent?.Invoke();
                            break;
                        case 10:
                            UserDisconnectEvent?.Invoke();
                            break;
                        default:
                            Console.WriteLine("ah Fuck");
                            break;
                    }
                }
            });
        }

        public void SendMessageToServer(string message)
        {
            var msgPacket = new PacketBuilder();
            msgPacket.WriteOpCode(5);
            msgPacket.WriteMessage(message);
            _client.Client.Send(msgPacket.GetPacketBytes());
        }
    }
}
