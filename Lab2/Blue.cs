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
            double X=1;
            for (int i = 1; i <= n; i++)
            {
                answer = answer + (Math.Sin(i*x)/X);
                X = X * x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double p = 5;
            for (int i = 1; i <= n; i++)
            {
                double f = 1;
                for (int j=1;j<=i; j++)
                {
                    f = j * f;
                }
                answer = answer + (Math.Pow(-1,i) * (p / f));
                p = p * 5;
                
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a=0, b=1;
            for (int i = 1; i <= n; i++)
            {
                answer = answer + a;
                long c = b;
                b = a + b;
                a = c;
            }
            


            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here

            int s=0;
            while (s <= L)
            {
                s = s + a + (answer * h);
                answer++;
            }
            answer--;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            double elem = ch / zn;
            int i = 1;

            
            ch += i; zn *= x;
            answer += elem;
            elem = ch / zn;
            i++;

            while (elem > 0.0001)
            {
                ch += i; zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here

            // S < L 

            while (S < L)
            {
                answer = answer + h;
                S = S + S;
            }

            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here

            double Sa = S;
            for (int i = 1; i <= 7; i++)
            {
                a = a + Sa;
                Sa = Sa * (1 + I/100);
            }
            double s=0;

            double Sb = S;
            while (s < 100){
                s = s + Sb;
                Sb = Sb * (1 + I/100);
                b++;
            }
            double Sc = S;
            while (Sc <= 42)
            {
                Sc = Sc * (1 + I/100);
                c++;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            
            // code here

            int Fact(int x)
            {
                int S = 1;
                for (int i = 1; i <= x; i++)
                {
                    S *= i;
                }
                return S;
            }

            double MyPow(double x, int n)
            {
                double S = 1;
                for (int i = 0; i < n; i++)
                {
                    S *= x;
                }
                return S;
            }
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b; x += h)
            {
                x = Math.Round(x, 5);
                double S = 0;
                int i = 0;
                while (true)
                {
                    double el = ((2 * i + 1) * MyPow(x, 2 * i)) / Fact(i);
                    
                    S += el;
                    if (Math.Abs(el) < 0.0001) break;
                    i++;
                }
                SS += S;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
                Console.WriteLine($"{SS}, {SY}");

            }
            
            SS = Math.Round(SS, 6);
            SY = Math.Round(SY, 6);
            // end

            return (SS, SY);
        }
    }
}