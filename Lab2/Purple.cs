using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += (p + (i - 1) * h) * (p + (i - 1) * h);
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a >= b)
            {
                quotient += 1;
                a -= b;
            }
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            List<double> a = new List<double>{ 1, 2, 3 };
            List<double> b = new List<double>{ 1, 1, 2 };


            double curr = a[a.Count - 1] / b[b.Count - 1];
            double prev = a[a.Count - 2] / b[b.Count - 2];
            while (Math.Abs(curr - prev) > E)
            {
                a.Add(a[a.Count - 1] + a[a.Count - 2]);
                b.Add(b[b.Count - 1] + b[b.Count - 2]);
                
                curr = a[a.Count - 1] / b[b.Count - 1];
                prev = a[a.Count - 2] / b[b.Count - 2];
            }
            answer = curr;
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            int n = 1;
            double cur = b;
            while(Math.Abs(cur) > E)
            {
                n++;
                cur *= q;
            }
            answer = n;
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
            long number = a;
            while (b > 0)
            {
                number *= b;
                b--;
            }
            while (number >= 10)
            {
                number /= 10;
                answer++;
            }   
            // end

            return answer;
        }
        public ulong MyPow(ulong a, ulong p)
        {
            if (p == 0) return (ulong)1;
            return a * MyPow(a, p - 1);
        }
        public long Task6()
        {
            long answer = 0;

            // code here

            ulong cur = MyPow(2, 64) - 1;
            Console.WriteLine(cur);
            ulong ans = ((ulong)cur / (ulong)15) / (ulong)1000 / (ulong)1000;
            // end
            answer = (long)ans;
            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double curr_S = S;
            int curr_month = 1;
            double curr_add = S / 100 * d;
            while (curr_S < 2 * S )
            {
                curr_S += curr_add / 12;
                curr_month++;
                if (curr_month % 12 == 0)
                {
                    curr_add = curr_S / 100 * d;
                }
            }
            // end
            answer = curr_month - 1;
            return answer;
        }
        public double DoublePow(double a, int p)
        {
            if (p == 0) return 1.0;
            return a * DoublePow(a, p - 1);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (int k = 0; a + k * h <= b; k++)
            {
                double x = a + k * h;
                for (int i = 0; ; i++)
                {
                    double el = i % 2 == 0 ? 1 : -1;
                    el *= DoublePow(x, 2 * i);
                    double fact = 1;
                    for (int j = 1; j <= 2 * i; j++)
                    {
                        fact *= j;
                    }
                    // 
                    el /= fact;
                    SS += el;
                    if (Math.Abs(el) < E) break;
                }
                SY += Math.Cos(x);
            }
            // end

            return (SS, SY);
        }
    }
}


