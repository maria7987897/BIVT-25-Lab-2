using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            int b = 0;
            for (int i = 1; i <= n + E; i++)
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
                a -= b;
                quotient++;
            }
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double ap = 1;
            double bp = 1;
            double an = 2;
            double bn = 1;
            double n = 0;
            do
            {
                double s1 = an;
                an += ap;
                ap = s1;
                double s2 = bn;
                bn += bp;
                bp = s2;
                n = an / bn;
            }
            while (Math.Abs(ap / bp - an / bn) > E);
            answer = n;
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            do
            {
                b = b * q;
                answer++;
            }
            while (Math.Abs(b) >= E);
            answer += 1;
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
        public long Task6()
        {
            long answer = 0;

            // code here
            int n = 64;
            double s = 0;
            double a = 1;
            for (int i = 1; i < n; i++)
            {
                a *= 2;
                s += a;
            }
            answer = (long)Math.Floor(s / 15 / 1000 / 1000);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double con = S;
            double v = S;
            double proc = d / 1200;
            while (v * 2 > S && S > 0)
            {
                for (int i = 1; i <= 12; i++)
                {
                    S = S + con * proc;
                    answer++;
                    if (S >= v * 2)
                        break;
                }
                con = S;
            }
            //double con = S;
            //int n = 0;
            //double zar = d / 1200;
            //while (S > 0 && con*2 > S)
            //{
            //    n++;
            //    if (n % 12 != 0)
            //    {
            //        S = S + con * zar;
            //        answer++;
            //    }
            //    else
            //    {
            //        con = S;
            //        answer++;
            //    }
            //}
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (S > 0)
            //    {
            //        double nov = S * d / 100 / 12;
            //        int n = 0;
            //        do
            //        {
            //            S += nov;
            //            answer++;
            //        }
            //        while (2 * con >= S && answer % 12 != 0);
            //    }
            //}
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 0.00001; x += h)
            {
                double s = 0;
                int i = 0;
                while (true)
                {
                    double pr = 1;
                    for (int j = 1; j <= 2 * i; j++)
                        pr *= j;
                    double term = (Math.Pow(-1, i) * Math.Pow(x, 2 * i) / pr);
                    if (Math.Abs(term) < E)
                        break;
                    s += term;
                    i++;
                }
                SS += s;
                SY += Math.Cos(x);
                //double s = 0;
                //int i = 0;
                //double last = 1;
                //double pr = 1;
                //for (int j = 0; j <= 2 * i; j++)
                //    pr *= j;
                //while ((Math.Pow(-1, i) * Math.Pow(x, 2 * i) / pr) >= E)
                //{
                //    s += last;
                //    last = (Math.Pow(-1, i) * Math.Pow(x, 2 * i) / pr);
                //    i++;
                //}
                //SS += s;
                //SY += Math.Cos(x);
                //for (int i = 1; i < 10000; i++)
                //{
                //    double pr = 1;
                //    for (int j = 1; j <= 2 * i; j++)
                //    {
                //        pr *= j;
                //    }
                //    int p = -i;
                //    double hre = (p * Math.Pow(x, 2 * i) / pr);
                //    if (Math.Abs(hre) >= 0.0001)
                //    {
                //        SS += hre;
                //    }
                //    else
                //    {
                //        break;
                //    }
                //}
                //SS += 1;
                //SY += Math.Cos(x);
                //SS = SY;
            }
            
                //for (double x = a; x <= b; x += Math.Round(h, 4))
                //{
                //    double s = 0;
                //    for (int i = 1; i <= 100; i++)
                //    {
                //        double pr = 1;
                //        for (int c = 1; c <= 2*i; c++)
                //        {
                //            pr *= c;

                //        }
                //        s = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / pr;
                //        if (s >= E)
                //            SS += s;
                //        else
                //            break;
                //    }
                //    SY += Math.Cos(x);
                //}
                //SS += 1; 
                // end

                return (SS, SY);
        }
    }
}