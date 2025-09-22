using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Transactions;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double s = 0, a = 1;
            int k = 1;
            while (k != n + 1)
            {
                s += Math.Sin(x * k) / a;
                a *= x;
                k++;
            }
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            double s = 0;
            // code here
            //double su;
            //if (n == 0)
            //{
            //    answer = 0;
            //}
            //else
            //{
            //    int a = -1, b = 5;
            //    for (int k = 1; k != n + 1; k++)
            //    {
            //        su = a * b;
            //        int c = k;
            //        while (c != 0)
            //        {
            //            su /= c;
            //            c--;
            //        }
            //        s += su;
            //        a *= -1;
            //        b *= 5;
            //    }
            //    answer = s;
            //}

            if (n == 0)
            {
                answer = 0;
            }
            else
            {
                for (int k = 1; k != n + 1; k++)
                {
                    double a = Math.Pow(-1, k) * Math.Pow(5, k);
                    int c = k;
                    while (c != 1)
                    {
                        a /= c;
                        c--;
                    }
                    s += a;
                }

                answer = s;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            // code here

            switch (n)
            {
                case 0: answer = 0; break;
                case 1: answer = 0; break;
                case 2: answer = 1; break;
                case 3: answer = 2; break;
                default:
                    int su = 4;
                    for (int k = 4, a = 2, b = 1; k != n; k++)
                    {
                        int c = a + b;
                        su += a + b;
                        b = a;
                        a = c;
                    }
                    answer = su;
                    break;
            }


                // end

                return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0, n = 1, c = 0;
            while (s < L)
            {
                s += (a + (n - 1) * h);
                n++;
                c++;
            }
            if (s == L)
            {
                answer = c;
            }
            else
            {
                answer = c - 1;
            }
                // end

                return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
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
            int t = 0;
            while (S < L)
            {
                S *= 2;
                t += h;

            }
            answer = t;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = S;
            int b = (int) S;
            int c = 0;

            // code here

            //a
            double Sa = S;
            int ka = 1;
            while (ka != 7)
            {
                Sa *= (1 + 0.01 * I);
                a += Sa;
                ka++;
            }

            //b
            int kb = 1;
            double Sb = S;
            double Sub = S;
            while (Sub < 100)
            {
                Sb *= (1 + 0.01 * I);
                Sub += Sb;
                kb++;
            }
            b = kb;

            //c
            int kc = 0;
            double Sc = S;
            while (Sc < 42)
            {
                Sc *= (1 + 0.01 * I);
                kc++;
            }
            c = kc;


            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 0.0001; x += h)
            {
                SY += (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
                int i = 0;
                bool f = true;
                while (true)
                {
                    double a1 = 2 * i + 1, b1 = Math.Pow(x, 2 * i);
                    double s = a1 * b1;
                    double su = 0;
                    int c = i;
                    while (c != 0)
                    {
                        s /= c;
                        c--;
                    }
                    SS += s;
                    if (Math.Abs(s) < 0.0001)
                    {
                        break;
                    }
                    i++;
                }
            }
            
            // end

            return (SS, SY);
        }
    }
}
