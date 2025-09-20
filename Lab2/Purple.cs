using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        private double CalculateFrac((int, int) frac)
        {
            return (double)frac.Item1 / (double)frac.Item2;
        }
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                answer += (int)Math.Pow(p + i * h, 2);
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            quotient = a / b;
            remainder = a % b;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            (int, int) prevprev = (1, 1);
            (int, int) prev = (2, 1);
            while (true)
            {
                (int, int) next = (prevprev.Item1 + prev.Item1, prevprev.Item2 + prev.Item2);
                Console.WriteLine(next);
                if (Math.Abs(CalculateFrac(next) - CalculateFrac(prev)) < E)
                {
                    answer = CalculateFrac(next);
                    break;
                }
                prevprev = prev;
                prev = next;
            }
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double next = b;
            int index = 1;
            while (true)
            {
                if (Math.Abs(next) < E)
                {
                    answer = index;
                    break;
                }
                next = b * Math.Pow(q, index);
                index++;
            }
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
            long number = a;
            while (b > 0)
            {
                number *= b;
                b--;
            }
            while (number >= 10)
            {
                number /= 10;
                answer++;
            }
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            const int N = 8;
            double gramms = 0;
            for (long i = 0; i < Math.Pow(N, 2); i++)
            {
                gramms += Math.Pow(2, i) / 15.0;
                Console.WriteLine(gramms);
            }
            answer = (long)Math.Floor(gramms / (1000 * 1000));
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double total = S;
            double total_year_start = total;
            int months = 0;
            while (true)
            {
                if (months % 12 == 0)
                {
                    total_year_start = total;
                }
                if (total >= (S * 2))
                {
                    answer = months;
                    break;
                }
                total += total_year_start * (d / 1200);
                months++;
            }
            // end

            return answer;
        }
        public int Factorial(int a)
        {
            int answer = 1;
            for (int i = 1; i <= a; i++)
            {
                answer *= i;
            }
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + E; x += h)
            {
                int i = 0;
                while (true)
                {
                    double next = Math.Pow(-1, i) * ((double)Math.Pow(x, 2 * i) / (double)Factorial(2 * i));
                    SS += next;
                    if (Math.Abs(next) < E)
                    {
                        break;
                    }
                    i++;
                }
                SY += Math.Cos(x);
            }
            // end

            return (SS, SY);
        }
    }
}
