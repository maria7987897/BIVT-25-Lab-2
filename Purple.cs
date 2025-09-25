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

            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here

            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here

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
            double MyPow(double x, int n)
            {
                double S = 1;
                for (int i = 0; i < n; i++)
                {
                    S *= x;
                }
                return S;
            }
            int Fact(int x)
            {
                int S = 1;
                for (int i = 1; i <= x; i++)
                {
                    S *= i;
                }
                return S;
            }
            for (double x = a; x <= b; x += h)
            {
                x = Math.Round(x, 5);
                double S=0;
                int i = 0;
                while (true)
                {
                    double el = MyPow(-1, i) * MyPow(x,2*i)/Fact(2*i);
                    S += el;
                    if (Math.Abs(el) < 0.0001)
                        break;
                    i++;
                }
                SS += S;
                SY += Math.Cos(x);
            }
            SS = Math.Round(SS, 6);
            SY = Math.Round(SY, 6);
            // end

            return (SS, SY);
        }
    }
}