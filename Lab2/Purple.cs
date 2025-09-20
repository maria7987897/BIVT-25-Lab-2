using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            
            for (int i=1; i<=n; i++)
            {
                int a = (p + h*(i - 1) );
                answer += a * a;
                Console.WriteLine(answer);
            }
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a >= b)
            {
                a = a - b;
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
            // a/b c/d a+c/b+d
            // 1/1 2/1 3/2
            double a1=1,b1=1,a2=2,b2=1,a3=3,b3=2,a4=0,b4=1;
            while (true)
            {
                a4 = a2 + a3; b4 = b2 + b3; //calculating num4 parts

                if (Math.Abs((a3 / b3) - (a4 / b4)) < E)
                {
                    answer = a4 / b4;
                    break;
                }

                a1 = a2; b1 = b2; //num2->num1, forget num1
                a2 = a3; b2 = b3; //num3->num2
                a3 = a4; b3 = b4; //num4->num3

            }
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            while (true)
            {
                answer++;
                if (Math.Abs(b) < E)
                {
                    break;
                }
                b *= q;
                //num = num * q
            }
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
            ulong a = 0;
            ulong count = 1;
            for (int i = 1; i <= 64; i++)
            {
                a += count;
                count *= 2;
            }
            answer = (long)(a / 15_000_000);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0; //doubles as month counter

            // code here
            double d_monthly = d / 1200;
            double double_S = 2 * S;
            double year_start_S = 0;
            while (S < double_S)
            {
                if (answer % 12 == 0)
                {
                    year_start_S = S;
                }
                    S = S + year_start_S * d_monthly;
                answer++;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
{
    const double E = 0.0001;
    double SS = 0;
    double SY = 0;
    //double x = 0;
    // code here
    for (decimal x = (decimal)a; x <= (decimal)b; x += (decimal)h) // x in [a,b]
    {
        decimal s_sum = 0; //row
        decimal s = 1; //row member
        int i = 0;
        while (Math.Abs(s) >= (decimal)E) //sum of rows for x
        {

            //s1 (-1*x*x)^i
            decimal s1 = 1;
            for (int i1 = 1; i1 <= i; i1++)
            {
                s1 *= (-1 * x * x);
            }

            decimal s2 = 1;
            //s2 (2i)!
            for (int i2 = 1; i2 <= 2 * i; i2++)
            {
                s2 *= i2;
            }

            s = (s1 / s2);  //s == s1/s2
            s_sum += s;
            i++;
        }
        SS += (double)s_sum; //adding row to sum of S

        double y = Math.Cos((double)x);
        SY += y; //addinf cos(x) to sum of Y
    }
        // SS=Math.Round(SS, 6);
        // SY=Math.Round(SY, 6);
    // end

            return (SS, SY);
}
    }
}