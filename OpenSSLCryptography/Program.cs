using System;

namespace OpenSSLCryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            var crypt = new OpenSSL();
            var text = "BMW:SITE";
            var encrypt = crypt.AESEncrypt(text);

            Console.WriteLine("Welcome to OpenSSL Cryptography and SSL / TLS Toolkit");
            Console.WriteLine();
            Console.WriteLine("Cryptography " + text);
            Console.WriteLine("Encrypt " + encrypt);
            Console.WriteLine("Descrypt " + crypt.AESDecrypt(encrypt));
            
            encrypt = crypt.OpenSSLEncrypt(text, "secrect word pass !@#$%");
            Console.WriteLine();
            Console.WriteLine("Cryptography " + text);
            Console.WriteLine("Encrypt " + encrypt);
            Console.WriteLine("Descrypt " + crypt.OpenSSLDecrypt(encrypt, "secrect word pass !@#$%"));            
        }
    }
}
