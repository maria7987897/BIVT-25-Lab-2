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

            // code here
            for (int i = 1; i <= n; i++)
                answer += (p + (i - 1) * h) * (p + (i - 1) * h);
            // end

            return answer;
        }

        public (int quotient, int remainder) Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a >= b)
            {
                quotient += 1;
                a -= b;
            }
            remainder += a;
            // end

            return (quotient, remainder);
        }

        public double Task3()
        {
            double answer = 0;

            // code here
            (double, double) first = (2.0, 1.0);
            (double, double) second = (3.0, 2.0);
            (double, double) next = (first.Item1 + second.Item1, first.Item2 + second.Item2);
            while (Math.Abs(next.Item1 / next.Item2 - second.Item1 / second.Item2) > 0.0001)
            {
                first = second;
                second = next;
                next = (first.Item1 + second.Item1, first.Item2 + second.Item2);
            }
            answer = next.Item1 / next.Item2;
            // end

            return answer;
        }

        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double qTemp = 1;
            for (int n = 1; Math.Abs(b * qTemp) > 0.0001; n++)
            {
                answer = n + 1;
                qTemp *= q;
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
            ulong countSeed = 0, cell = 1;
            for (int n = 1; n < 65; n++)
            {
                countSeed += cell;
                cell <<= 1;
            }
            answer = Convert.ToInt64(countSeed / 15000000);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            if (S != 0)
            {
                double monthPercent = S * (d / 100) / 12;
                double prevS = S;
                while (prevS <= 2 * S)
                {
                    if (answer % 12 == 0)
                        monthPercent = prevS * (d / 100) / 12;
                    answer += 1;
                    prevS += monthPercent;
                }
            }
            // end

            return answer;
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            // code here
            for (var x = a; x <= b + 0.00000001; x += h)
            {
                double xPower = 1;
                long fact = 1;
                double elem1 = 1;
                int i = 0;

                while (Math.Abs(elem1) >= 0.0001)
                {
                    int sign = (i % 2 == 0) ? 1 : -1;
                    elem1 = sign * xPower / fact;
                    SS += elem1;

                    i++;
                    xPower *= x * x; 
                    fact *= (2 * i - 1) * (2 * i); 
                }
                SY += Math.Cos(x);
            }
            // end

            return (SS, SY);
        }
    }
}