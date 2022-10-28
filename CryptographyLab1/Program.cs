using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CryptographyLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var caesar = new CaesarCipher();
            var viginere = new VigenereCipher();
            var affine = new AffineCipher();
            var permCaesar = new CaesarPermutation();
            var word = caesar.Encrypt(Console.ReadLine(),1);
            Console.WriteLine(word);
            Console.WriteLine(caesar.Decrypt(word));
            word = Console.ReadLine();
            Console.WriteLine(permCaesar.Encrypt(word,1));
            Console.WriteLine(permCaesar.Decrypt(word, 1));
            var encryptedViginere = viginere.Encrypt("I am a FAF student", "cafe");
            Console.WriteLine(encryptedViginere);
            Console.WriteLine(viginere.Decrypt(encryptedViginere, "cafe"));
            var encryptedAffine = affine.Encrypt("AFFINE CIPHER", new KeyValuePair<int, int>(17,20));
            Console.WriteLine(encryptedAffine);
            Console.WriteLine(affine.Decrypt(encryptedAffine,new KeyValuePair<int, int>(17,20)));
        }
    }
}
