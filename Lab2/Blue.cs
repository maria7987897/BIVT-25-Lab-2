using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Math;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double x2 = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += Sin(i*x)/x2;
                x2 *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double Factorial = 1;
            double x = -5;
            double x2 = -5;
            for (int i = 1; i <= n; i++)
            {

                Factorial *= i;
                answer += x2 / Factorial;
                x2 *= x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int x1 = 0;
            int x2 = 1;
            int t = 0;
            for (int i = 0; i <= n-2; i++)
            {
                answer += x2;
                t = x1;
                x1 = x2;
                x2 += t;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            while (s <= L)
            {
                s += a + (answer * h);
                answer++;
            }
            answer--;
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
            }
            while (elem > 0.0001 || i == 1);
            // end
            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S < L)
            {
                S *= 2;
                answer += h;
            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here

            int days = 1;
            double km = 0;
            double kmPerDay = 0;
            double t = S;

            a = S;
            while (days < 7)
            {
                days++;
                S = S + S * I/100;
                a += S;
            }

            S = t;
            km = S;
            b = 1;
            while (km <= 100)
            {
                S = S + S * I / 100;
                km += S;
                b++;
            }

            S = t;
            kmPerDay = S;
            while (kmPerDay <= 42)
            {
                S = S + S * I / 100;
                kmPerDay = S;
                c++;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double x = a;
            while (Math.Round(x, 7) <= b) 
            {
                double x2 = 1;
                int i = 0;
                int i2 = 1;
                while (Math.Abs(((2*i + 1) * x2)/i2) >= 0.0001)
                {
                    SS += ((2 * i + 1) * x2) / i2;
                    SY += (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
                    i++;
                    x2 *= x*x;
                    i2 *= i;
                }
                x += h;
            }
            // end

            return (SS, SY);
        }
    }
}
