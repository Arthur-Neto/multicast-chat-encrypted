using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Chat.Infraestrutura.Crypto
{
    public static class AesCriptografia
    {
        public static byte[] Criptografar(string textoLimpo, string chave)
        {
            byte[] bytesLimpos = Encoding.UTF8.GetBytes(textoLimpo);
            byte[] encriptado;
            using (Aes encryptor = Aes.Create())
            {
                var pdb = new Rfc2898DeriveBytes(chave, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesLimpos, 0, bytesLimpos.Length);
                        cs.Close();
                    }
                    encriptado = ms.ToArray();
                }
            }
            return encriptado;
        }

        public static string Descriptografar(byte[] bytesCifrados, string chave)
        {
            string textoCifrado = "";
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(chave, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesCifrados, 0, bytesCifrados.Length);
                        cs.Close();
                    }
                    textoCifrado = Encoding.UTF8.GetString(ms.ToArray());
                }
            }
            return textoCifrado;
        }
    }
}
