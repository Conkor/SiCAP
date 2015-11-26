using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SiCAP_GrupoCARARA.App_Security
{
   public class SecurityPassword
    {
        public string Encrypt(string password)
        {
            try
            {

                string key = "qualityinfosolutions"; //llave para encriptar datos

                byte[] keyArray;

                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(password);

                //Se utilizan las clases de encriptación MD5

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                //Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();

                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);

                tdes.Clear();

                //se regresa el resultado en forma de una cadena
                password = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);

            }
            catch (Exception)
            {

            }
            return password;
        }


        public string UnEncrypt(string encryptedPassword)
        {
            try
            {
                string key = "qualityinfosolutions";
                byte[] keyArray;
                byte[] Array_a_Descifrar = Convert.FromBase64String(encryptedPassword);

                //algoritmo MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();

                byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);

                tdes.Clear();
                encryptedPassword = UTF8Encoding.UTF8.GetString(resultArray);

            }
            catch (Exception)
            {

            }
            return encryptedPassword;
        }

    }
}
