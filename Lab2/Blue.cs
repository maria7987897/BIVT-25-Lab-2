using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += (Math.Sin(i * x) / Math.Pow(x, i - 1));
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            
            for (int i = 1; i <= n; i++)
            {
                double pr = 1;
                for (int x = 1; x <= i; x++)
                {
                    pr *= x;
                }
                answer += Math.Pow(-1, i) * Math.Pow(5, i) / pr;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int pred = 0;
            int next = 1;
            {
                for (int i = 1; i <= n; i++)
                {
                    int sum = pred + next;
                    pred = next;
                    next = sum;
                }
                answer = next - 1;
            }
            
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (s <= L)
                {
                    s += (a + (i - 1) * h);
                    answer += 1;
                }
            }
            answer -= 1;
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
            if (x > 0)
            {
                ch += i;
                zn *= x; // 1.01
                answer += elem; // 0
                elem = ch / zn;
                i++;
            }
            else
                answer = 0;
            do
            {
                    ch += i;
                    zn *= x; // 1.01
                    answer += elem; // 0
                    elem = ch / zn; //1/1.01
                    i++;
            }
            while (elem > 0.0001);
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
                S = S * 2;
                t += h;
            }
            answer += t;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            a = (Math.Pow(1+I/100, 7) - 1) / I * S * 100;
            double way = S;
            double pu = S;
            while (way < 100)
            {
                way += S * (1 + I/100);
                S *= (1 + I / 100);
                b += 1;
            }
            b += 1;
            for (int n = 1; n < 3800; n++)
            {
                if (pu * Math.Pow(1 + I / 100, (n - 1)) > 42)
                {
                    c = n - 1;
                    break;
                }
            }
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
                for (int i = 0; i < 10000; i++)
                {
                    double pr = 1;
                    for (int j = 1; j <= i; j++)
                    {
                        pr *= j;
                    }
                    double hre = ((2 * i + 1) * Math.Pow(x, 2 * i) / pr);
                    if (Math.Abs(hre) >= 0.0001)
                    {
                        SS += hre;
                    }
                    else
                    {
                        break;
                    }
                }
                //    double sum = 0;
                //    double last = 1;
                //    int i = 0;
                //    while (Math.Abs(last) >= 0.0001)
                //    {
                //        sum += last;
                //        i++;
                //        double pr = 1;
                //        for (int j = 0; j <= i; j++)
                //        {
                //            pr *= j;
                //        }
                //        last = ((2 * i + 1) * Math.Pow(x, 2 * i) / pr);
                //    }
                //    SS += sum;
                double e = Math.E;
                double fi = Math.Pow(x, 2);
                SY += (1 + (2 * fi)) * Math.Pow(e, fi);
            }
            // end

            return (SS, SY);
        }
    }
}