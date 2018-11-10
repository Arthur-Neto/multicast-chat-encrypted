using System.Security.Cryptography;

namespace Chat.Server.Modelos
{
    public class MensagemRecebidaModelo
    {
        public byte[] CorpoMensagem { get; set; }
        public string Remetente { get; set; }
        public Aes ChaveSimetrica { get; set; }
    }
}
