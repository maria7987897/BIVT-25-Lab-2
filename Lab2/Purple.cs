using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double eps = 0.0001;
        public int Task1(int n, int p, int h)
        {
            if (n <= 0)
            {
                return 0;
            }
            // без этого переполнилось
            long lN = n;
            long lP = p;
            long lH = h;
            // раскроем квадрат, сложим суммы 3 прогрессий
            // (p + i*h)^2 = p^2 + 2*p*i*h + h^2*i^2
            // S = n*p^2 + 2*p*h*(n(n-1)/2) + h^2*((n-1)n(2n-1)/6)
            long sum = lN * lP * lP
                      + lP * lH * lN * (lN - 1)
                      + lH * lH * (lN - 1) * lN * (2 * lN - 1) / 6;
            return (int)sum;
        }
        public (int quotient, int remainder) Task2(int a, int b)
        {
            int quotient = 0;
            while (a >= b)
            {
                ++quotient;
                a -= b;
            }
            return (quotient, a);
        }
        public double Task3()
        {
            const int maxIter = 100000;
            // a/b
            long aPrev = 1, a = 2;
            long bPrev = 1, b = 1;

            double prevValue = (double)aPrev / bPrev;
            double currValue = (double)a / b;
            int iter = 2;

            while (Math.Abs(currValue - prevValue) >= eps && iter < maxIter)
            {
                long aNext = a + aPrev;
                long bNext = b + bPrev;

                aPrev = a; bPrev = b;
                a = aNext; b = bNext;

                prevValue = currValue;
                currValue = (double)a / b;

                ++iter;
            }

            return currValue;
        }
        public int Task4(double b, double q)
        {
            double absB = Math.Abs(b);
            if (absB < eps)
            {
                return 1;
            }
            double absQ = Math.Abs(q);
            if (absQ == 0)
            {
                return 2;
            }
            // |b| * |q|^{i-1} < eps => |q|^{i-1} < eps/|b| => i-1 > ln{eps/|b|}/ln|q|
            // ( посередине взяли ln (монотонная),
            // правое следствие - ln|q| * log_{|q|}{q^{i-1}}} = ln{q^{i-1}} )
            // ln|q| < 0
            double x = Math.Log(eps / absB) / Math.Log(absQ);
            // n > x + 1 => minN = floor(x) + 2
            int n = (int)Math.Floor(x) + 2; // уже проверили |B|<eps и |q|<1, так что n валидное

            while (Math.Abs(b * Math.Pow(q, n - 1)) >= eps)
            {
                ++n;
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
                --b;
            }
            while (number >= 10)
            {
                number /= 10;
                ++answer;
            }
            return answer;
        }
        public long Task6()
        {
            ulong totalGrains = ulong.MaxValue;
            return (long)(totalGrains / (15UL/*grainsPerGram*/ * 1000000UL/*gramsPerTon*/));
        }

        public int Task7(double S, double d)
        {
            if (S <= 0 || d <= 0)
            {
                return 0;
            }

            double target = 2 * S;
            double r = d / 100;
            double amount = S;
            int years = 0;

            while (true)
            {
                double yearProfit = amount * r;
                if (amount + yearProfit >= target)
                {
                    // успеем внутри этого года, ищем месяц
                    double need = target - amount;
                    double monthly = yearProfit / 12;
                    int months = (int)Math.Ceiling(need / monthly - 1e-9);
                    if (months > 12)
                    {
                        months = 12;
                    }
                    return years * 12 + months;
                }
                
                amount += yearProfit;
                ++years;
            }
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            const int maxIter = 10000;
            bool forward = h > 0;
            double end = forward ? b + 1e-9 : b - 1e-9;
            
            for (double x = a; forward ? x <= end : x >= end; x += h)
            {
                // S = Sum_{i=0} (-1)^i * x^{2i} / (2i)!
                double term = 1; // i = 0
                double sum = term;

                for (int i = 0; i < maxIter; ++i)
                {
                    double denom = (2.0 * i + 1.0) * (2.0 * i + 2.0);
                    term *= - (x * x) / denom;
                    sum += term;
                    if (Math.Abs(term) < eps)
                    {
                        break;
                    }
                }

                SS += sum;
                SY += Math.Cos(x);
            }
            return (SS, SY);
        }
    }
}