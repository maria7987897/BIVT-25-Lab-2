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
            int answer = 0;

            // code here
            for (int i=0; i<n; i++)
            {
                answer += (p + i * h) * (p + i * h);
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a>=b)
            {
                a = a - b;
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
            int a1 = 2;
            int a2 = 3;
            int midA, midB;
            int b1 = 1;
            int b2 = 2;
            double c1 = (double)a1 / b1;
            double c2 = (double)a2 / b2;
            while (Math.Abs(c1 - c2)>0.0001)
            {
                midA = a2;
                a2 = a2 + a1;
                a1 = midA;
                midB = b2;
                b2 = b2 + b1;
                b1 = midB;
                c1 = (double)a1 / b1;
                c2 = (double)a2 / b2;
            }
            answer = c2;
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 1;
            double rez = b;
            // code here
            while (Math.Abs(rez)>0.0001)
            {
                rez *= q;
                answer++;
            }
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;

            // code here
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
            ulong sum = 0;
            ulong rez = 1;
            int i = 0;
            while (i < 64)
            {
                sum += rez;
                rez *= 2;
                i++;
            }
            sum = sum / 15000000;
            answer = (long)sum;
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double final = S * 2;
            double year = S * (d / 100.0);
            int i = 0;
            while (final>S)
            {
                i++;
                if (i % 12 == 0)
                    year = S * (d / 100.0);
                S += year / 12.0;
                
            }
            answer = i;
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
                double rowSum = 1 - (x * x) / 2;
                int sign = -1;
                double ch = x * x;
                double zn = 2;
                double chislo = 1;
                while (Math.Abs(chislo) > 0.0001)
                {
                    sign *= -1;
                    ch *= x * x;
                    zn *= (zn + 1) * (zn + 2);
                    chislo = sign * ch / zn;
                    rowSum += chislo;
                }
                SS += rowSum;
                SY += Math.Cos(x);
            }
            // end

            return (SS, SY);
        }
    }
}
