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
                if (Math.Abs((a3 / b3) - (a4 / b4)) < E)
                {
                    answer = a4 / b4;
                    break;
                }
                a4 = a2 + a3; b4 = b2 + b3; //calculating num4 parts

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

            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here

            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}