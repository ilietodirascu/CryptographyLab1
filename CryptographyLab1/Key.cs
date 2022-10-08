using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyLab1
{
    public class Key<T>
    {
        public T Value { get; set; }
        public Key(T value)
        {
            Value = value;
        }
    }
}
