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
                answer += (p + n * h) * (p + n * h);

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
            double prevCh = 1;
            double prevZn = 1;
            double prevPrevCh = 1;
            double prevPrevZn = 1;

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
            int i = 0;
            double qi = 1;

            while (b * qi >= E)
            {
                qi *= q;
                i++;
            }

            return i;
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

            while (number <= 10)
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
            double copy = S;
            double monthlyRate = d / 100.0 / 12.0;
            int months = 0;

            while (copy < 2.0 * S)
            {
                copy *= (1.0 + monthlyRate);
                months++;
            }

            return months;
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;



            return (SS, SY);
        }
    }
}
