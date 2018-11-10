using System.Security.Cryptography;

namespace Chat.WinApp.Modelos
{
    public class MensagemRecebidaModelo
    {
        public byte[] CorpoMensagem { get; set; }
        public string Remetente { get; set; }
        public Aes ChaveSimetrica { get; set; }
    }
}