using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;
            // code here

            // end

            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here

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
            for (int i = 0; i<6; i++)
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
            for (double x = a; x <= b + 0.0001; x+=h)
            {
                Console.WriteLine(x);
                sm = 0;
                double x_pow = 1;
                double i_fact = 1;
                int i = 0;
                double el = ( (2 * i + 1) * x_pow )/ (i_fact);
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