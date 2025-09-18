using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double xdeg = 1;
            for (int i = 0; i < n; ++i)
            {
                answer += Math.Sin((i + 1) * x) / xdeg;
                xdeg *= x;
            }
            // end
            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double deg5 = 5, fct = 1, tmp = -1;
            for (int i = 0; i < n; ++i)
            {
                fct *= (i + 1);
                answer += tmp * (deg5 / fct);
                deg5 *= 5;
                tmp *= -1;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int f1 = 0, f2 = 1;
            for (int i = 1; i < n; ++i)
            {
                int t = f2;
                f2 = f1 + f2;
                f1 = t;
                answer += f1;
            }

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = a;
            for (int i = 1; s <= L; ++i)
            {
                ++answer;
                s += a + i * h;
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
            while (S < L)
            {
                answer += h;
                S *= 2;
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
            a = S;
            double tmp = S;
            for (int i = 1; i < 7; ++i)
            {
                tmp += tmp * I / 100;
                a += tmp;
            }
            ++b;
            tmp = S;
            double sm = tmp ;
            while (sm < 100)
            {
                ++b;
                tmp += tmp * I / 100;
                sm += tmp;
            }
            tmp = S;
            while (tmp < 42)
            {
                ++c;
                tmp += tmp * I / 100;
            }

            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 1e-4; x += h)
            {
                double i = 0, xdeg = 1, ifact = 1;
                double ch = (2 * i + 1) * (xdeg * xdeg) / ifact;
                while (ch >= 0.00001)
                {
                    SS += ch;
                    ++i;
                    ifact *= i;
                    xdeg *= x;
                    ch = (2 * i + 1) * (xdeg * xdeg) / ifact;
                }
                SY += (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
            }
            
                // end

                return (SS, SY);
        }
    }
}