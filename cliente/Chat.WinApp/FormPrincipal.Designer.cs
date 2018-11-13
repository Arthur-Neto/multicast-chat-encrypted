namespace Chat.WinApp
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxConversa = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxOnline = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.labelPorta = new System.Windows.Forms.Label();
            this.textBoxPorta = new System.Windows.Forms.TextBox();
            this.labelIp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxConversa
            // 
            this.textBoxConversa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConversa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxConversa.Location = new System.Drawing.Point(0, 0);
            this.textBoxConversa.Multiline = true;
            this.textBoxConversa.Name = "textBoxConversa";
            this.textBoxConversa.ReadOnly = true;
            this.textBoxConversa.Size = new System.Drawing.Size(552, 414);
            this.textBoxConversa.TabIndex = 7;
            // 
            // textBoxInput
            // 
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(0, 0);
            this.textBoxInput.MaxLength = 200;
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(471, 44);
            this.textBoxInput.TabIndex = 8;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Enabled = false;
            this.buttonEnviar.Location = new System.Drawing.Point(699, 472);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 44);
            this.buttonEnviar.TabIndex = 9;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxOnline);
            this.panel1.Location = new System.Drawing.Point(5, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 464);
            this.panel1.TabIndex = 100;
            // 
            // listBoxOnline
            // 
            this.listBoxOnline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOnline.FormattingEnabled = true;
            this.listBoxOnline.Location = new System.Drawing.Point(0, 0);
            this.listBoxOnline.Name = "listBoxOnline";
            this.listBoxOnline.Size = new System.Drawing.Size(211, 464);
            this.listBoxOnline.Sorted = true;
            this.listBoxOnline.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxConversa);
            this.panel2.Location = new System.Drawing.Point(222, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 414);
            this.panel2.TabIndex = 101;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxInput);
            this.panel3.Location = new System.Drawing.Point(222, 472);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 44);
            this.panel3.TabIndex = 102;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxIP);
            this.panel4.Controls.Add(this.textBoxUsuario);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.buttonDesconectar);
            this.panel4.Controls.Add(this.buttonConectar);
            this.panel4.Controls.Add(this.labelPorta);
            this.panel4.Controls.Add(this.textBoxPorta);
            this.panel4.Controls.Add(this.labelIp);
            this.panel4.Location = new System.Drawing.Point(5, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(769, 34);
            this.panel4.TabIndex = 104;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(29, 8);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(160, 20);
            this.textBoxIP.TabIndex = 1;
            this.textBoxIP.Text = "224.0.0.1";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(406, 8);
            this.textBoxUsuario.MaxLength = 50;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(160, 20);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "Nome de Usuário:";
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.Enabled = false;
            this.buttonDesconectar.Location = new System.Drawing.Point(672, 4);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Size = new System.Drawing.Size(91, 27);
            this.buttonDesconectar.TabIndex = 5;
            this.buttonDesconectar.Text = "Desconectar";
            this.buttonDesconectar.UseVisualStyleBackColor = true;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(591, 4);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(75, 27);
            this.buttonConectar.TabIndex = 4;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // labelPorta
            // 
            this.labelPorta.AutoSize = true;
            this.labelPorta.Location = new System.Drawing.Point(195, 11);
            this.labelPorta.Name = "labelPorta";
            this.labelPorta.Size = new System.Drawing.Size(35, 13);
            this.labelPorta.TabIndex = 3;
            this.labelPorta.Text = "Porta:";
            // 
            // textBoxPorta
            // 
            this.textBoxPorta.Location = new System.Drawing.Point(236, 8);
            this.textBoxPorta.Name = "textBoxPorta";
            this.textBoxPorta.Size = new System.Drawing.Size(66, 20);
            this.textBoxPorta.TabIndex = 2;
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Location = new System.Drawing.Point(3, 11);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(20, 13);
            this.labelIp.TabIndex = 0;
            this.labelIp.Text = "IP:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 529);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConversa;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBoxOnline;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Label labelPorta;
        private System.Windows.Forms.TextBox textBoxPorta;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIP;
    }
}

