using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices;
namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public double Task1(int n, int p, int h)
        {
            double answer = 0;

            for (int i = 0; i < n; i++)
            {
                int term = p + i * h;
                answer += Math.Pow(term, 2);
            }

            return answer;
        }

        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = a;
            // code here
            while (remainder >= b)
            {
                remainder -= b;
                quotient++;
                if (remainder < b)
                {
                    break;
                }
                
                
            }
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;
            double eps = 0.0001;
            List<BigInteger> chisl = new List<BigInteger>() { 1, 2 };
            List<BigInteger> znam = new List<BigInteger>() { 1, 1 };
            // code here
            for (int c = 2; c < 50; c++)
            {
                chisl.Add(chisl[c-1] + chisl[c-2]);
                
            }

            for (int z = 2; z < 50; z++)
            {
                znam.Add(znam[z-1] + znam[z-2]);
            }

            for (int i = 1; i < 20; i++)
            {
                double dr1 = (double)chisl[i] / (double)znam[i];
                double dr2 = (double)chisl[i - 1] / (double)znam[i - 1];
                if (Math.Abs(dr1 - dr2) < eps)
                {
                    answer = dr1;
                    break;
                }

            }
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;
            double eps = Math.Pow(10, -4);
            // code here
            for (int n = 1; n < 10000; n++)
            {
                double term = b * Math.Pow(q, n - 1);
                if (Math.Abs(term) < eps)
                {
                    return n;
                }
            }

            return 0;
            // end


        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;
            // code here
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
            BigInteger res = 0;
            // code here
            for (int n = 0; n <= 63; n++)
            {
                res += BigInteger.One << n;
                
            }
            BigInteger tons = res / 15 / 1000 / 1000;
            answer = (long)tons;
            return answer;
            // end

        }

        public int Task7(double S, double d)
        {
            if (S <= 0 || d <= 0) return 0;

            double current = S;
            int months = 0;
            while (current < 2.0 * S)
            {
                double monthly = current * d / 1200.0; 
                for (int m = 0; m < 12 && current < 2.0 * S; m++)
                {
                    months++;
                    current += monthly;
                }
            }

            return months;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double eps = 0.0001;
            
            // code here
            static long Factorial(int n)
            {
                long result = 1;
                for (int i = 2; i <= n; i++)
                    result *= i;
                return result;
            }
            
            for (double x = a; x <= b + 0.0001; x += h)
            {
                double s = 0;
                SY += Math.Cos(x);
                for (int i = 0; i < 100; i++)
                {
                    double term = Math.Pow(-1, i) * (Math.Pow(x, 2 * i) / Factorial(2 * i));
                    s += term;
                    if (Math.Abs(term) < eps)
                    {
                        break;  
                    }
                }

                SS += s;
            }
            // end

            return (SS, SY);
        }
    }
}
