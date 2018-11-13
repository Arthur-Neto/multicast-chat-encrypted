using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Chat.WinApp
{
    public partial class FormPrincipal : Form
    {
        private MulticastUDP _envelopadorUdp;
        private string _grupoMulticast;
        private int _porta;
        private string _nomeUsuario;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonConectar_Click(object sender, System.EventArgs e)
        {
            _grupoMulticast = textBoxIP.Text;
            _porta = Convert.ToInt32(textBoxPorta.Text);
            _nomeUsuario = textBoxUsuario.Text;
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
            byte[] buffer = Encoding.UTF8.GetBytes($"{_nomeUsuario} escreveu: {textBoxInput.Text}");

            _envelopadorUdp.EnviarMulticast(buffer);

            textBoxInput.Clear();
        }

        private bool EntrarNoGrupo()
        {
            IPAddress multicastIp = IPAddress.Parse(_grupoMulticast);

            _envelopadorUdp = new MulticastUDP(multicastIp, _porta, IPAddress.Any);
            _envelopadorUdp.MensagemUDPRecebida += AoReceberMensagemUDP;

            byte[] buffer = Encoding.UTF8.GetBytes($"{_nomeUsuario} entrou na sala");

            _envelopadorUdp.EnviarMulticast(buffer);

            return true;
        }

        private void SairDoGrupo()
        {
            byte[] buffer = Encoding.UTF8.GetBytes($"{_nomeUsuario} saiu da sala");

            _envelopadorUdp.EnviarMulticast(buffer);

            _envelopadorUdp.FecharConexao();
        }

        private void AoReceberMensagemUDP(object sender, MulticastUDP.UdpMessageReceivedEventArgs e)
        {
            string textoRecebido = Encoding.UTF8.GetString(e.Buffer);
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
