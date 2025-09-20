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
            for (double i = 2; i <= n; i+=2)
            {
                double a = i / (i + 1);
                answer += a;
                Console.WriteLine(a);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i = 0; i >= -n; i--)
            {
                answer += Math.Pow(x, i);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            for (int i = 0; i <= n; i++)
            {
                long cur = 1;
                for (int j = i; j > 0; j--)
                {
                    cur *= j;
                }
                answer += cur;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int n = 1;

            while (Math.Abs(Math.Sin(n * Math.Pow(x, n))) > E)
            {
                answer += Math.Sin(n * Math.Pow(x, n));
                n++;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            int n = 0;
            double sub = 1000;
            // code here
            while (sub > E)
            {
                sub = Math.Abs(Math.Pow(x, -(n - 1)) - Math.Pow(x, -n));
                n ++;
            }
            // end
            answer = n - 1;
            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;
            // code here
            for (int i = 0; elem < limit; i++)
            {
                elem *= 2;
                answer += elem;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            double cur = L;
            // code here
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
                double pow = x;
                int sign = 1;
                int i = 0;

                while (true)
                {
                    double term = sign * pow / (2 * i + 1);
                    s += term;
                    if (Math.Abs(term) < E) break;
                    pow *= x * x;
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
