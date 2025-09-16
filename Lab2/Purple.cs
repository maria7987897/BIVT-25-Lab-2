using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;
            
            // code here
            for (int i = 0; i < n; i++)
            {
                answer += (p + i*h) * (p + i*h);
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a - b >= 0)
            {
                a -= b;
                quotient++;
            }
            remainder = a;
            
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double ch1 = 2;
            double zn1 = 1;
            double ch2 = 3;
            double zn2 = 2;
   
            while (true)
            {
                Console.WriteLine($"{ch1}/{zn1}, {ch2}/{zn2}, {Math.Abs(ch1 / zn1 - ch2 / zn2)}");
                if (Math.Abs(ch1 / zn1 - ch2 / zn2) < 0.0001)
                {
                    answer = ch2 / zn2;
                    break;
                }
                else
                {
                    var a = ch2;
                    var b = zn2;
                    ch2 += ch1;
                    zn2 += zn1;
                    ch1 = a;
                    zn1 = b;
                }
                    
            }
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            int n = 0;
            while ((Math.Abs(b * Math.Pow(q, n)) >= 0.0001)) n++;
            answer = n + 1;
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

            // code here
            answer = (long)(Math.Pow(2, 64) / 15 / 1_000_000);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            int month = 0;
            double startS = S;
            double X2S = S * 2;
            while (S < X2S)
            {
                S += startS * d / 100 / 12;
                if (month % 12 == 0) startS = S;
                month++;
            }
            answer = month;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            static double Fact(int n)
            {
                int res = 1;
                for (int i = 1; i <= n; i++) res *= i;
                return res;
            }
            
            for (double x = a; x <= b; x += h)
            {
                int i = 0;
                while (true)
                {
                    double el = Math.Pow(-1, i) * (Math.Pow(x, 2*i) / Fact(2*i));
                    SS += el;
                    if (Math.Abs(el) < 0.0001) break;
                    i++;
                }
                
                SY += Math.Cos(x);
            }
            
            // end

            return (SS, SY);
        }
    }
}