using Chat.Infraestrutura.Crypto;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Chat.WinApp
{
    public partial class FormPrincipal : Form
    {
        private MulticastUDP _envelopadorUdp;
        private string _grupoMulticast;
        private int _porta;
        private string _nomeUsuario;
        private string _chave;

        public FormPrincipal()
        {
            InitializeComponent();

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://localhost:44389/api/cryptokey/");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                _chave = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (WebException)
            {
                MessageBox.Show("Servidor contendo a chave de criptografia esta offline", "Erro");
                Environment.Exit(Environment.ExitCode);
            }
        }

        private void buttonConectar_Click(object sender, System.EventArgs e)
        {
            _grupoMulticast = textBoxIP.Text;
            try
            {
                _porta = Convert.ToInt32(textBoxPorta.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato da porta incorreto", "Erro");
                return;
            }
            _nomeUsuario = string.IsNullOrWhiteSpace(textBoxUsuario.Text) ? "otario que não bota o nome" : textBoxUsuario.Text;
            textBoxConversa.Clear();
            textBoxInput.Clear();
            listBoxOnline.Items.Clear();

            bool entrou = EntrarNoGrupo();

            if (entrou)
            {
                buttonConectar.Enabled = false;
                buttonDesconectar.Enabled = true;
                buttonEnviar.Enabled = true;
            }
        }

        private void buttonDesconectar_Click(object sender, System.EventArgs e)
        {
            SairDoGrupo();

            buttonConectar.Enabled = true;
            buttonDesconectar.Enabled = false;
            buttonEnviar.Enabled = false;
            textBoxConversa.Clear();
            textBoxInput.Clear();
            listBoxOnline.Items.Clear();
        }

        private void buttonEnviar_Click(object sender, System.EventArgs e)
        {
            byte[] buffer = AesCriptografia.Criptografar($"{_nomeUsuario} escreveu: {textBoxInput.Text}", _chave);

            _envelopadorUdp.EnviarMulticast(buffer);

            textBoxInput.Clear();
        }

        private bool EntrarNoGrupo()
        {
            try
            {
                IPAddress multicastIp = IPAddress.Parse(_grupoMulticast);

                _envelopadorUdp = new MulticastUDP(multicastIp, _porta, _chave, IPAddress.Any);
                _envelopadorUdp.MensagemUDPRecebida += AoReceberMensagemUDP;
            }
            catch (SocketException)
            {
                MessageBox.Show("Endereço IP inválido", "Erro");
                return false;
            }

            byte[] buffer = AesCriptografia.Criptografar($"{_nomeUsuario} entrou na sala", _chave);

            _envelopadorUdp.EnviarMulticast(buffer);

            return true;
        }

        private void SairDoGrupo()
        {
            byte[] buffer = AesCriptografia.Criptografar($"{_nomeUsuario} saiu da sala", _chave);

            _envelopadorUdp.EnviarMulticast(buffer);

            _envelopadorUdp.FecharConexao();
        }

        private void AoReceberMensagemUDP(object sender, MulticastUDP.UdpMessageReceivedEventArgs e)
        {
            string textoRecebido = AesCriptografia.Descriptografar(e.Buffer, _chave);
            EscreverTextBox(textoRecebido);
        }

        private void EscreverTextBox(string mensagem)
        {
            Invoke((Action)(() =>
            {
                textBoxConversa.Text += mensagem;
                textBoxConversa.Text += Environment.NewLine;
            }), null);
        }


        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
