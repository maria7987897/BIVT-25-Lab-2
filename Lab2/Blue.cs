using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;


namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            for (int i = 0; i < n; i++)
            {
                answer += Math.Sin((i + 1) * x) / Math.Pow(x, i);
            }

            return answer;
        }
        public double Task2(int n)
        {   
            


            double answer = 0;
            long k = 1;
            for (int i = 1; i <= n; i++) 
            {
                k *= i;
                answer += Math.Pow(-1, i) * Math.Pow(5, i) / k;
            }
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            long fib_1 = 0, fib_2 = 1, fib;

            for (int i = 1; i < n; i++)
             {
                fib = fib_1 + fib_2;
                fib_2 = fib_1;
                fib_1 = fib;
                answer += fib;
             }
            
            


            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            int sum = a;

            while (sum <= L)
            {
                answer++;
                if (sum == L)
                {
                    break;
                }
                else
                {
                    sum += a + answer * h;
                }
            }
            
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0, ch = 0, zn = 1, elem = ch/zn;
            int i = 1;
            ch += i;
            zn *= x;
            answer += elem;
            elem = ch / zn;
            i++;
            while (elem > 0.0001)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }

            

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;
            int sum = S;

            
            while (sum <= L)
            {
                if (sum  != L)
                {
                    sum *= 2;
                    answer += h;
                }
                else
                {
                    return answer;
                }
            }

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0, r = 100, speed = S;
            int b = 0;
            int c = 0;

            for (int i = 0; i < 7; i++)
            {
                a += S * Math.Pow((1 + I/100), i);
            }

            while (r > 0)
            {
                r -= S * Math.Pow((1 + I/100), b);
                b += 1;
            }

            while (speed < 42)
            {
                c += 1;
                speed = S*Math.Pow((1 + I/100), c);
                
            }

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b; x += h) 
            {
                x = Math.Round(x, 2);
                int i = 1, k = 1;
                double S = 0, c;
                c = 1;
                while (c >= E)
                {
                   
                    S += c;
                    c = (2 * i + 1) * Math.Pow(x, 2 * i) / k;
                    i++;
                    k *= i;
                }
                SS += S + c;
            }


            for (double x = a; x <= b; x += h)
            {
                x = Math.Round(x, 2);
                SY += (1 + 2 * Math.Pow(x, 2)) * Math.Pow(Math.E, Math.Pow(x, 2));
            }

            return (SS, SY);
        }
    }
}