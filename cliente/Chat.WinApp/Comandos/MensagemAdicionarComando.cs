using System.Security.Cryptography;

namespace Chat.WinApp.Comandos
{
    public class MensagemAdicionarComando
    {
        public byte[] CorpoMensagem { get; set; }
        public string Remetente { get; set; }
        public Aes ChaveSimetrica { get; set; }
    }
}
