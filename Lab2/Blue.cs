using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double den = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += (Math.Sin(i * x) / den);
                den *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            int sign = 1;
            double five = 1;
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                five *= 5;
                fact *= i;
                sign *= -1;
                answer += sign * five / fact;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a1 = 0;
            long a2 = 1;
            for (int i = 0; i < n; i++)
            {
                answer += a1;
                long temp = a1 + a2;
                a1 = a2;
                a2 = temp;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int sum = 0;
            int cur = a;
            while (sum + cur <= L)
            {
                sum += cur;
                answer += 1;
                cur += h;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }
            while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int time = 0;
            int cells = S;
            while (cells <=  L)
            {
                cells *= 2;
                time += h;
            }
            answer = time;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            // a)
            double day = S; 
            for (int i = 1; i <= 7; i++)
            {
                a += day;
                day += (day * I )/ 100;
            }
            // b)
            day = S;
            double km = 0;
            while (km <= 100)
            {
                b++;
                km += day;
                day += (day * I) / 100;
            }
            // c)
            day = S;
            c = 0;
            while (day <= 42)
            {
                day += (day * I) / 100;
                c++;
            }
            // end

            return (a, b, c);
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
                    elem = elem * x * x * (2 * i + 1) / (i * (2 * i - 1));
                    SS += elem;
                }
                elem = x * x;
                SY += (1 + 2 * elem) * Math.Exp(elem);
                x += h;
            }
            // end

            return (SS, SY);
        }
    }
}
