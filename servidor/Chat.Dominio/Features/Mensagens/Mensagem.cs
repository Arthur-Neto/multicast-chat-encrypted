using System.Security.Cryptography;

namespace Chat.Dominio.Features.Mensagens
{
    public class Mensagem
    {
        public byte[] CorpoMensagem { get; set; }
        public string Remetente { get; set; }
        public Aes ChaveSimetrica { get; set; }
    }
}
