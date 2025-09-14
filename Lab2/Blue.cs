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

            double denominator = 1;

            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / denominator;
                denominator *= x;
            }

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here

            long numerator = 1;
            long denominator = 1;
            for (int i = 1; i <= n; i++)
            {
                numerator *= 5;
                denominator *= i;
                if (i % 2 == 1)
                {
                    answer -= (double)numerator / denominator;
                }
                else
                {
                    answer += (double)numerator / denominator;
                }
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            if (n == 2)
            {
                answer = 1; // 0 + 1
            }
            else if (n >= 3)
            {
                long fib1 = 0;
                long fib2 = 1;
                answer = fib1 + fib2;

                for (int i = 0; i < n - 2; i++)
                {
                    long fib3 = fib1 + fib2;
                    answer += fib3;
                    fib1 = fib2;
                    fib2 = fib3;
                }
            }

            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here

            int progression_sum = 0;
            int member = a;

            while (progression_sum + member <= L)
            {
                progression_sum += member;
                member += h;
                answer++;
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

            int cells = S;
            while (cells < L)
            {
                cells *= 2;
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

            double dist = S;
            for (int i = 0; i < 7; i++)
            {
                a += dist;
                dist = dist * (100 + I) / 100;
            }

            dist = S;
            double sum_dist = S;
            b = 1;
            while (sum_dist < 100)
            {
                b++;
                dist = dist * (100 + I) / 100;
                sum_dist += dist;
            }

            dist = S;
            while (dist <= 42)
            {
                c++;
                dist = dist * (100 + I) / 100;
            }

            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            double eps = 0.0001;
            double delta = 1e-7;

            for (double x = a; x <= b + delta; x += h)
            {
                double x_power = 1;
                long fact = 1;
                int i = 0;

                do
                {
                    if (i > 0)
                    {
                        fact *= i;
                    }
                    SS += ((2 * i + 1) * x_power) / fact;
                    x_power *= x * x;
                    i++;
                } while (Math.Abs(((2 * i + 1) * x_power) / fact) >= eps);
                
                double y = (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
                
                SY += y;
            }

            // end

            return (SS, SY);
        }
    }
}