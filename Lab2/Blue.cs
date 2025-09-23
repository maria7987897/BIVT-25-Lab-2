using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x) // без pow решаем и двойного цикла
        {
            double answer = 0;
            double pow = 1;
            // code here
            for (int AnotherN = 1; AnotherN <= n; AnotherN++)
            {
                answer += Math.Sin(AnotherN * x) / pow;
                pow *= x; 
            }
            // end

                return answer;
        }
        public double Task2(int n) // сделать только один цикл и без pow. Только реккурентные формулы. 
        {
            double answer = 0;
            long fact = 1;
            double Pow = 1;
            // code here
            for (int AnotherN = 1; AnotherN <= n; AnotherN++)
            {
                Pow *= 5;
                fact *= AnotherN;
                if ((AnotherN % 2) == 0)
                {
                    answer += Pow / fact;
                }
                else
                {
                    answer -= Pow / fact;
                }


            }
            // end 

            return answer;
        }

        public long Task3(int n)
        {
            if (n <= 0) return 0;

            long answer = 0;
            int Pre = 1;
            int PrePre = 0;
            int fib;

            for (int i = 0; i < n; i++)
            {
                answer += PrePre;
                fib = Pre + PrePre;
                PrePre = Pre;
                Pre = fib;
            }

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int suma = 0;
            answer = 1;
            while (suma <= L)
            {
                suma += a + (answer - 1) * h;
                answer += 1;
            }
            // end

                return answer-2;
        }
        public double Task5(double x) // не работает
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem = ch/zn;
            int i = 1;
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
            int a = 0;
            // code here
            while (S < L)
            {
                S *= 2;
                a++;
            }
            answer = a * h;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            double SaveS = S;
            int b = 0;
            int c = 0;
            double SumForB = 0;
            // code here
            for (int day = 0; day < 7; day++)
            {
                a += S;
                S = S * (1 + I / 100);
            }
            S = SaveS;
            while (SumForB <= 100)
            {
                SumForB += S;
                S = S * (1 + I / 100);
                b++;
            }
            S = SaveS;
            while (S <= 42)
            {
                S = S * (1 + I / 100);
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
            for (double x = a; x <= b + 0.0001; x += h)
            {
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
                double p = 1;
                double f = 1;

                for (int i = 0; ; i++)
                {
                    if (i != 0)
                        f *= i;
                    double t = (2 * i + 1) * p / f;
                    SS += t;
                    p *= x * x;
                    if (Math.Abs(t) < 0.0001)
                        break;
                }
            }
            // end

                return (SS, SY);
        }
    }
}
