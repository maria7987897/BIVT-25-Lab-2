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
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / Math.Pow(x, i - 1);
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                answer += Math.Pow(-1, i) * (Math.Pow(5, i) / factorial);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                answer += a;
                int sec_a = a;
                a = b;
                b = sec_a + b;
            }
            // end

                return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int summa = 0;
            while (summa <= L)
            {
                summa += a + h * answer;
                answer += 1;
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
            double last_day = S;
            for (int i = 0; i < 7; i++)
            {
                a += last_day;
                last_day = last_day * (1 + I / 100);
            }


            double run = 0;
            double last_day_2 = S;
            while (run < 100)
            {
                b += 1;
                run += last_day_2;
                last_day_2 = last_day_2 * (1 + I / 100);
            }


            double last_day_3 = S;
            while (last_day_3 <= 42)
            {
                c += 1;
                last_day_3 = last_day_3 * (1 + I / 100);
            }
            ;
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            double eps = 1e-4;

            for (double x = a; x <= b + 1e-12; x += h)
            {
                double s = 0.0;
                double tt = 1.0;
                int i = 0;
                int gg = 0;

                while (true)
                {
                    s += tt;
                    if (Math.Abs(tt) < eps || gg++ >= 1_000_000)
                        break;

                    tt = tt * (x * x) * (2.0 * i + 3.0) / ((i + 1.0) * (2.0 * i + 1.0));
                    i++;
                }

                double y = (1.0 + 2.0 * x * x) * Math.Exp(x * x);

                SS += s;
                SY += y;
            }
            
            // end

            return (SS, SY);
        }
    }
}
