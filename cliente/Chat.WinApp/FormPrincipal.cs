using Chat.Infraestrutura.Crypto;
using Chat.WinApp.Comandos;
using Chat.WinApp.Modelos;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Chat.WinApp
{
    public partial class FormPrincipal : Form
    {
        private IList<string> _usuariosConectados;
        private string _enderecoServidor;
        private string _portaServidor;
        private string _mensagemAEnviar;
        private string _nomeUsuario;
        private const string CHAVE_ENCRIPTACAO = "123";

        public FormPrincipal()
        {
            InitializeComponent();

            _usuariosConectados = new List<string>();
        }

        private void buttonConectar_Click(object sender, System.EventArgs e)
        {
            ConectarAoServidor();
        }

        private void buttonDesconectar_Click(object sender, System.EventArgs e)
        {
            DesconectarDoServidor();
        }

        private void buttonEnviar_Click(object sender, System.EventArgs e)
        {
            EnviarMensagem();
        }

        private void ConectarAoServidor()
        {
            _enderecoServidor = textBoxIp.Text;
            _portaServidor = textBoxPorta.Text;
            _nomeUsuario = textBoxUsuario.Text;
            buttonConectar.Enabled = false;
            buttonDesconectar.Enabled = true;
            buttonEnviar.Enabled = true;
            textBoxConversa.Clear();
            textBoxInput.Clear();
            listBoxOnline.Items.Clear();
        }

        private void DesconectarDoServidor()
        {
            buttonConectar.Enabled = true;
            buttonDesconectar.Enabled = false;
            buttonEnviar.Enabled = false;
            textBoxConversa.Clear();
            textBoxInput.Clear();
            listBoxOnline.Items.Clear();
        }

        private void EnviarMensagem()
        {
            _mensagemAEnviar = textBoxInput.Text;
            textBoxInput.Clear();

            byte[] mensagemCriptografada = AesCriptografia.Criptografar(_mensagemAEnviar, CHAVE_ENCRIPTACAO);

            //Resto do método para enviar ao backend
        }

        private void ReceberMensagem(MensagemRecebidaModelo comando)
        {
            string mensagemDescriptografada = AesCriptografia.Descriptografar(comando.CorpoMensagem, CHAVE_ENCRIPTACAO);

            textBoxConversa.Text += $"\n{comando.Remetente} escreveu: {mensagemDescriptografada}";
        }
    }
}
