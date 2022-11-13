using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public static class Utility
    {
        public static List<char> Alphabet { get; set; } = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public static Random Random { get; set; } = new Random();
        public static double GCD(double a, double b)
        {
            if (a == 0) return b;
            return GCD(b % a, a);
        }
        public static double ModInverse(double a, double m)
        {
            double m0 = m;
            double y = 0, x = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                double q = a / m;
                double t = m;
                m = a % m;
                a = t;
                t = y;
                y = x - q * y;
                x = t;
            }
            if (x < 0)
                x += m0;
            return x;
        }
        public static double Mod(double x, double m)
        {
            double r = x % m;
            return r < 0 ? r + m : r;
        }
        public static double LCM(double a, double b)
        {
            return (a / GCD(a, b)) * b;
        }
    }
}
