using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Formats.Asn1;
using System.Net.Http.Json;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;
            double d = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / d;
                d *= x;

            }
                
            
            return answer;
        }
        long F(int n) // функция нахождения факториала
        {
            long ans = 1;
            if (n != 0)
            {
                for (long i = 1; i <= n; i++)
                {
                    ans *= i;
                }
            }
            return ans;
        }
        public double Task2(int n)
        {
            double answer = 0;
            if (n > 0)
            {
                long temp = 5;
                float t = -1F;
                for (int i = 1; i <= n; i++)
                {
                    answer += t * temp / (F(i));
                    t *= -1;
                    temp *= 5;
                }
            }

                return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            if (n > 1)
            {
                long a = 0, b = 1;
                answer = 1;
                for (int i = 2; i < n; i++)
                {
                    long next = a + b;
                    answer += next;
                    a = b;
                    b = next;
                }
            }

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0, s = 0;
            for (int i = 0; s < L; i++)
            {
                s += a + i * h;
                if (s <= L)
                    answer++;
            }
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            double c = 0, z = 1, elem = 0;
            if (x != 0)
            {
                int i = 1;
                c += i;
                z *= x;
                elem = c / z;
                if (elem > 0.0001)
                {
                    answer += elem;
                    while (elem > 0.0001)
                    {
                        i++;
                        c += i;
                        z *= x;
                        elem = c / z;
                        answer += elem;
                    }
                }
            }
            // end

                return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;
            while (S <= L)
            {
                S *= 2;
                answer += h;
            }

            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double s = S, a = s;
            double a1 = s;
            int b = 1, c = 1;
            // пункт А
            if (S > 0 && I > 0)
            {
                for (int i = 1; i < 7; i++)
                {
                    s *= (1 + I / 100);
                    a1 += s;
                }
                a = a1;

                // пункт Б
                s = S;
                a1 = s;
                while (a1 < 100)
                {
                    s *= (1 + I / 100);
                    a1 += s;
                    b++;
                }

                // пункт В
                s = S;
                a1 = s;
                while (s < 42)
                {
                    s *= (1 + I / 100);
                    a1 += s;
                    c++;
                }
            }
            return (a, b, c - 1);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b + E; x += h)
            {
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
                double t = 1;
                double p = 1;
                
                for (int i = 0; ; i++)
                {
                    t = (2 * i + 1) / (double)(F(i)) * p;
                    SS += t;
                    p *= x * x;
                    
                    if (Math.Abs(t) < E)
                    {
                        break;
                    }
                }
            }

            return (SS, SY);
        }
    }
}
