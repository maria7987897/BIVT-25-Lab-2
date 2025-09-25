using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double zn = 1;
            for(int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / zn;
                zn *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double ed = -1;
            double fa = 1;
            double pyat = 5;
            for(int i = 1; i <=n; i++)
            {
                answer += (pyat * ed) / fa;
                pyat *= 5;
                fa *= (i+1);
                ed *= (-1);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int fib = 0;
            int f1 = 0;
            int f2 = 1;
            int vrem;
            for (int i = 1; i <= n; i++)
            {
                if ((i > 3))
                {
                    fib += (f1 + f2);
                    vrem = f2;
                    f2 = f1+f2;
                    f1 = vrem;
                }
                else if (i == 1) fib = 0;
                else if (i == 2) fib = 1;
                else if (i == 3) { fib = 2; f1 = 1;}
            }
            answer = fib;
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            double s=0;
            int n = 1;
            while (s <= L)
            {
                s += a + (n - 1) * h;
                n++;
                if (s > L)
                {
                    n--;
                }
            }
            answer = n-1;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            bool a = true;
            int k = 0;
            while (a)
            {
                k += h;
                S *= 2;
                if (S >= L) a = false;
            }
            answer = k;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double s1 = S;
            double put = 0;
            for(int i = 0; i < 7; i++)
            {
                a += S;
                S += (S * I) / 100;
            }
            S = s1;
            while (put <= 100)
            {
                put += S;
                S += (S * I) / 100;
                b += 1;
            }
            S = s1;
            while(S<=42)
            {
                S += (S * I) / 100;
                c += 1;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

           for(double x = a; x <= b+0.0001; x+=h)
            {
                double st = 1;
                double ifa = 1;
                double i = 0;
                double k = 1;
                SY += ((1 + x * x * 2) * Math.Pow(Math.E, x * x));
                do
                {
                    if (x == 0)
                    {

                        break;
                    }

                    k = Math.Round((2 * i + 1) * st / ifa,4);
                    SS += Math.Round(k,4);
                    i++;
                    st *= Math.Round((x * x),4);
                    ifa *= i;

                } while (k >= E);
                SS += Math.Round(k,4);
            }
            // end

            return (SS, SY);
        }
    }
}
