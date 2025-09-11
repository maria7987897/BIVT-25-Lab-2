using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;

        public static long factorial(int n)
        {
            long answer = 1;
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }
            return answer;
        }
        
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                answer += (int) Math.Pow(p + i * h, 2);
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
                quotient++;
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

            int a = 1;
            int b = 1;
            int c = 2;
            int d = 1;
            double cur, prev;
            cur = (double)c / (double)d;
            prev = (double)a / (double)b;
            while (Math.Abs(cur - prev) >= E)
            {
                c = a + c;
                d = b + d;
                a = c - a;
                b = d - b;
                cur = (double)c / (double)d;
                prev = (double)a / (double)b;
            }

            answer = cur;
            
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            int c = 1;
            while (true)
            {
                double val = Math.Abs(b * Math.Pow(q, c - 1));
                
                if (val < E)
                {
                    break;
                }
                c += 1;
                
            }
            answer = c;
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

            while (number > 10)
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

            double rice = 0;
            for (int i = 0; i < 64; i++)
            {
                rice += Math.Pow(2, i);
            }
            
            answer = (long )Math.Round(rice / 15 / 1000 / 1000);
            
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here

            double e = S;
            double dop=0;
            while (e < 2 * S)
            {
                
                if (answer % 12 == 0)
                {
                    dop = e * d / 100 / 12;
                }
                answer++;
                e += dop;

            }
            
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            
            int n = (int) Math.Floor((b - a) / h + 1e-12);
            for (int k = 0; k <= n; k += 1)
            {
                double t = 1.0;
                double x = a + k * h;
                
                for (int i = 0;; i += 1)
                {
                    if (Math.Abs(t) < E) break;
                    SS += t;
                    double f = -(x * x) / ((2.0 * i + 1) * (2.0 * i + 2));
                    t *= f;
                }

                SY += Math.Cos(x);
            }
            
            // end

            return (SS, SY);
        }
    }
}
