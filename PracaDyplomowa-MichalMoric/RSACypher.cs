using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PracaDyplomowa_MichalMoric
{
    public class RSACypher
    {
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        private int Gcd(int a, int b)
        {
            int t;
            while (true)
            {
                t = a % b;
                if (t == 0)
                    return b;
                a = b;
                b = t;
            }
        }
        private int modInverse(int a, int n)
        {
            int i = n, v = 0, d = 1;
            while (a > 0)
            {
                int t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0) v = (v + n) % n;
            return v;
        }
        public List<int> GenerateKeys(int p ,int q)
        {
            Random rd = new Random();
            if(p == 0)
            {
                bool prim = false;
                int randp = 0;
                while(prim == false)
                {
                    randp= rd.Next(0, 500);
                    if(IsPrime(randp) == true)
                    {
                        p = randp;
                        prim = true;
                    }
                }
            }
            if (q == 0)
            {
                bool prim = false;
                int randq = 0;
                while (prim == false)
                {
                    randq = rd.Next(0, 500);
                    if (IsPrime(randq) == true)
                    {
                        q = randq;
                        prim = true;
                    }
                }
            }
            int n = p * q;
            int phi = (p - 1) * (q - 1);
            List<int> potentialE = new List<int>();
            int e = 2;
            while(e< phi)
            {
                if (Gcd(e, phi) == 1)
                {
                    potentialE.Add(e);
                }
                e++;
            }
            int randE = rd.Next(0, potentialE.Count-1);
            e = potentialE[randE];
            
            int d = modInverse(e,phi);
            List<int> output = new List<int>();
            output.Add(n);
            output.Add(phi);
            output.Add(e);
            output.Add(d);
            output.Add(p);
            output.Add(q);
            output.Add(potentialE.Count);
            return output;
        }
        public BigInteger encryptNumber(int message, int E, int n)
        {
            BigInteger power = BigInteger.Pow(message, E);
            BigInteger output = power % n;
            return output;
        }
        public BigInteger decryptNumber(int message, int d, int n)
        {
            BigInteger power = BigInteger.Pow(message, d);
            BigInteger output = power % n;
            return output;
        }
        public BigInteger encryptAsciiCharacter(char message , int E, int n)
        {
            int tempMess = (int)message;
            BigInteger power = BigInteger.Pow(message, E);
            BigInteger output = power % n;
            return output;
        }
        public char decryptAsciiCharacter(int message, int d , int n)
        {
            BigInteger power = BigInteger.Pow(message, d);
            int output = (int)(power % n);
            return Convert.ToChar(output);
        }
        public string encryptAscii(string message,int E , int n)
        {
            string output = "";
            foreach(char i in message)
            {
                BigInteger translate = encryptAsciiCharacter(i, E, n);
                output += translate.ToString();
                output += "-";
            }
            output = output.Remove(output.Length - 1);
            return output;
        }
        public string decryptAscii(string message, int d, int n)
        {
            string output = "";
            string[] splitMessage = message.Split('-');
            foreach(string i in splitMessage)
            {
                BigInteger translate = decryptAsciiCharacter(Convert.ToInt32(i), d, n);
                int translateSmall = (int)translate;
                output += Convert.ToChar(translateSmall);
            }
            return output;
        }
    }
}
