using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            for (int i = 0; i < n; i++)
                answer += (p + i * h) * (p + i * h);

            return answer;
        }
        public (int quotient, int remainder) Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = a;

            while (remainder >= b)
            {
                remainder -= b;
                quotient++;
            }

            return (quotient, remainder);
        }
        public double Task3()
        {
            double prevPrevCh = 1, prevPrevZn = 1;
            double prevCh = 2, prevZn = 1;

            while (true)
            {
                double currentCh = prevCh + prevPrevCh;
                double currentZn = prevZn + prevPrevZn;

                if (Math.Abs(currentCh / currentZn - prevCh / prevZn) < E)
                    return currentCh / currentZn;

                prevPrevCh = prevCh;
                prevPrevZn = prevZn;
                prevCh = currentCh;
                prevZn = currentZn;
            }

        }

        public int Task4(double b, double q)
        {
            int n = 0;
            double qi = 1;

            while (Math.Abs(qi) >= E)
            {
                qi = Math.Pow(q, n) * b;
                n++;
            }


            return n;
        }

        public int Task5(int a, int b)
        {
            int answer = 0;
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

            return answer;
        }
        public long Task6()
        {
            double totalSeeds = 0;
            double currentSeeds = 1;

            for (int i = 0; i < 64; i++)
            {
                totalSeeds += currentSeeds;
                currentSeeds *= 2;
            }

            double totalTons = totalSeeds / 15.0 / 1000000.0;
            return (long)Math.Floor(totalTons);
        }

        public int Task7(double S, double d)
        {
            int months = 0;
            double target = 2 * S;
            double year = S * (d / 100.0); 

            while (S < target)
            {
                months++;
                S += year / 12.0;
                if (months % 12 == 0)
                    year = S * (d / 100.0);
            }

            return months;
        }


        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0; 
            double SY = 0; 
            double epsilon = 0.0001; 

            for (double x = a; x <= b + E; x += h)
            {
                double sum = 0;
                int i = 0;
                double term = 1;
               
                while (Math.Abs(term) > epsilon)
                {
                    int factorial = 1;
                    for (int j = 1; j <= 2 * i; j++)
                        factorial *= j;

                    int first = i % 2 == 0 ? 1 : -1;

                    double second = 1;
                    for (int j = 0; j < 2 * i; j++)
                        second *= x;

                    term = first * second / factorial;
                    sum += term;
                    i++;
                } 

                SS += sum;
                SY += Math.Cos(x);
            }

            return (SS, SY);
        }

    }
}
