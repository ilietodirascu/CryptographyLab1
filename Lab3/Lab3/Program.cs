using System;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rsa = new RSA();
            var encrypted = rsa.Encrypt("Viorel Bostan",53,59);
            Console.WriteLine(rsa.Decrypt(encrypted, 53, 59));
        }
    }
}
