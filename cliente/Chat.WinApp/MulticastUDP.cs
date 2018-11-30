using System;
using System.Net;
using System.Net.Sockets;

namespace Chat.WinApp
{
    public class MulticastUDP
    {
        private UdpClient _cliente;
        private readonly int _porta;
        private readonly string _chaveCriptografia;
        private IPAddress _grupo;
        private IPAddress _enderecoLocal;
        private IPEndPoint _endPointLocal;
        private IPEndPoint _endPointRemoto;

        public MulticastUDP(IPAddress enderecoIpMulticast, int porta, string chave, IPAddress enderecoIpLocal = null)
        {
            _grupo = enderecoIpMulticast;
            _porta = porta;
            _enderecoLocal = enderecoIpLocal;
            _chaveCriptografia = chave;
            if (enderecoIpLocal == null)
                _enderecoLocal = IPAddress.Any;

            _endPointRemoto = new IPEndPoint(_grupo, porta);
            _endPointLocal = new IPEndPoint(_enderecoLocal, porta);

            _cliente = new UdpClient
            {
                ExclusiveAddressUse = false
            };
            _cliente.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            _cliente.Client.Bind(_endPointLocal);
            _cliente.JoinMulticastGroup(_grupo, _enderecoLocal);

            _cliente.BeginReceive(new AsyncCallback(ReceberResposta), null);
        }

        public void FecharConexao()
        {
            _cliente.DropMulticastGroup(_grupo);
        }

        public void EnviarMulticast(byte[] bufferEnviar)
        {
            _cliente.Send(bufferEnviar, bufferEnviar.Length, _endPointRemoto);
        }

        private void ReceberResposta(IAsyncResult resultadoAsync)
        {
            byte[] bytesRecebidos = _cliente.EndReceive(resultadoAsync, ref _endPointLocal);

            MensagemUDPRecebida?.Invoke(this, new UdpMessageReceivedEventArgs() { Buffer = bytesRecebidos });

            _cliente.BeginReceive(new AsyncCallback(ReceberResposta), null);
        }

        public event EventHandler<UdpMessageReceivedEventArgs> MensagemUDPRecebida;

        public class UdpMessageReceivedEventArgs : EventArgs
        {
            public byte[] Buffer { get; set; }
        }
    }
}
