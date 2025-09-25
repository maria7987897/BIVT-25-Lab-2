using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0, j;
            for(int i = 1; i <= n; i++)
            {
                answer += (p + (i - 1) * h)*(p + (i - 1) * h);
            }
            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;
            int z = a;
            int t = 0;
            while(a-b>=0)
            {
                t++;
                a -= b;
            }
            if(z-b*t != 0)
            {
                remainder = z - b * t;
            }
            else
            {
                remainder = 0;
            }

                return (t, remainder);
        }
        public double Task3()
        {
            double answer;
            double x1 = 1, x2 = 1, y1 = 2, y2 = 1;
            double z1 = x1 + y1, z2 = x2 + y2;
            while( Math.Abs(y1/y2 - z1/z2)>= 0.0001)
            {
                z1 += y1;
                z2 += y2;
                y1 = z1 - y1;
                y2 = z2 - y2;
            }
            answer = z1 / z2;
            return answer;
           
        }
        public int Task4(double b, double q)
        {
            int answer = 1;
            b = Math.Abs(b);
            while(b >= 0.0001)
            {
                answer++;
                b *= Math.Abs(q);
            }
            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;
            while(b > 0)
            {
                number *= b;
                b--;
            }
            while(number >= 10)
            {
                number /= 10;
                answer++;
            }
            return answer;
        }
        public long Task6()
        {
            double answer = 0;
            double s = 0, j = 1;
            for(int i = 1; i <= 64; i++)
            {
                s += j;
                j *= 2;
            }
            answer = s / 15000000;
            return (long)answer;
        }

        public int Task7(double S, double d)
        {
            int t = 0;
            double x = d / 100.0 / 12, S1 = S * x, T = S;
            while(S < 2*T)
            {
                t++;
                S += S1;
                if (t % 12 == 0)
                {
                    S1 = S * x;
                }
                
            }
            return t;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SY = 0;
            double S = 0, eps = 0.0001;
            for(double x = a; x <= b + 0.0001; x += h)
            {
                int i = 1;
                double p = 1, num = 1, den = 1;
                while(Math.Abs(p * num /  den) >= eps)
                {
                    S += p * num / den;
                    p = -p;
                    num *= (x * x);
                    den *= 2 * i * (2 * i - 1);
                    i++;
                }
                SY += Math.Cos((double)x);
            }
            return (S, SY);
        }
    }
}
