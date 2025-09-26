using System.Collections.Generic;
using System.ComponentModel;
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
            for (int i = 0; i < n; i++)
            {
                answer += Math.Sin((i+1) * x) / Math.Pow(x, i);
            }

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double st = 5;
            double f = 1;
            double minusone = -1;
            if (n > 0)
            {

                for (int i = 1; i <= n; i++)
                {
                    answer += (minusone * (st / f));
                    minusone *= -1;
                    f *= (i + 1);
                    st *= 5;
                }
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n == 1)
            {
                answer = 0;
            }
            else if (n == 2)
            {
                answer = 1;
            }
            else
            {
                long a = 0;
                long b = 1;
                long otv = 0;
                for (int i = 2; i <= n; i++)
                {
                    otv = a + b;
                    answer += b;
                    a = b;
                    b = otv;
                }
            }

            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            if (a > L)
            {
                answer = 0;
            }
            else {
                int s = a;
                while (s <= L)
                {
                    answer += 1;
                    s += a + (answer * h);
                }
            }
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
            while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S <= L)
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
            double sa = S;
            double sb = S;
            double sc = S;
            for (int i = 0; i < 7; i++)
            {
                a += sa;
                sa = sa * (1 + (I / 100));
            }
            double l = 0;
            while (l < 100)
            {
                l += sb;
                sb = sb * (1 + (I / 100));
                b += 1;
            }
            while (sc <= 42)
            {
                sc = sc * (1 + (I / 100));
                c += 1;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            //int i = 0;
            //double st = 1;
            //double x = a;
            //int f = 1;

            //for (double k = a; k <= b; k += h)
            //{
            //    double temp = (2 * i + 1) * st / f;
            //    SS += temp;
            //    SY = (1 + 2 * Math.Pow(x, 2)) * Math.Pow((Math.E), x * x);
            //    if (Math.Abs(temp) < 0.0001)
            //    {
            //        break;
            //    }
            //    x += h;
            //    st = st * x * x;
            //    i++;
            //    f *= i;
            //}
            for (double x = a; x <= b + E; x += h)
            {
                double s = 0;
                int i = 0;
                double count = 1;
                double fact = 1.0;
                while (count >= E)
                {
                    if (i > 0) fact *= i;
                    count = (2 * i + 1) * Math.Pow(x, 2 * i) / fact;
                    s += count;
                    i++;
                }

                SY += (1 + 2 * x * x) * Math.Exp(x * x);
                SS += s;
            }
            // end

            return (SS, SY);
        }
    }
}
