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
            int a = 3;
            for (int i = 2; i <= n; i += 2)
            {
                answer += (double)i / a;
                a += 2;
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            answer += 1;
            double a = 1 / x;
            for (int i = 1; i <= n; i++)
            {
                answer += a;
                a /= x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            answer += 1;
            long a = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += a * i;
                a *= i;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            // code here
            double m = x;
            int i = 1;
            while (Math.Abs(Math.Sin(i * x)) >= E)
            {
                answer += Math.Sin(i * x);
                i++;
                x *= m;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            answer++;
            double a = x;
            while (Math.Abs(1 / a - x / a) >= E)
            {
                answer++;
                a *= x;
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            // code here
            int answer = 0;
            int elem = 1, i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            while (L > Da)
            {
                L /= 2;
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
            for (double x = a; x <= b + E; x += h)
            {
                SY += Math.Atan(x);
                int sign = -1;
                double mn = 1;
                for (int i = 0; ; i++)
                {
                    double s = -1 * sign * x * mn / (2 * i + 1);
                    SS += s;
                    sign *= -1;
                    mn *= x * x;
                    if (Math.Abs(s) < E)
                    {
                        break;
                    }
                }
            }
            // end

            return (SS, SY);
        }
    }
}
