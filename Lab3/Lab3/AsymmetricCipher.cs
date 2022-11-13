using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public interface AsymmetricCipher
    {
        public string Encrypt(string plaintext);
        public string Decrypt(double ciphertext);
    }
}
