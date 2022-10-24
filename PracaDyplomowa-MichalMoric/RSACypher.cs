using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDyplomowa_MichalMoric
{
    public class RSACypher
    {
        private bool IsPrime(int number)
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
        public List<double> GenerateKeys(int p ,int q)
        {
            Random rd = new Random();
            if(p == 0)
            {
                bool prim = false;
                int randp = 0;
                while(prim == false)
                {
                    randp= rd.Next(0, 200);
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
                    randq = rd.Next(0, 200);
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
            
            double d = modInverse(e,phi);
            List<double> output = new List<double>();
            output.Add(Convert.ToDouble(n));
            output.Add(Convert.ToDouble(phi));
            output.Add(Convert.ToDouble(e));
            output.Add(d);
            return output;
        }
    }
}
