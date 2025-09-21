using System.Collections.Generic;
using System.Xml;

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
            for (double i = 2; i <= n; i+= 2)
            {
                answer += i / (i + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            if (x == 0)
            {
                return answer;
            }
            for (long i = 0; i <= n; i++)
            {
                double f = 1;
                for (long j = 1; j <= i; j++)
                {
                    f /= x;
                }
                answer += f;
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
                long f = 1;
                for (long j = 1; j <= i; j++)
                {
                    f *= j;
                }
                answer += f;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double temp = 1;
            double v = Math.Sin(temp * x);
            double multipyer = x;
            while (Math.Abs(v) >= E)
            {
                answer += v;
                x *= multipyer;
                temp += 1;
                v = Math.Sin(temp * x);
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double almost_last = 1;
            double last = 1 / x;
            answer++;
            while (Math.Abs(last - almost_last) >= E)
            {
                answer++;
                last /= x;
                almost_last /= x;
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            int i = 0;
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
            while (L > E * E * E * 100)
            {
                answer++;
                L /= 2;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (decimal x = (decimal) a; x <= (decimal) b; x += (decimal) h)
            {
                decimal v = 1;
                int i = 1, power = 1;
                SS += (double) x;
                while ((double)Math.Abs(v) >= E)
                {
                    i = -i;
                    decimal znam = 2 * power + 1;
                    decimal chi = 1;
                    for (int j = 1; j <= 2 * power + 1; j++)
                    {
                        chi *= x;
                    }
                    v = i * chi / znam;
                    SS += (double)v;
                    power += 1;
                }
                SY += Math.Atan((double)x);
            }
            // end

            return (SS, SY);
        }
    }
}