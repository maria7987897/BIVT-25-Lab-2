using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;
            // code here
            for (double i = 2.0; i <= n; i += 2)
            {
                double a = i / (i + 1);
                answer += a;
            }
            // end
            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;
            // code here
            for (int i = 0; i <= n; i++)
            {
                answer += Math.Pow(x, -i);
            }
            // end
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;
            // code here
            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += fact * i;
                fact = fact * i;
            }
            // end
            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            // code here
            int i = 1;
            while (Math.Abs(Math.Sin(i * Math.Pow(x, i))) > E)
            {
                answer += Math.Sin(i * Math.Pow(x, i));
                i++;
            }
            // end
            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            // code here
            int n = 0;
            while (true)
            {
                double l = 1.0 / Math.Pow(x, n);
                double r = 1.0 / Math.Pow(x, n - 1);
                if (Math.Abs(l - r) < E) {break;}
                n++;
            }
            answer = n;
            // end
            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            // code here
            int el = 1;
            for (int i = 0; el < limit; i++)
            {
                el *= 2;
                answer += el;
            }
            // end
            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            // code here
            double cur = L;
            while (cur > Da)
            {
                cur /= 2;
                answer++;
            }
            // end
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 1e-9; x += h)
            {
                double s = 0;
                double x2 = x;
                int sign = 1;
                int i = 0;
                while (true)
                {
                    double t = sign * x2 / (2 * i + 1);
                    s += t;
                    if (Math.Abs(t) < E) {break;}
                    x2 *= x * x;
                    sign = -sign;
                    i++;
                }
                SS += s;
                SY += Math.Atan(x);
            }
            // end
            return (SS, SY);
        }
    }
}