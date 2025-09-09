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
            int remainder = 0;

            

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            int prevCh = 1;
            int prevZn = 1;

            for (int i = 1; i < 1000; i++)
            {
                int ch = prevCh + 1;
                int zn = prevZn == 1 ? 1 : prevZn + 1;

                if (Math.Abs(prevCh / prevZn - ch / zn) < E)
                {
                    answer = ch / zn;
                    break;
                }
            }
            
            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (b * Math.Pow(q, i) < E)
                {
                    answer = i;
                    break;
                }
            }

            return answer;
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
            long answer = 1;

            double tonns = 0;    
            for (int i = 0; i < 64; i++)
                tonns += tonns * 2 / 15 / 1000000;

            answer = (long) Math.Floor(tonns);

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            double copy = S;
            while (copy != 2 * S)
                S += S * (1 + d / 100 / 12);

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            

            return (SS, SY);
        }
    }
}
