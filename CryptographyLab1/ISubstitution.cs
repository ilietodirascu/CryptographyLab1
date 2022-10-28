﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyLab1
{
    public interface ISubstitution<T>
    {
        public string Encrypt(string word, T key);
        public string Decrypt(string word, T key);
    }
}
