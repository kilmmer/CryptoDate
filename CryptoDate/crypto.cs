using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDate
{
    class crypto
    {
        /// <summary>
        /// Calculates SHA1 hash
        /// </summary>
        /// <param name="text">input string</param>
        /// <param name="enc">Character encoding</param>
        /// <returns>SHA1 hash</returns>
        
        public static string CalculateSHA1(string text, double mili)
        {
            try
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                System.Security.Cryptography.SHA1CryptoServiceProvider cryptoTransformSHA1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
                string hash = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
                return hash + mili;
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }

        public static string CalculateSHA256(string text, double mili)
        {
            try
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                System.Security.Cryptography.SHA256CryptoServiceProvider cryptoTransformSHA256 = new System.Security.Cryptography.SHA256CryptoServiceProvider();
                string hash = BitConverter.ToString(cryptoTransformSHA256.ComputeHash(buffer)).Replace("-", "");
                return hash + mili;
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }

        public static string CalculateSHA512(string text, double mili)
        {
            try
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                System.Security.Cryptography.SHA512CryptoServiceProvider cryptoTransformSHA512 = new System.Security.Cryptography.SHA512CryptoServiceProvider();
                string hash = BitConverter.ToString(cryptoTransformSHA512.ComputeHash(buffer)).Replace("-", "");
                return hash + mili;
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }

        public static string CalculateSC(string text, double mili)
        {
            try
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                System.Security.Cryptography.SHA512CryptoServiceProvider cryptoTransformSC = new System.Security.Cryptography.SHA512CryptoServiceProvider();
                string hash = BitConverter.ToString(cryptoTransformSC.ComputeHash(buffer)).Replace("-", "");
                return hash + mili;
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }
    }
}
