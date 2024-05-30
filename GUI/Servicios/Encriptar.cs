using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Encriptar
    {
        public static string EncriptarC(string pEncriptar)
        {
            UnicodeEncoding codigo = new UnicodeEncoding();
            byte[] bTexto = codigo.GetBytes(pEncriptar);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] resultado = md5.ComputeHash(bTexto);
            string salida = Convert.ToBase64String(resultado);
            return salida;
        }
        public static bool Compare(string pCompare, string pEncriptar)
        {
            if (EncriptarC(pCompare) == pEncriptar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
