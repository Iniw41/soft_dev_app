using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Box.NVVM.Net
{
    class Server
    {
        TcpClient _client;

        public Server()
        {
            _client = new TcpClient();
        }

        public void ConnectToServer(string ip, int port)
        {
            try
            {
                _client.Connect("127.0.0.1", 5781);
                Console.WriteLine("Connected to server");
            }
            catch (SocketException ex)
            {
                Console.WriteLine($"SocketException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        internal void ConnectToServer()
        {
            throw new NotImplementedException();
        }
    }
}
