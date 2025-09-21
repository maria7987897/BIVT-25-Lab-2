using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
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
            double s = 0, zn = 1;
            for (int i = 0, k = 1 ; i < n; i++, k++, zn*=x)
            {
                s += Math.Sin(k * x) / (zn);
            }
            answer = s;
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double p = -5, fact  =1;
            for (int i = 1; i <= n; i++, p *= (-5))
            {
                fact *= i;
                answer += p / fact;
            }    

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;

            // code here
            if (n <= 1) return 0;
            if (n == 2) return 1;
            int a = 0, b = 1;
            for (int i = 3; i <= n; i++)
            {
                answer += a + b;
                b = a + b;
                a = b - a;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0, summa = 0, k = 0;

            // code here
            while (summa < L + 0.0001)
            {
                summa += a + k * h;
                k +=1;
                answer++;
            }
            // end

            return answer - 1;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1, elem = ch / zn;
            double i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }
            while (elem > E);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0, summa = S;
            

            // code here
            while (summa < L)
            {
                answer += h;
                summa *= 2;

            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double S_b = S, S_c = S;
            double summa = S;
            double a = S;
            int b = 1;
            int c = 0;

            // code here
            for (int i = 1; i <= 6; i++) {
                S = S + S * (I / 100);
                a += S;
            }
            while (summa < 100 - E)
            {
                S_b = S_b + S_b * (I/100);
                b++;
                summa += S_b;
            }
            while (S_c <= 42 + E) { 
                S_c = S_c + S_c * (I/100);
                c++;
            }

            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0, SY = 0;

            for (double x = a; x <= b + E; x += h)
            {
                double s_x = 0;
                int i = 0;
                double step = 1;
                double fact = 1;
                double elem = 0;

                do
                {
                    elem = (2 * i + 1) * step / fact;
                    s_x += elem;
                    i++;
                    step *= x * x; 
                    fact *= i;

                } while (Math.Abs(elem) >= E);

                SS += s_x;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }

            return (SS, SY);
        }
    }
}