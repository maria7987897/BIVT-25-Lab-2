using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public long fac(int n) //метод нахождения факториала
        {
            long k = 1;
            for (int t = 1; t <= n; t++)
            {
                k = k * t;
            }
            return k;
        }
        public int power(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return power(x, n-1) * x;
            }
        }
        public double Task1(int n)
        {
            double answer = 0;
            // code here
            double a = 0;
            for (int i = 2; i <= n; i += 2)
            {
                a = i;
                a = a / (i + 1);
                answer += a;
                // end
            }
                return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            answer++;
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Pow(x, -i);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                long k = 1;
                k = fac(i);
                answer += k;
                // end
            }
            answer += 1; //т.к. 0! = 1
                return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            // code here
            double a = 1;
            int n = 1;
            while (Math.Abs(a) > E)
            {
                a = Math.Sin(n * Math.Pow(x, n));
                answer += a;
                n++;
            }
            // end
            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            int n = 0;
            // code here
            if (x > 0)
            {
                while (Math.Abs(1 / Math.Pow(x, (n - 1))) - Math.Abs(1 / Math.Pow(x, n)) > 0.0001)
                {
                    n++;
                }
            }
            else
            {
                while (Math.Abs(1 / Math.Pow(x, n)) + Math.Abs(1 / Math.Pow(x, (n - 1))) > 0.0001)
                {
                    n++;
                }
            }
            // end
            answer = n;
            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
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
            for (double x = a; x <= b + 0.0001; x += h)
            {
                int p = -1;
                double n = 1;
                double sn = 1;
                int i = 0;
                while (Math.Abs(sn) >= E)
                {
                    sn = -p * x * n / (2 * i + 1);
                    p = -1 * p;
                    SS += sn;
                    n = n * x * x;
                    i++;
                }

                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}
