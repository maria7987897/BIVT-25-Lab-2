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
            for (int i = 0; i<n; i++)
            {
                answer += (p + h * i) * (p + h * i);
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
            double fi1 = 1.0, fi2 = 1.0, fi3 = 2.0, fi4;
            while (Math.Abs((double)fi3/fi2 - (double)fi2/fi1) > 0.0001)
            {
                fi4 = fi2 + fi3;
                fi1 = fi2;
                fi2 = fi3;
                fi3 = fi4;
            }
            answer = (double)fi3 / (double)fi2;
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            answer++;
            while (Math.Abs(b) > 0.0001)
            {
                answer++;
                b *= q;
            }
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
            while ( number >= 10)
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
            answer = (long)(~(ulong)0/ 15000000);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double money = 0, Stemp=S;
            while (Stemp < S*2)
            {
                if (answer % 12 == 0)
                {
                    money = Stemp * d / 1200.0;
                }
                answer++;
                Stemp += money;
            }
            // end

            return answer;
        }
         public static long Fact(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Fact(n - 1);
            }
        }
        public static double GetPow(double n, int j)
        {
            if (j == 0)
            {
                return 1;
            }
            else
            {
                return n * GetPow(n, j - 1);
            }
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
           
            double SS = 0;
            double SY = 0;
            // code here
            int i;
            double temp;
            for (double x = a; x <= b + 0.000000001; x += h) // I hate floating-point calculations
            {
                i = 1;
                SY += Math.Cos(x);
                temp = 1;
                while (Math.Abs(temp) >= 0.00001)
                {
                    SS += temp;
                    temp = GetPow((-1), i) * GetPow(x, (int)(2 * i)) / Fact(2 * i);
                    i++;
                }
            }
            // end

            return (SS, SY);
        }
    }
}
