using System.Net;
using System.Net.Sockets;

namespace Chat.Server
{
    public class Servidor
    {
        private static readonly int PORTA = 8182;
        private static readonly string ENDERECO_IP = "224.5.6.7";

        public static void Main()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, PORTA);
            socket.Bind(ipep);
            IPAddress ip = IPAddress.Parse(ENDERECO_IP);

            socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ip, IPAddress.Any));

            byte[] b = new byte[1024];
            socket.Receive(b);
        }
    }
}
