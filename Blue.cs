using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double a = 1;
            for (int i = 1; i <= n; ++i)
            {
                answer += Math.Sin(i * x) / a;
                a *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            if (n != 0)
            {
                double a = -5;
                answer = a;
                for (int i = 2; i <= n; ++i)
                {
                    answer += a * -1 * 5 / i;
                    a = a * -1 * 5 / i;
                }
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a = 0, b = 1;
            for (int i = 3; i <= n + 2; ++i)
            {
                answer = a + b;
                a = b;
                b = answer;
            }
            --answer;
            if (n == 0)
            {
                answer = 0;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int n = -1;
            while (answer <= L)
            {
                ++n;
                answer += a + h * n;
            }
            answer = n;
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
                ++i;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            if (L > S)
            {
                int b = L / S, a = 0;
                if (L % S != 0)
                {
                    ++b;
                }
                int i = 0, c = 1;
                while (c < b)
                {
                    ++i;
                    c *= 2;
                }
                answer = i * h;
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
            bool ta = false, tb = false, tc = false;
            int cnt = 1;
            double sum = S;
            const double const_b = 100.0, const_c = 42.0;
            do
            {
                if (cnt == 7)
                {
                    a = sum;
                    ta = true;
                }
                if (tb == false && sum >= const_b)
                {
                    b = cnt;
                    tb = true;
                }
                if (tc == false && S > const_c)
                {
                    c = cnt - 1;
                    tc = true;
                }
                ++cnt;
                S = S + S * I / 100;
                sum += S;
            } while (ta == false || tb == false || tc == false);
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double x = a;
            while (x <= b + E)
            {
                double elem = 1.0;
                SS += elem;
                for (int i = 1; Math.Abs(elem) >= E; ++i)
                {
                    elem = elem * x * x * (2 * i + 1) / (i * (2 * i - 1));
                    SS += elem;
                }
                elem = x * x;
                SY += (1 + 2 * elem) * Math.Exp(elem);
                x += h;
            }
            // end

            return (SS, SY);
        }
    }
}