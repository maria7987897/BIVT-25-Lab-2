using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            double x_pow = 1;
            // code here
            for (int i = 1; i <= n; i++) {
                answer += Math.Sin(i*x)/(x_pow);
                x_pow *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            double a = (-1) * 5.0 / 1.0;
            // code here
            for (int i = 1; i <= n; i++) {

                answer += a;
                a *= (-1) * 5.0 / (i + 1);
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            long fib_a = 0;
            long fib_b = 1;
            // code here
            for (int i = 1; i <= n; i++)
            {

                answer += fib_a;
                fib_b += fib_a;          
                fib_a = fib_b - fib_a ;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            double sm = 0;
            int n = 1;
            // code here
            while (sm + (a + (n - 1) * h) <= L){

                sm += ( a + (n - 1) * h );
                n++;
                
            }
            answer = n-1;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;
            // code here
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            long c = S;
            int t = 0;
            // code here
            while (c < L)
            {
                c *= 2;
                t += h;
            }
            answer = t;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double p = S;
            a += p;
            for (int i = 0; i < 6; i++)
            {
                p = p + (I / 100) * p;
                a += p;
            }
            p = S;
            double sm = 0;
            while (sm < 100)
            {
                sm += p;
                b++;
                p = p + (I / 100) * p;
            }
            p = S;
            while (p < 42)
            {
                p = p + (I / 100) * p;
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
            double sm = 0;
            for (double x = a; x <= b + 0.0001; x += h)
            {
                Console.WriteLine(x);
                sm = 0;
                double x_pow = 1;
                double i_fact = 1;
                int i = 0;
                double el = ((2 * i + 1) * x_pow) / (i_fact);
                while (Math.Abs(el) > 0.0001)
                {

                    el = ((2 * i + 1) * x_pow) / (i_fact);
                    sm += el;

                    i++;
                    x_pow *= x * x;
                    i_fact *= i;

                }
                SS += sm;
                SY += (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
            }
            Console.WriteLine((SS, SY));
            // end

            return (SS, SY);
        }
    }
}