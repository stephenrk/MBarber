using System;
using System.Text;

namespace UNASP.MBarber.Common
{
    public static class Criptografia
    {
        public static String CriptografaMd5(String senha)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(senha));

            String senhaCriptografada = BitConverter.ToString(s).ToLower();

            return senhaCriptografada;
        }
    }
}
