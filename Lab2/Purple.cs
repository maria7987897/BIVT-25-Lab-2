using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Transactions;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                answer += (p + i * h) * (p + i * h);
            }
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
                a -= b;
                quotient++;
            }
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double last = 1.0;
            double[,] drobi = { { 2, 1 }, { 3, 2 } };
            while (Math.Abs(answer - last) >= 0.0001)
            {
                double chisl = drobi[0, 0] + drobi[1, 0];
                double znam = drobi[0, 1] + drobi[1, 1];
                answer = (chisl / znam);
                drobi[0, 0] = drobi[1, 0];
                drobi[0, 1] = drobi[1, 1];
                drobi[1, 0] = chisl;
                drobi[1, 1] = znam;
                last = (drobi[0, 0] + drobi[1, 0]) / (drobi[0, 1] + drobi[1, 1]);
            }
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double multiplier = b;
            double current = 1.0;
            while (Math.Abs(multiplier) >= 0.0001)
            {
                multiplier = b * current;
                current *= q;
                answer++;
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
            if (!(b > 0))
            {
                while (number >= 10)
                {
                    number /= 10;
                    answer++;
                }
            }
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            long[] multipies = new long[64];
            multipies[0] = 2;
            for (int i = 1; i < 64; i++)
            {
                long nextTurn = multipies[i - 1] * 2;
                if (nextTurn > long.MaxValue / 2) nextTurn /= 1000000;
                multipies[i] = nextTurn;
            }
            answer = multipies[multipies.Length - 1] / 15;
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            //code here
            if (S <= 0) return answer;
            double currentSum = S;
            double sum = S;
            double targetSum = 2 * S;
            double percentBonus = d / 100 / 12;
            while (currentSum < targetSum)
            {
                if (answer % 12 == 0 && answer != 0)
                {
                    currentSum += sum * percentBonus;
                    sum = currentSum;
                }
                else currentSum += sum * percentBonus;
                answer++;
            }
            //end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double S = 0, Current = 0; 
            int i = 0, Factorial = 1;
            for (double x = a; x <= b + 0.000001; x += h)
            {
                while (Math.Abs(Current) >= 0.0001)
                {
                    for (int j = 1; j <= 2 * i; j++)
                    {
                        Factorial *= j;
                    }
                    Current = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / Factorial;
                    S += Current;
                    i++;
                }
                double y = Math.Cos(x);
                SY += Math.Round(y, 6);
                SS += Math.Round(Math.Abs(S - y), 6);
            }
            // end

            return (SS, SY);
        }
    }
}
