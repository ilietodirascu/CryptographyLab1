using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLab2
{
    public class Program
    {
        static void Main()
        {
            Feistel feistel = new("I am a faf student");
            string phrase = "One lab a day keeps restanta away";
            string key_phrase = "Viorel Bostan";
            byte[] data = Encoding.UTF8.GetBytes(phrase);
            byte[] key = Encoding.UTF8.GetBytes(key_phrase);
            byte[] encrypted_data = RC4.EncDec(data, key);
            byte[] decrypted_data = RC4.EncDec(encrypted_data, key);
            string decrypted_phrase = Encoding.UTF8.GetString(decrypted_data);
            Console.WriteLine("Phrase:\t\t\t{0}", phrase);
            Console.WriteLine("Phrase Bytes:\t\t{0}", BitConverter.ToString(data).Replace("-", ""));
            Console.WriteLine("Key Phrase:\t\t{0}", key_phrase);
            Console.WriteLine("Key Bytes:\t\t{0}", BitConverter.ToString(key).Replace("-", ""));
            Console.WriteLine("Encryption Result:\t{0}", BitConverter.ToString(encrypted_data).Replace("-",""));
            Console.WriteLine("Decryption Result:\t{0}", BitConverter.ToString(decrypted_data).Replace("-", ""));
            Console.WriteLine("Decrypted Phrase:\t{0}", decrypted_phrase);
        }
    }
}
