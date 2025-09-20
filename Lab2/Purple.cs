using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq.Expressions;
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
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                s += Math.Pow(p + i * h, 2);
            }
            answer = (int)s;
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            remainder = a;
            while (remainder >= b)
            {
                remainder -= b;
                quotient += 1;
            }
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double r = 1;
            double pr = 2;
            int ch1 = 1;
            int ch2 = 2;
            int zn1 = 1;
            int zn2 = 1;
            while (r >= E)
            {
                int ch = ch1 + ch2;
                int zn = zn1 + zn2;
                double s = (double)ch / zn;
                r = Math.Abs(s - pr);
                pr = s;
                ch1 = ch2;
                ch2 = ch;
                zn1 = zn2;
                zn2 = zn;
            }
            answer = pr;
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            int i = 1;
            double elem = b;
            while (Math.Abs(elem) >= E)
            {
                i++;
                elem = (b * Math.Pow(q, i - 1));
            }
            answer = i;
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

            // code here;
            decimal n = (decimal)(Math.Pow(2, 64)/15)/1000000;
            answer = (long)n;
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            int m = 0;
            double need = S * 2;
            double summ = S;
            while (summ < need)
            {
                m++;
                if (m % 12 == 0)
                {
                    summ = summ + S * (d/100) / 12;
                    S = summ;
                }
                else
                {
                    summ = summ + S * (d / 100) / 12;
                }
            }
            // end
            answer = m;
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b+0.00000001; x += h)
            {
                double sx = 0;
                int i = 0;
                double s = 1;
                while (Math.Abs(s) >= 0.0001)
                {
                    long fact = 1;
                    for (int j = 1; j <= 2*i; j++)
                    {
                        fact *= j;
                    }
                    s = (Math.Pow(-1, i)) * (Math.Pow(x, 2 * i)) / fact;
                    i += 1;
                    sx += s;
                }
                double sy = Math.Cos(x);
                SS += sx;
                SY += sy;
            }
            // end

            return (SS, SY);
        }
    }
}