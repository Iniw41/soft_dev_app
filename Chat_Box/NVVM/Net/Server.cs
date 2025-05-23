using System;
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
        PacketBuilder _packetBuilder;

        public Server()
        {
            _client = new TcpClient();
        }

        public void ConnectToServer(string usrename)
        {
            if (!_client.Connected)
            { 
                _client.Connect("127.0.0.1", 7892);
                var connectPacket = new PacketBuilder();
                connectPacket.WriteOpCode(0);
                connectPacket.WriteString(usrename);
                _client.Client.Send(connectPacket.GetPacketBytes());
            }
        }
    }
}
