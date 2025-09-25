using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for(int i = 1; i <= n; i++)
            {
                answer += (int)((p + (i - 1) * h) * (p + (i - 1) * h)); 
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while(a >= b)
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
            double eps = 0.0001;
            // code here
            int num1 = 1, num2 = 2;
            int del1 = 1, del2 = 1;
            double answer_past = (double)num1 / del1;
            double answer = (double)num2 / del2;

            while (Math.Abs(answer - answer_past) >= eps)
            {
                int num3 = num1 + num2;
                int del3 = del1 + del2;

                answer_past = answer;
                answer = (double)num3 / del3;


                num1 = num2;
                num2 = num3;
                del1 = del2;
                del2 = del3;
            }
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 1;
            double elem = b;

            // code here
            double eps = 0.0001;
            while (Math.Abs(elem) >= eps)
            {
                elem *= q;  
                answer += 1;
            }
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;
            // code here
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
            int gramm = 15;
            ulong grains = 1;
            for (int i = 0; i <= 63; i++)
            {
                grains *= 2;
            }
            answer = (long)(Math.Floor(((double)(grains-1) / gramm) / 1000000));
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double target = 2 * S;
            double monthPrc = S * d / 100.0 / 12.0;
            while (S < target)
            {
                S += monthPrc;
                answer++;
                if (answer % 12 == 0)
                {
                    monthPrc = S * d / 100.0 / 12.0;
                }
            }

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double eps = 0.0001;

            // code here
            for (double x = a; x <= b + 0.0001; x += h)
            {
                int i = 0;
                double p = 1, num = 1, den = 1;
                while (Math.Abs(p * num / den) >= eps)
                {
                    SS += p * num / den;
                    i++;
                    p = -p;
                    num *= x * x;
                    den *= 2 * i * (2 * i - 1);
                }
                SS += p * num / den;
                SY += Math.Cos(x);
            }
            // end

            return (SS, SY);
        }
    }
}