using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
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
            for (int i = 0; i < n; ++i)
            {
                answer += (p + h * i) * (p + h * i);
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a >= b)
            {
                ++quotient;
                a -= b;
            }
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double a = 1, b = 2;
            while (Math.Abs((a + b) / b - b / a) >= E)
            {
                b = a + b;
                a = b - a;
            }
            answer = (a + b) / b;
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double res = b;
            int i = 0;
            while (Math.Abs(res) >= E)
            {
                res *= q;
                ++i;
            }
            answer = (i == 0) ? 0 : i + 1; 
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
                --b;
            }
            while (number >= 10)
            {
                number /= 10;
                ++answer;
            }
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            BigInteger b = 1;
            for (int i = 1; i < 65; ++i, b *= 2);
            BigInteger a = (b - 1) / 15 / 1000000;
            answer = (long)a;
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double sum = S, begin = S;
            while (sum < 2 * S)
            {
                if (answer % 12 == 0)
                {
                    begin = sum;
                }
                sum += begin * d / 1200;
                ++answer;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double x = a;
            while (x <= b + E)
            {
                double elem = 1.0;
                SS += elem;
                for (int i = 1; Math.Abs(elem) >= E; ++i)
                {
                    elem = elem * (-1) * x * x / i / 2 / (2 * i - 1);
                    SS += elem;
                }
                SY += Math.Cos(x);
                x += h;
            }
            // end

            return (SS, SY);
        }
    }
}