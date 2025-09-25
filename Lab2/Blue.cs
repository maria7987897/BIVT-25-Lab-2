using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
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
            for (int i = 1; i < (n + 1); i++)
            {
                answer += (Math.Sin(i * x) / (Math.Pow(x, (i - 1))));

            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            for (int i = 1; i < (n + 1); i++)
            {
                long factorial = 1;
                int n2 = i;
                while (n2 > 0)
                {
                    factorial = factorial * n2;
                    n2 -= 1;


                }

                answer += (Math.Pow(-1, i) * ((Math.Pow(5, i)) / (factorial)));
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int i = 0;
            int i1 = 0;
            int i2 = 1;
            while (i < n)
            {

                //Console.WriteLine(i);
                //Console.WriteLine("i1 = " + i1);
                //Console.WriteLine("i2 = " + i2);
                //Console.WriteLine("i1 + i2 = " + i3);
                //Console.WriteLine(i1);
                answer += i1;
                int i3 = i1 + i2;
                i1 = i2;
                i2 = i3;
                i++;


            }
            //Console.WriteLine(answer);

            // end

            return answer;
        }
        public int Task4(int a, int h, int L) // 3 30 10
        {
            int answer = 0;

            // code her
            int n = 1;
            if (a > L) return 0;
            long S = a;

            while (true)
            {
                int sn = a + (n * h);
                if (S + sn > L)
                {
                    break;
                }

                S += sn;
                n++;
            }
            answer = n;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;
            while (true)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
                if (elem <= 0.0001) break;

            }

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S < L)
            {
                answer += h;
                S *= 2;
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
            double Sum = 0;
            int i = 0;
            bool Ta = false;
            bool Tb = false;
            bool Tc = false;

            while (true)
            {
                i++;

                if ((S > 42) && !Tc)
                {
                    c = i - 1;
                    Tc = true;
                }

                Sum += S;

                if ((i == 7) && !Ta)
                {
                    a = Sum;
                    Ta = true;
                }
                if ((Sum >= 100) && !Tb)
                {
                    b = i;
                    Tb = true;
                }
                if (Ta && Tb && Tc)
                {
                    break;
                }

                S *= (1 + I / 100);
            }
            // end

            return (a, b, c);
        }
        //public (double SS, double SY) Task8(double a, double b, double h)
        //{
        //    double SS = 0;
        //    double SY = 0;

        //    for (double x = a; x <= (b+0.001); x += h)
        //    {
        //        double S = 0;
        //        int i = 0;
        //        double te = 0;
        //        double fact = 1;
        //        x = Math.Round(x);

        //        while (true)
        //        {
        //            te = ((2 * i + 1) * (Math.Pow(x, (2 * i)))) / fact;
        //            te = Math.Round(te, 6);


        //            if (te < 0.0001) break;
        //            else
        //            {
        //                S += te;
        //                i++;
        //                fact *= i;
        //            }
        //        }

        //        double y = (1 + 2 * (Math.Pow(x, 2))) * Math.Pow(Math.E, (Math.Pow(x, 2)));
        //        SS += S;
        //        SY += y;
        //    }

        //    return (SS, SY);
        //}


        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double epsilon = 0.0001;  

            for (double x = a; x <= b + 1e-10; x += h)
            {
                double sum = 0;
                int i = 0;
                double term;

                do
                {
                    term = (2 * i + 1) * Math.Pow(x, 2 * i) / Factorial(i);
                    sum += term;
                    i++;
                } while (Math.Abs(term) >= epsilon);

                double y = (1 + 2 * x * x) * Math.Exp(x * x);

                SS += sum;
                SY += y;
            }

            static double Factorial(int n)
            {
                double result = 1;
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
            // end
            return (SS, SY);
        }
    }
}
