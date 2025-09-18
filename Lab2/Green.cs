using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        const double axaxa = 1e-9;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            double N = double.Parse(Console.ReadLine());
            double ans = 0.0;
            for (int i = 1; i <= N; i+=2)
            {
                double f = 2.0 * i;
                double l = 2.0 * i + 1.0;
                ans += f / l;
            }
            Console.WriteLine(Math.Round(ans, 6));
            // end
            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double summ = 0.0;
            for (int i = 0; i <= n; i++)
            {
                summ += Math.Pow(x, -i);
            }
            Console.WriteLine(summ);
            // end
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int k = int.Parse(Console.ReadLine());
            long summ = 0;
            long f = 1;
            for (int i = 1; i <= k; i++)
            {
                f *= i;  
                summ += f;    
            }
            Console.WriteLine(summ);
            // end
            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double y = double.Parse(Console.ReadLine());
            double eps = 0.001;
            double summ = 0;
            int k = 1;
            while (true)
            {
                double term = Math.Sin(k * Math.Pow(y, k));
                if (Math.Abs(term) < eps) break;
                summ += term;
                k++;
            }
            Console.WriteLine(summ);
            // end
            return answer;
        }
        public int Task5(double x)
        {
            int answer = 1;
            // code here
            double x1 = x;
            while (Math.Abs(1 / x1 - x / x1) >= E)
            {
                answer++;
                x1 *= x;
            }
            // end
            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            // code here
            int el = 1;
            for (int i = 0; el < limit; i++)
            {
                el *= 2;
                answer += el;
            }
            // end
            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            // code here
            double cur = L;
            while (cur > Da)
            {
                cur /= 2;
                answer++;
            }
            // end
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            
            // code here
            for (double x = a; x <= b + 1e-9; x += h)
            {
                double s = 0;
                double x2 = x;
                int sign = 1;
                int i = 0;
                while (true)
                {
                    double t = sign * x2 / (2 * i + 1);
                    s += t;
                    if (Math.Abs(t) < E) {break;}
                    x2 *= x * x;
                    sign = -sign;
                    i++;
                }
                SS += s;
                SY += Math.Atan(x);
            }
            // end
            return (SS, SY);
        }
    }
}